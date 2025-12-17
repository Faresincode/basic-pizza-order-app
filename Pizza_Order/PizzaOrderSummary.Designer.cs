namespace Pizza_Order
{
    partial class PizzaOrderSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PizzaOrderSummary));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labDolarIcon = new System.Windows.Forms.Label();
            this.labTotalPizzaOrderPrice = new System.Windows.Forms.Label();
            this.labTotalPrice = new System.Windows.Forms.Label();
            this.labWhereToEatSummary = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labCrustTypeValue = new System.Windows.Forms.Label();
            this.labCrustTypeSummary = new System.Windows.Forms.Label();
            this.gbToppingsSummary = new System.Windows.Forms.GroupBox();
            this.labToppingsValues = new System.Windows.Forms.Label();
            this.labPizzaSizeValue = new System.Windows.Forms.Label();
            this.labPizzaSize = new System.Windows.Forms.Label();
            this.labPizzaOrderTicket = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbToppingsSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.labDolarIcon);
            this.groupBox1.Controls.Add(this.labTotalPizzaOrderPrice);
            this.groupBox1.Controls.Add(this.labTotalPrice);
            this.groupBox1.Controls.Add(this.labWhereToEatSummary);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labCrustTypeValue);
            this.groupBox1.Controls.Add(this.labCrustTypeSummary);
            this.groupBox1.Controls.Add(this.gbToppingsSummary);
            this.groupBox1.Controls.Add(this.labPizzaSizeValue);
            this.groupBox1.Controls.Add(this.labPizzaSize);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(21, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 327);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Summary";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labDolarIcon
            // 
            this.labDolarIcon.AutoSize = true;
            this.labDolarIcon.BackColor = System.Drawing.Color.Transparent;
            this.labDolarIcon.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDolarIcon.ForeColor = System.Drawing.Color.Lime;
            this.labDolarIcon.Location = new System.Drawing.Point(76, 251);
            this.labDolarIcon.Name = "labDolarIcon";
            this.labDolarIcon.Size = new System.Drawing.Size(51, 54);
            this.labDolarIcon.TabIndex = 29;
            this.labDolarIcon.Text = "$";
            // 
            // labTotalPizzaOrderPrice
            // 
            this.labTotalPizzaOrderPrice.AutoSize = true;
            this.labTotalPizzaOrderPrice.BackColor = System.Drawing.Color.Transparent;
            this.labTotalPizzaOrderPrice.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotalPizzaOrderPrice.ForeColor = System.Drawing.Color.Lime;
            this.labTotalPizzaOrderPrice.Location = new System.Drawing.Point(120, 251);
            this.labTotalPizzaOrderPrice.Name = "labTotalPizzaOrderPrice";
            this.labTotalPizzaOrderPrice.Size = new System.Drawing.Size(52, 54);
            this.labTotalPizzaOrderPrice.TabIndex = 28;
            this.labTotalPizzaOrderPrice.Text = "0";
            this.labTotalPizzaOrderPrice.Click += new System.EventHandler(this.labTotalPizzaOrderPrice_Click);
            // 
            // labTotalPrice
            // 
            this.labTotalPrice.AutoSize = true;
            this.labTotalPrice.BackColor = System.Drawing.Color.Red;
            this.labTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotalPrice.ForeColor = System.Drawing.Color.Blue;
            this.labTotalPrice.Location = new System.Drawing.Point(25, 225);
            this.labTotalPrice.Name = "labTotalPrice";
            this.labTotalPrice.Size = new System.Drawing.Size(69, 13);
            this.labTotalPrice.TabIndex = 27;
            this.labTotalPrice.Text = "Total Price";
            // 
            // labWhereToEatSummary
            // 
            this.labWhereToEatSummary.AutoSize = true;
            this.labWhereToEatSummary.BackColor = System.Drawing.Color.Black;
            this.labWhereToEatSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWhereToEatSummary.ForeColor = System.Drawing.Color.Lime;
            this.labWhereToEatSummary.Location = new System.Drawing.Point(171, 191);
            this.labWhereToEatSummary.Name = "labWhereToEatSummary";
            this.labWhereToEatSummary.Size = new System.Drawing.Size(57, 20);
            this.labWhereToEatSummary.TabIndex = 26;
            this.labWhereToEatSummary.Text = "label5";
            this.labWhereToEatSummary.Click += new System.EventHandler(this.labWhereToEatSummary_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(25, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Where To Eat";
            // 
            // labCrustTypeValue
            // 
            this.labCrustTypeValue.AutoSize = true;
            this.labCrustTypeValue.BackColor = System.Drawing.Color.Black;
            this.labCrustTypeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCrustTypeValue.ForeColor = System.Drawing.Color.Lime;
            this.labCrustTypeValue.Location = new System.Drawing.Point(171, 161);
            this.labCrustTypeValue.Name = "labCrustTypeValue";
            this.labCrustTypeValue.Size = new System.Drawing.Size(57, 20);
            this.labCrustTypeValue.TabIndex = 24;
            this.labCrustTypeValue.Text = "label4";
            this.labCrustTypeValue.Click += new System.EventHandler(this.labCrustTypeValue_Click);
            // 
            // labCrustTypeSummary
            // 
            this.labCrustTypeSummary.AutoSize = true;
            this.labCrustTypeSummary.BackColor = System.Drawing.Color.Red;
            this.labCrustTypeSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCrustTypeSummary.ForeColor = System.Drawing.Color.Blue;
            this.labCrustTypeSummary.Location = new System.Drawing.Point(25, 161);
            this.labCrustTypeSummary.Name = "labCrustTypeSummary";
            this.labCrustTypeSummary.Size = new System.Drawing.Size(68, 13);
            this.labCrustTypeSummary.TabIndex = 23;
            this.labCrustTypeSummary.Text = "Crust Type";
            // 
            // gbToppingsSummary
            // 
            this.gbToppingsSummary.Controls.Add(this.labToppingsValues);
            this.gbToppingsSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppingsSummary.ForeColor = System.Drawing.Color.Blue;
            this.gbToppingsSummary.Location = new System.Drawing.Point(19, 54);
            this.gbToppingsSummary.Name = "gbToppingsSummary";
            this.gbToppingsSummary.Size = new System.Drawing.Size(297, 90);
            this.gbToppingsSummary.TabIndex = 21;
            this.gbToppingsSummary.TabStop = false;
            this.gbToppingsSummary.Text = "Toppings";
            // 
            // labToppingsValues
            // 
            this.labToppingsValues.AutoSize = true;
            this.labToppingsValues.BackColor = System.Drawing.Color.Black;
            this.labToppingsValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labToppingsValues.ForeColor = System.Drawing.Color.Lime;
            this.labToppingsValues.Location = new System.Drawing.Point(14, 22);
            this.labToppingsValues.MaximumSize = new System.Drawing.Size(200, 0);
            this.labToppingsValues.Name = "labToppingsValues";
            this.labToppingsValues.Size = new System.Drawing.Size(14, 20);
            this.labToppingsValues.TabIndex = 22;
            this.labToppingsValues.Text = " ";
            this.labToppingsValues.Click += new System.EventHandler(this.labToppingsValues_Click);
            // 
            // labPizzaSizeValue
            // 
            this.labPizzaSizeValue.AutoSize = true;
            this.labPizzaSizeValue.BackColor = System.Drawing.Color.Black;
            this.labPizzaSizeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPizzaSizeValue.ForeColor = System.Drawing.Color.Lime;
            this.labPizzaSizeValue.Location = new System.Drawing.Point(81, 32);
            this.labPizzaSizeValue.Name = "labPizzaSizeValue";
            this.labPizzaSizeValue.Size = new System.Drawing.Size(57, 20);
            this.labPizzaSizeValue.TabIndex = 20;
            this.labPizzaSizeValue.Text = "label2";
            this.labPizzaSizeValue.Click += new System.EventHandler(this.labPizzaSizeValue_Click);
            // 
            // labPizzaSize
            // 
            this.labPizzaSize.AutoSize = true;
            this.labPizzaSize.BackColor = System.Drawing.Color.Red;
            this.labPizzaSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPizzaSize.ForeColor = System.Drawing.Color.Blue;
            this.labPizzaSize.Location = new System.Drawing.Point(25, 32);
            this.labPizzaSize.Name = "labPizzaSize";
            this.labPizzaSize.Size = new System.Drawing.Size(37, 16);
            this.labPizzaSize.TabIndex = 19;
            this.labPizzaSize.Text = "Size";
            this.labPizzaSize.Click += new System.EventHandler(this.labPizzaSize_Click);
            // 
            // labPizzaOrderTicket
            // 
            this.labPizzaOrderTicket.AutoSize = true;
            this.labPizzaOrderTicket.BackColor = System.Drawing.Color.Transparent;
            this.labPizzaOrderTicket.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPizzaOrderTicket.ForeColor = System.Drawing.Color.Lime;
            this.labPizzaOrderTicket.Location = new System.Drawing.Point(44, 47);
            this.labPizzaOrderTicket.Name = "labPizzaOrderTicket";
            this.labPizzaOrderTicket.Size = new System.Drawing.Size(280, 30);
            this.labPizzaOrderTicket.TabIndex = 20;
            this.labPizzaOrderTicket.Text = "Pizza Order Ticket";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(150, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 25);
            this.button1.TabIndex = 21;
            this.button1.Text = "Print Ticket";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PizzaOrderSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(369, 503);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labPizzaOrderTicket);
            this.Controls.Add(this.groupBox1);
            this.Name = "PizzaOrderSummary";
            this.Text = "PizzaOrderSummary";
            this.Load += new System.EventHandler(this.PizzaOrderSummary_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbToppingsSummary.ResumeLayout(false);
            this.gbToppingsSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labDolarIcon;
        private System.Windows.Forms.Label labTotalPizzaOrderPrice;
        private System.Windows.Forms.Label labTotalPrice;
        private System.Windows.Forms.Label labWhereToEatSummary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labCrustTypeValue;
        private System.Windows.Forms.Label labCrustTypeSummary;
        private System.Windows.Forms.GroupBox gbToppingsSummary;
        private System.Windows.Forms.Label labToppingsValues;
        private System.Windows.Forms.Label labPizzaSizeValue;
        private System.Windows.Forms.Label labPizzaSize;
        private System.Windows.Forms.Label labPizzaOrderTicket;
        private System.Windows.Forms.Button button1;
    }
}