using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Order
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TotalPizzaPrice = Math.Round(TotalPizzaPrice, 2);

        }
        decimal TotalPizzaPrice = 0m;

        string TotalPizzaPriceAsString;
        string SizeChoose;
        string CrustChoose;
        string EatingLocationChoose;
        string TopingsChoose="";

        private enum  enOrderPrices 
        {
            eSmall ,
            eMedium ,
            eLarge ,
            eThinCrust,
            eThinkCrust,
            eExtraChees,
            eMushroom,
            eTomatoes,
            eOnion,
            eOlives,
            eGreenPeppers,
            eEatIn,
            eEatOut
       
        }



        private  Dictionary<enOrderPrices, decimal> Prices =new Dictionary<enOrderPrices, decimal>()
            {
                { enOrderPrices.eSmall, 14.5m },
                { enOrderPrices.eMedium, 15.0m },
                { enOrderPrices.eLarge, 18.9m },
                { enOrderPrices.eThinCrust, 45.75m },
                { enOrderPrices.eThinkCrust, 89.99m },
                { enOrderPrices.eExtraChees, 19.25m },
                { enOrderPrices.eMushroom, 20.0m },
                { enOrderPrices.eTomatoes, 171.99m },
                { enOrderPrices.eOnion, 17.5m },
                { enOrderPrices.eOlives, 196.20m },
                { enOrderPrices.eGreenPeppers, 163.49m },
                { enOrderPrices.eEatIn , 12.6m  },
                {enOrderPrices.eEatOut , 17.49m }
            };


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(chkExtraChees.Checked)
            {
                SizeChoose += chkExtraChees.Text + "- ";
                //labToppingsValues.Text = labToppingsValues.Text;
                TotalPizzaPrice += Prices[enOrderPrices.eExtraChees];
                
            }
            else
            {
                TotalPizzaPrice -= Prices[enOrderPrices.eExtraChees];
                SizeChoose= SizeChoose.Replace(chkExtraChees.Text+"- ", "");
            }
            TotalPizzaPriceAsString = Math.Round(TotalPizzaPrice, 2).ToString("F2");
            labTotalOrderPrice.Text = TotalPizzaPriceAsString;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            gbPizzaSize.Enabled = true;
            gbPizzaCrust.Enabled = true;
            gbPizzaTopping.Enabled = true;
            gbWhereToEat.Enabled = true;
            rbSmallPizzaSize.Checked = false;
            rbMediumPizzaSize.Checked = false;
            rbLargPizzaSize.Checked = false;
            rbThinCrust.Checked= false;
            rbThinkCrust.Checked= false;
            rbEatIn.Checked = false;
            rbEatOut.Checked = false;
            chkExtraChees.Checked=false;
            chkGreenPeppers.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkOnion.Checked = false;
            chkTomatoes.Checked = false;
            TotalPizzaPrice = 0;
        }

        private void labCrustTypeSummary_Click(object sender, EventArgs e)
        {

        }

        private void rbPizzaEatIn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEatIn.Checked) 
            {

                EatingLocationChoose=rbEatIn.Text;
                TotalPizzaPrice += Prices[enOrderPrices.eEatIn];
            }
            else
            {
                TotalPizzaPrice -= Prices[enOrderPrices.eEatIn];

            }
            TotalPizzaPriceAsString = Math.Round(TotalPizzaPrice, 2).ToString("F2");
            labTotalOrderPrice.Text = TotalPizzaPriceAsString;



        }

        private void rdPizzaEatOut_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEatOut.Checked)
            {

                EatingLocationChoose = rbEatOut.Text;
                TotalPizzaPrice += Prices[enOrderPrices.eEatOut];

            }
            else
            {
                TotalPizzaPrice -= Prices[enOrderPrices.eEatOut];

            }
            TotalPizzaPriceAsString = Math.Round(TotalPizzaPrice, 2).ToString("F2");
            labTotalOrderPrice.Text = TotalPizzaPriceAsString;

        }

        private void rbSmallPizzaSize_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSmallPizzaSize.Checked) 
            {
                SizeChoose=rbSmallPizzaSize.Text;
                TotalPizzaPrice += Prices[enOrderPrices.eSmall];
            }
            else 
            {
                TotalPizzaPrice -= Prices[enOrderPrices.eSmall];
            }
            TotalPizzaPriceAsString = Math.Round(TotalPizzaPrice, 2).ToString("F2");
            labTotalOrderPrice.Text = TotalPizzaPriceAsString;
        }

        private void rbMediumPizzaSize_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMediumPizzaSize.Checked)
            {
                SizeChoose = rbMediumPizzaSize.Text;
                TotalPizzaPrice += Prices[enOrderPrices.eMedium];
            }
            else
            {
                TotalPizzaPrice -= Prices[enOrderPrices.eMedium];

            }
            TotalPizzaPriceAsString = Math.Round(TotalPizzaPrice, 2).ToString("F2");
            labTotalOrderPrice.Text = TotalPizzaPriceAsString;

        }

        private void rbLargPizzaSize_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLargPizzaSize.Checked)
            {
                SizeChoose = rbLargPizzaSize.Text;
                TotalPizzaPrice += Prices[enOrderPrices.eLarge];

            }
            else
            {

                TotalPizzaPrice -= Prices[enOrderPrices.eLarge];

            }
            TotalPizzaPriceAsString = Math.Round(TotalPizzaPrice, 2).ToString("F2");
            labTotalOrderPrice.Text = TotalPizzaPriceAsString;

        }

        private void rbPizzaThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            if(rbThinCrust.Checked)
            {
                CrustChoose = rbThinCrust.Text;
                TotalPizzaPrice += Prices[enOrderPrices.eThinCrust];
            }
            else
            {
                TotalPizzaPrice -= Prices[enOrderPrices.eThinCrust];

            }
            TotalPizzaPriceAsString = Math.Round(TotalPizzaPrice, 2).ToString("F2");
            labTotalOrderPrice.Text = TotalPizzaPriceAsString;




        }

        private void rbThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThinkCrust.Checked)
            {
                CrustChoose = rbThinkCrust.Text;

                TotalPizzaPrice += Prices[enOrderPrices.eThinkCrust];

            }
            else
            {

                TotalPizzaPrice -= Prices[enOrderPrices.eThinkCrust];

            }
            TotalPizzaPriceAsString = Math.Round(TotalPizzaPrice, 2).ToString("F2");
            labTotalOrderPrice.Text = TotalPizzaPriceAsString;

        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMushrooms.Checked) 
            {
                 TopingsChoose += chkMushrooms.Text + "- ";
                TotalPizzaPrice += Prices[enOrderPrices.eMushroom];

            }
            else
            {
                TotalPizzaPrice -= Prices[enOrderPrices.eMushroom];
                TopingsChoose= TopingsChoose.Replace(chkMushrooms.Text + "- ", "");

            }
            TotalPizzaPriceAsString = Math.Round(TotalPizzaPrice, 2).ToString("F2");
            labTotalOrderPrice.Text = TotalPizzaPriceAsString;

        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            if(chkTomatoes.Checked)
            {
                TopingsChoose +=chkTomatoes.Text + "- ";
                TotalPizzaPrice += Prices[enOrderPrices.eTomatoes];

            }
            else
            {
                TotalPizzaPrice -= Prices[enOrderPrices.eTomatoes];
                TopingsChoose= TopingsChoose.Replace(chkTomatoes.Text + "- ", "");

            }
            TotalPizzaPriceAsString = Math.Round(TotalPizzaPrice, 2).ToString("F2");
            labTotalOrderPrice.Text = TotalPizzaPriceAsString;

        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOnion.Checked)
            {
                TopingsChoose+=chkOnion.Text + "- ";
                TotalPizzaPrice += Prices[enOrderPrices.eOnion];

            }
            else
            {
                TotalPizzaPrice -= Prices[enOrderPrices.eOnion];
                TopingsChoose= TopingsChoose.Replace(chkOnion.Text + "- ", "");

            }
            TotalPizzaPriceAsString = Math.Round(TotalPizzaPrice, 2).ToString("F2");
            labTotalOrderPrice.Text = TotalPizzaPriceAsString;

        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            if( chkOlives.Checked)
            {
                TopingsChoose+= chkOlives.Text + "- ";
                TotalPizzaPrice += Prices[enOrderPrices.eOlives];

            }
            else
            {
                TotalPizzaPrice -= Prices[enOrderPrices.eOlives];
                TopingsChoose= TopingsChoose.Replace(chkOlives.Text + "- ", "");

            }
            TotalPizzaPriceAsString = Math.Round(TotalPizzaPrice, 2).ToString("F2");
            labTotalOrderPrice.Text = TotalPizzaPriceAsString;

        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            if(chkGreenPeppers.Checked)
            {
                TopingsChoose+=chkGreenPeppers.Text+"- ";
                TotalPizzaPrice += Prices[enOrderPrices.eGreenPeppers];

            }
            else
            {
                TotalPizzaPrice -= Prices[enOrderPrices.eGreenPeppers];
                TopingsChoose = TopingsChoose.Replace(chkGreenPeppers.Text+"- ", "");

            }
            TotalPizzaPriceAsString = Math.Round(TotalPizzaPrice, 2).ToString("F2");
            labTotalOrderPrice.Text = TotalPizzaPriceAsString;

        }

        private void labTotalPizzaOrderPrice_Click(object sender, EventArgs e)
        {

        }

        private void gbPizzaTopping_Enter(object sender, EventArgs e)
        {

        }

        private void labToppingsValues_Click(object sender, EventArgs e)
        {

        }
        private string PrepareOrderDetails()
        {        
            string FullOrderDetails="";
            string Delimiter = "#";
            FullOrderDetails += SizeChoose+ Delimiter;
            FullOrderDetails += CrustChoose + Delimiter;
            FullOrderDetails += TopingsChoose + Delimiter;
            FullOrderDetails += EatingLocationChoose+ Delimiter;
            FullOrderDetails += TotalPizzaPriceAsString;
            

            return FullOrderDetails;
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            DialogResult ComfirmationOrder=  MessageBox.Show("Comfirm Order", "Comfirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
            
            if(ComfirmationOrder==DialogResult.OK)
            {
                MessageBox.Show("Order Placed Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gbPizzaSize.Enabled= false;
                gbPizzaCrust.Enabled= false;
                gbPizzaTopping.Enabled= false;
                gbWhereToEat.Enabled= false;

                PizzaOrderSummary PizzaOrderSummaryForm = new PizzaOrderSummary(PrepareOrderDetails());
                PizzaOrderSummaryForm.Show();
            }
            else
            {
                MessageBox.Show("Order Canceled", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }


        }

        private void OrderPizzaMousEnter(object sender, EventArgs e)
        {
            btnOrderPizza.BackColor= Color.SkyBlue;

        }

        private void OrderPizzaMouseDown(object sender, MouseEventArgs e)
        {
            btnOrderPizza.BackColor = Color.Aquamarine;
        }

        private void OrderPizzaMouseLeave(object sender, EventArgs e)
        {
            btnOrderPizza.BackColor = Color.Chartreuse;

        }

        private void OrderPizzaMouseEnter(object sender, EventArgs e)
        {
            btnOrderPizza.BackColor = Color.OrangeRed;

        }

        private void labPizzaOrderTitle_Click(object sender, EventArgs e)
        {

        }

        private void labTotalOrderPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
