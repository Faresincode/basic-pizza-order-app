namespace Pizza_Order
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labPizzaOrderTitle = new System.Windows.Forms.Label();
            this.gbPizzaSize = new System.Windows.Forms.GroupBox();
            this.rbSmallPizzaSize = new System.Windows.Forms.RadioButton();
            this.rbMediumPizzaSize = new System.Windows.Forms.RadioButton();
            this.rbLargPizzaSize = new System.Windows.Forms.RadioButton();
            this.gbPizzaCrust = new System.Windows.Forms.GroupBox();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.rbThinkCrust = new System.Windows.Forms.RadioButton();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbEatOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.gbPizzaTopping = new System.Windows.Forms.GroupBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkExtraChees = new System.Windows.Forms.CheckBox();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.labDolarIcon = new System.Windows.Forms.Label();
            this.labTotalOrderPrice = new System.Windows.Forms.Label();
            this.gbPizzaSize.SuspendLayout();
            this.gbPizzaCrust.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.gbPizzaTopping.SuspendLayout();
            this.SuspendLayout();
            // 
            // labPizzaOrderTitle
            // 
            this.labPizzaOrderTitle.AutoSize = true;
            this.labPizzaOrderTitle.BackColor = System.Drawing.Color.Transparent;
            this.labPizzaOrderTitle.Font = new System.Drawing.Font("Jokerman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPizzaOrderTitle.ForeColor = System.Drawing.Color.Red;
            this.labPizzaOrderTitle.Location = new System.Drawing.Point(20, 9);
            this.labPizzaOrderTitle.Name = "labPizzaOrderTitle";
            this.labPizzaOrderTitle.Size = new System.Drawing.Size(326, 51);
            this.labPizzaOrderTitle.TabIndex = 0;
            this.labPizzaOrderTitle.Text = "Make your Pizza";
            this.labPizzaOrderTitle.Click += new System.EventHandler(this.labPizzaOrderTitle_Click);
            // 
            // gbPizzaSize
            // 
            this.gbPizzaSize.BackColor = System.Drawing.Color.Transparent;
            this.gbPizzaSize.Controls.Add(this.rbSmallPizzaSize);
            this.gbPizzaSize.Controls.Add(this.rbMediumPizzaSize);
            this.gbPizzaSize.Controls.Add(this.rbLargPizzaSize);
            this.gbPizzaSize.ForeColor = System.Drawing.Color.Red;
            this.gbPizzaSize.Location = new System.Drawing.Point(55, 77);
            this.gbPizzaSize.Name = "gbPizzaSize";
            this.gbPizzaSize.Size = new System.Drawing.Size(257, 44);
            this.gbPizzaSize.TabIndex = 1;
            this.gbPizzaSize.TabStop = false;
            this.gbPizzaSize.Text = "Size";
            // 
            // rbSmallPizzaSize
            // 
            this.rbSmallPizzaSize.AutoSize = true;
            this.rbSmallPizzaSize.BackColor = System.Drawing.Color.Black;
            this.rbSmallPizzaSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSmallPizzaSize.ForeColor = System.Drawing.Color.Lime;
            this.rbSmallPizzaSize.Location = new System.Drawing.Point(24, 19);
            this.rbSmallPizzaSize.Name = "rbSmallPizzaSize";
            this.rbSmallPizzaSize.Size = new System.Drawing.Size(59, 20);
            this.rbSmallPizzaSize.TabIndex = 2;
            this.rbSmallPizzaSize.TabStop = true;
            this.rbSmallPizzaSize.Text = "Small";
            this.rbSmallPizzaSize.UseVisualStyleBackColor = false;
            this.rbSmallPizzaSize.CheckedChanged += new System.EventHandler(this.rbSmallPizzaSize_CheckedChanged);
            // 
            // rbMediumPizzaSize
            // 
            this.rbMediumPizzaSize.AutoSize = true;
            this.rbMediumPizzaSize.BackColor = System.Drawing.Color.Black;
            this.rbMediumPizzaSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMediumPizzaSize.ForeColor = System.Drawing.Color.Lime;
            this.rbMediumPizzaSize.Location = new System.Drawing.Point(92, 18);
            this.rbMediumPizzaSize.Name = "rbMediumPizzaSize";
            this.rbMediumPizzaSize.Size = new System.Drawing.Size(73, 20);
            this.rbMediumPizzaSize.TabIndex = 3;
            this.rbMediumPizzaSize.TabStop = true;
            this.rbMediumPizzaSize.Text = "Medium";
            this.rbMediumPizzaSize.UseVisualStyleBackColor = false;
            this.rbMediumPizzaSize.CheckedChanged += new System.EventHandler(this.rbMediumPizzaSize_CheckedChanged);
            // 
            // rbLargPizzaSize
            // 
            this.rbLargPizzaSize.AutoSize = true;
            this.rbLargPizzaSize.BackColor = System.Drawing.Color.Black;
            this.rbLargPizzaSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLargPizzaSize.ForeColor = System.Drawing.Color.Lime;
            this.rbLargPizzaSize.Location = new System.Drawing.Point(182, 18);
            this.rbLargPizzaSize.Name = "rbLargPizzaSize";
            this.rbLargPizzaSize.Size = new System.Drawing.Size(60, 20);
            this.rbLargPizzaSize.TabIndex = 4;
            this.rbLargPizzaSize.TabStop = true;
            this.rbLargPizzaSize.Text = "Large";
            this.rbLargPizzaSize.UseVisualStyleBackColor = false;
            this.rbLargPizzaSize.CheckedChanged += new System.EventHandler(this.rbLargPizzaSize_CheckedChanged);
            // 
            // gbPizzaCrust
            // 
            this.gbPizzaCrust.BackColor = System.Drawing.Color.Transparent;
            this.gbPizzaCrust.Controls.Add(this.rbThinCrust);
            this.gbPizzaCrust.Controls.Add(this.rbThinkCrust);
            this.gbPizzaCrust.ForeColor = System.Drawing.Color.Red;
            this.gbPizzaCrust.Location = new System.Drawing.Point(55, 127);
            this.gbPizzaCrust.Name = "gbPizzaCrust";
            this.gbPizzaCrust.Size = new System.Drawing.Size(257, 45);
            this.gbPizzaCrust.TabIndex = 5;
            this.gbPizzaCrust.TabStop = false;
            this.gbPizzaCrust.Text = "Crust Type";
            this.gbPizzaCrust.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.BackColor = System.Drawing.Color.Black;
            this.rbThinCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThinCrust.ForeColor = System.Drawing.Color.Lime;
            this.rbThinCrust.Location = new System.Drawing.Point(24, 19);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(84, 20);
            this.rbThinCrust.TabIndex = 6;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Text = "Thin Crust";
            this.rbThinCrust.UseVisualStyleBackColor = false;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.rbPizzaThinCrust_CheckedChanged);
            // 
            // rbThinkCrust
            // 
            this.rbThinkCrust.AutoSize = true;
            this.rbThinkCrust.BackColor = System.Drawing.Color.Black;
            this.rbThinkCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThinkCrust.ForeColor = System.Drawing.Color.Lime;
            this.rbThinkCrust.Location = new System.Drawing.Point(135, 19);
            this.rbThinkCrust.Name = "rbThinkCrust";
            this.rbThinkCrust.Size = new System.Drawing.Size(91, 20);
            this.rbThinkCrust.TabIndex = 7;
            this.rbThinkCrust.TabStop = true;
            this.rbThinkCrust.Text = "Think Crust";
            this.rbThinkCrust.UseVisualStyleBackColor = false;
            this.rbThinkCrust.CheckedChanged += new System.EventHandler(this.rbThinkCrust_CheckedChanged);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.BackColor = System.Drawing.Color.Transparent;
            this.gbWhereToEat.Controls.Add(this.rbEatOut);
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.ForeColor = System.Drawing.Color.Red;
            this.gbWhereToEat.Location = new System.Drawing.Point(55, 301);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(254, 45);
            this.gbWhereToEat.TabIndex = 15;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat";
            // 
            // rbEatOut
            // 
            this.rbEatOut.AutoSize = true;
            this.rbEatOut.BackColor = System.Drawing.Color.Black;
            this.rbEatOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEatOut.ForeColor = System.Drawing.Color.Lime;
            this.rbEatOut.Location = new System.Drawing.Point(135, 19);
            this.rbEatOut.Name = "rbEatOut";
            this.rbEatOut.Size = new System.Drawing.Size(68, 20);
            this.rbEatOut.TabIndex = 17;
            this.rbEatOut.TabStop = true;
            this.rbEatOut.Text = "Eat Out";
            this.rbEatOut.UseVisualStyleBackColor = false;
            this.rbEatOut.CheckedChanged += new System.EventHandler(this.rdPizzaEatOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.BackColor = System.Drawing.Color.Black;
            this.rbEatIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEatIn.ForeColor = System.Drawing.Color.Lime;
            this.rbEatIn.Location = new System.Drawing.Point(44, 19);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(58, 20);
            this.rbEatIn.TabIndex = 16;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = false;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbPizzaEatIn_CheckedChanged);
            // 
            // gbPizzaTopping
            // 
            this.gbPizzaTopping.BackColor = System.Drawing.Color.Transparent;
            this.gbPizzaTopping.Controls.Add(this.chkGreenPeppers);
            this.gbPizzaTopping.Controls.Add(this.chkOlives);
            this.gbPizzaTopping.Controls.Add(this.chkOnion);
            this.gbPizzaTopping.Controls.Add(this.chkTomatoes);
            this.gbPizzaTopping.Controls.Add(this.chkMushrooms);
            this.gbPizzaTopping.Controls.Add(this.chkExtraChees);
            this.gbPizzaTopping.ForeColor = System.Drawing.Color.Red;
            this.gbPizzaTopping.Location = new System.Drawing.Point(29, 181);
            this.gbPizzaTopping.Name = "gbPizzaTopping";
            this.gbPizzaTopping.Size = new System.Drawing.Size(314, 114);
            this.gbPizzaTopping.TabIndex = 8;
            this.gbPizzaTopping.TabStop = false;
            this.gbPizzaTopping.Text = "Toppings";
            this.gbPizzaTopping.Enter += new System.EventHandler(this.gbPizzaTopping_Enter);
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.BackColor = System.Drawing.Color.Black;
            this.chkGreenPeppers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGreenPeppers.ForeColor = System.Drawing.Color.Lime;
            this.chkGreenPeppers.Location = new System.Drawing.Point(174, 63);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(118, 20);
            this.chkGreenPeppers.TabIndex = 14;
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = false;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.chkGreenPeppers_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.BackColor = System.Drawing.Color.Black;
            this.chkOlives.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOlives.ForeColor = System.Drawing.Color.Lime;
            this.chkOlives.Location = new System.Drawing.Point(92, 63);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(64, 20);
            this.chkOlives.TabIndex = 13;
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = false;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.BackColor = System.Drawing.Color.Black;
            this.chkOnion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnion.ForeColor = System.Drawing.Color.Lime;
            this.chkOnion.Location = new System.Drawing.Point(10, 63);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(61, 20);
            this.chkOnion.TabIndex = 12;
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = false;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.BackColor = System.Drawing.Color.Black;
            this.chkTomatoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTomatoes.ForeColor = System.Drawing.Color.Lime;
            this.chkTomatoes.Location = new System.Drawing.Point(220, 19);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(88, 20);
            this.chkTomatoes.TabIndex = 11;
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = false;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.BackColor = System.Drawing.Color.Black;
            this.chkMushrooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMushrooms.ForeColor = System.Drawing.Color.Lime;
            this.chkMushrooms.Location = new System.Drawing.Point(118, 20);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(96, 20);
            this.chkMushrooms.TabIndex = 10;
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = false;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkExtraChees
            // 
            this.chkExtraChees.AutoSize = true;
            this.chkExtraChees.BackColor = System.Drawing.Color.Black;
            this.chkExtraChees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExtraChees.ForeColor = System.Drawing.Color.LawnGreen;
            this.chkExtraChees.Location = new System.Drawing.Point(10, 19);
            this.chkExtraChees.Name = "chkExtraChees";
            this.chkExtraChees.Size = new System.Drawing.Size(98, 20);
            this.chkExtraChees.TabIndex = 9;
            this.chkExtraChees.Text = "Extra Chees";
            this.chkExtraChees.UseVisualStyleBackColor = false;
            this.chkExtraChees.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.BackColor = System.Drawing.Color.Chartreuse;
            this.btnOrderPizza.Location = new System.Drawing.Point(121, 450);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(122, 37);
            this.btnOrderPizza.TabIndex = 29;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = false;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            this.btnOrderPizza.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OrderPizzaMouseDown);
            this.btnOrderPizza.MouseEnter += new System.EventHandler(this.OrderPizzaMouseEnter);
            this.btnOrderPizza.MouseLeave += new System.EventHandler(this.OrderPizzaMouseLeave);
            // 
            // btnResetForm
            // 
            this.btnResetForm.BackColor = System.Drawing.Color.DarkOrange;
            this.btnResetForm.Location = new System.Drawing.Point(142, 493);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(78, 37);
            this.btnResetForm.TabIndex = 30;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = false;
            this.btnResetForm.Click += new System.EventHandler(this.button2_Click);
            this.btnResetForm.MouseEnter += new System.EventHandler(this.OrderPizzaMousEnter);
            // 
            // labDolarIcon
            // 
            this.labDolarIcon.AutoSize = true;
            this.labDolarIcon.BackColor = System.Drawing.Color.Black;
            this.labDolarIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDolarIcon.ForeColor = System.Drawing.Color.Lime;
            this.labDolarIcon.Location = new System.Drawing.Point(105, 369);
            this.labDolarIcon.Name = "labDolarIcon";
            this.labDolarIcon.Size = new System.Drawing.Size(52, 55);
            this.labDolarIcon.TabIndex = 31;
            this.labDolarIcon.Text = "$";
            // 
            // labTotalOrderPrice
            // 
            this.labTotalOrderPrice.AutoSize = true;
            this.labTotalOrderPrice.BackColor = System.Drawing.Color.Black;
            this.labTotalOrderPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotalOrderPrice.ForeColor = System.Drawing.Color.Lime;
            this.labTotalOrderPrice.Location = new System.Drawing.Point(148, 369);
            this.labTotalOrderPrice.Name = "labTotalOrderPrice";
            this.labTotalOrderPrice.Size = new System.Drawing.Size(51, 55);
            this.labTotalOrderPrice.TabIndex = 32;
            this.labTotalOrderPrice.Text = "0";
            this.labTotalOrderPrice.Click += new System.EventHandler(this.labTotalOrderPrice_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(366, 601);
            this.Controls.Add(this.labTotalOrderPrice);
            this.Controls.Add(this.labDolarIcon);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.gbPizzaTopping);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbPizzaCrust);
            this.Controls.Add(this.gbPizzaSize);
            this.Controls.Add(this.labPizzaOrderTitle);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pizza Order";
            this.gbPizzaSize.ResumeLayout(false);
            this.gbPizzaSize.PerformLayout();
            this.gbPizzaCrust.ResumeLayout(false);
            this.gbPizzaCrust.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.gbPizzaTopping.ResumeLayout(false);
            this.gbPizzaTopping.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labPizzaOrderTitle;
        private System.Windows.Forms.GroupBox gbPizzaSize;
        private System.Windows.Forms.RadioButton rbSmallPizzaSize;
        private System.Windows.Forms.RadioButton rbMediumPizzaSize;
        private System.Windows.Forms.RadioButton rbLargPizzaSize;
        private System.Windows.Forms.GroupBox gbPizzaCrust;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.RadioButton rbThinkCrust;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rbEatOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.GroupBox gbPizzaTopping;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkExtraChees;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Label labDolarIcon;
        private System.Windows.Forms.Label labTotalOrderPrice;
    }
}

