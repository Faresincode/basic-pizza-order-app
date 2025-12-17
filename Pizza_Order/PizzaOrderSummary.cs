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
    public partial class PizzaOrderSummary : Form
    {

        private string _OrderDetails;
        public PizzaOrderSummary(string OrderDetails)
        {
            InitializeComponent();
            _OrderDetails = OrderDetails;
            DisplayTickets();
        }
        public void DisplayTickets()
        {
            char[] Separator=new char[1];
            Separator[0] = '#';

            string[] koko = new string [5]; 

            koko= _OrderDetails.Split(Separator);
            labPizzaSizeValue.Text = koko[0];
            labCrustTypeValue.Text = koko[1];
            labToppingsValues.Text = koko[2];
            labWhereToEatSummary.Text = koko[3];
            labTotalPizzaOrderPrice.Text = koko[4];



        }
        private void PizzaOrderSummary_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ticket Printed Succesfully","Print Order Ticket",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void labPizzaSize_Click(object sender, EventArgs e)
        {

        }

        private void labPizzaSizeValue_Click(object sender, EventArgs e)
        {

        }

        private void labToppingsValues_Click(object sender, EventArgs e)
        {

        }

        private void labCrustTypeValue_Click(object sender, EventArgs e)
        {

        }

        private void labWhereToEatSummary_Click(object sender, EventArgs e)
        {

        }

        private void labTotalPizzaOrderPrice_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
