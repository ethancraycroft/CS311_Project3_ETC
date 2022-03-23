namespace CS311_Project3_ETC
{
    partial class PizzaPlanet
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPizzaPlanet = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.gbo = new System.Windows.Forms.GroupBox();
            this.rboRegular = new System.Windows.Forms.RadioButton();
            this.rboThick = new System.Windows.Forms.RadioButton();
            this.rboThin = new System.Windows.Forms.RadioButton();
            this.lblCrust = new System.Windows.Forms.Label();
            this.gboToppings = new System.Windows.Forms.GroupBox();
            this.ckbMushroom = new System.Windows.Forms.CheckBox();
            this.ckbExtraCheese = new System.Windows.Forms.CheckBox();
            this.ckbJalapeno = new System.Windows.Forms.CheckBox();
            this.ckbBP = new System.Windows.Forms.CheckBox();
            this.ckbGreenOlives = new System.Windows.Forms.CheckBox();
            this.ckbBlackOlives = new System.Windows.Forms.CheckBox();
            this.ckbGP = new System.Windows.Forms.CheckBox();
            this.ckbOnion = new System.Windows.Forms.CheckBox();
            this.ckbSpicyItalianSausage = new System.Windows.Forms.CheckBox();
            this.ckbCanadianBacon = new System.Windows.Forms.CheckBox();
            this.ckbSausage = new System.Windows.Forms.CheckBox();
            this.ckbPepperoni = new System.Windows.Forms.CheckBox();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblSummary = new System.Windows.Forms.Label();
            this.rtfSummary = new System.Windows.Forms.RichTextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbo.SuspendLayout();
            this.gboToppings.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CS311_Project3_ETC.Properties.Resources.pizza2;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 268);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblPizzaPlanet
            // 
            this.lblPizzaPlanet.AutoSize = true;
            this.lblPizzaPlanet.Font = new System.Drawing.Font("Showcard Gothic", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPizzaPlanet.Location = new System.Drawing.Point(295, 70);
            this.lblPizzaPlanet.Name = "lblPizzaPlanet";
            this.lblPizzaPlanet.Size = new System.Drawing.Size(731, 124);
            this.lblPizzaPlanet.TabIndex = 1;
            this.lblPizzaPlanet.Text = "PIZZA PLANET";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Bernard MT Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSize.Location = new System.Drawing.Point(70, 341);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(66, 33);
            this.lblSize.TabIndex = 2;
            this.lblSize.Text = "Size:";
            // 
            // cboSize
            // 
            this.cboSize.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large",
            "X-Large",
            "Ginormous"});
            this.cboSize.Location = new System.Drawing.Point(142, 341);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(182, 36);
            this.cboSize.TabIndex = 3;
            // 
            // gbo
            // 
            this.gbo.Controls.Add(this.rboRegular);
            this.gbo.Controls.Add(this.rboThick);
            this.gbo.Controls.Add(this.rboThin);
            this.gbo.Controls.Add(this.lblCrust);
            this.gbo.Location = new System.Drawing.Point(70, 380);
            this.gbo.Name = "gbo";
            this.gbo.Size = new System.Drawing.Size(254, 158);
            this.gbo.TabIndex = 4;
            this.gbo.TabStop = false;
            // 
            // rboRegular
            // 
            this.rboRegular.AutoSize = true;
            this.rboRegular.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rboRegular.Location = new System.Drawing.Point(87, 108);
            this.rboRegular.Name = "rboRegular";
            this.rboRegular.Size = new System.Drawing.Size(105, 25);
            this.rboRegular.TabIndex = 3;
            this.rboRegular.TabStop = true;
            this.rboRegular.Text = "Regular";
            this.rboRegular.UseVisualStyleBackColor = true;
            // 
            // rboThick
            // 
            this.rboThick.AutoSize = true;
            this.rboThick.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rboThick.Location = new System.Drawing.Point(87, 70);
            this.rboThick.Name = "rboThick";
            this.rboThick.Size = new System.Drawing.Size(83, 25);
            this.rboThick.TabIndex = 2;
            this.rboThick.TabStop = true;
            this.rboThick.Text = "Thick";
            this.rboThick.UseVisualStyleBackColor = true;
            // 
            // rboThin
            // 
            this.rboThin.AutoSize = true;
            this.rboThin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rboThin.Location = new System.Drawing.Point(87, 32);
            this.rboThin.Name = "rboThin";
            this.rboThin.Size = new System.Drawing.Size(73, 25);
            this.rboThin.TabIndex = 1;
            this.rboThin.TabStop = true;
            this.rboThin.Text = "Thin";
            this.rboThin.UseVisualStyleBackColor = true;
            // 
            // lblCrust
            // 
            this.lblCrust.AutoSize = true;
            this.lblCrust.Font = new System.Drawing.Font("Bernard MT Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCrust.Location = new System.Drawing.Point(0, 27);
            this.lblCrust.Name = "lblCrust";
            this.lblCrust.Size = new System.Drawing.Size(76, 33);
            this.lblCrust.TabIndex = 0;
            this.lblCrust.Text = "Crust:";
            // 
            // gboToppings
            // 
            this.gboToppings.Controls.Add(this.ckbMushroom);
            this.gboToppings.Controls.Add(this.ckbExtraCheese);
            this.gboToppings.Controls.Add(this.ckbJalapeno);
            this.gboToppings.Controls.Add(this.ckbBP);
            this.gboToppings.Controls.Add(this.ckbGreenOlives);
            this.gboToppings.Controls.Add(this.ckbBlackOlives);
            this.gboToppings.Controls.Add(this.ckbGP);
            this.gboToppings.Controls.Add(this.ckbOnion);
            this.gboToppings.Controls.Add(this.ckbSpicyItalianSausage);
            this.gboToppings.Controls.Add(this.ckbCanadianBacon);
            this.gboToppings.Controls.Add(this.ckbSausage);
            this.gboToppings.Controls.Add(this.ckbPepperoni);
            this.gboToppings.Controls.Add(this.lblToppings);
            this.gboToppings.Location = new System.Drawing.Point(348, 341);
            this.gboToppings.Name = "gboToppings";
            this.gboToppings.Size = new System.Drawing.Size(751, 218);
            this.gboToppings.TabIndex = 5;
            this.gboToppings.TabStop = false;
            // 
            // ckbMushroom
            // 
            this.ckbMushroom.AutoSize = true;
            this.ckbMushroom.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckbMushroom.Location = new System.Drawing.Point(540, 166);
            this.ckbMushroom.Name = "ckbMushroom";
            this.ckbMushroom.Size = new System.Drawing.Size(129, 25);
            this.ckbMushroom.TabIndex = 15;
            this.ckbMushroom.Text = "Mushroom";
            this.ckbMushroom.UseVisualStyleBackColor = true;
            // 
            // ckbExtraCheese
            // 
            this.ckbExtraCheese.AutoSize = true;
            this.ckbExtraCheese.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckbExtraCheese.Location = new System.Drawing.Point(540, 112);
            this.ckbExtraCheese.Name = "ckbExtraCheese";
            this.ckbExtraCheese.Size = new System.Drawing.Size(154, 25);
            this.ckbExtraCheese.TabIndex = 14;
            this.ckbExtraCheese.Text = "Extra Cheese";
            this.ckbExtraCheese.UseVisualStyleBackColor = true;
            // 
            // ckbJalapeno
            // 
            this.ckbJalapeno.AutoSize = true;
            this.ckbJalapeno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckbJalapeno.Location = new System.Drawing.Point(540, 57);
            this.ckbJalapeno.Name = "ckbJalapeno";
            this.ckbJalapeno.Size = new System.Drawing.Size(117, 25);
            this.ckbJalapeno.TabIndex = 13;
            this.ckbJalapeno.Text = "Jalapeno";
            this.ckbJalapeno.UseVisualStyleBackColor = true;
            // 
            // ckbBP
            // 
            this.ckbBP.AutoSize = true;
            this.ckbBP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckbBP.Location = new System.Drawing.Point(540, 7);
            this.ckbBP.Name = "ckbBP";
            this.ckbBP.Size = new System.Drawing.Size(183, 25);
            this.ckbBP.TabIndex = 12;
            this.ckbBP.Text = "Banana Peppers";
            this.ckbBP.UseVisualStyleBackColor = true;
            // 
            // ckbGreenOlives
            // 
            this.ckbGreenOlives.AutoSize = true;
            this.ckbGreenOlives.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckbGreenOlives.Location = new System.Drawing.Point(359, 166);
            this.ckbGreenOlives.Name = "ckbGreenOlives";
            this.ckbGreenOlives.Size = new System.Drawing.Size(151, 25);
            this.ckbGreenOlives.TabIndex = 11;
            this.ckbGreenOlives.Text = "Green Olives";
            this.ckbGreenOlives.UseVisualStyleBackColor = true;
            // 
            // ckbBlackOlives
            // 
            this.ckbBlackOlives.AutoSize = true;
            this.ckbBlackOlives.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckbBlackOlives.Location = new System.Drawing.Point(359, 112);
            this.ckbBlackOlives.Name = "ckbBlackOlives";
            this.ckbBlackOlives.Size = new System.Drawing.Size(146, 25);
            this.ckbBlackOlives.TabIndex = 10;
            this.ckbBlackOlives.Text = "Black Olives";
            this.ckbBlackOlives.UseVisualStyleBackColor = true;
            // 
            // ckbGP
            // 
            this.ckbGP.AutoSize = true;
            this.ckbGP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckbGP.Location = new System.Drawing.Point(359, 57);
            this.ckbGP.Name = "ckbGP";
            this.ckbGP.Size = new System.Drawing.Size(170, 25);
            this.ckbGP.TabIndex = 9;
            this.ckbGP.Text = "Green Peppers";
            this.ckbGP.UseVisualStyleBackColor = true;
            // 
            // ckbOnion
            // 
            this.ckbOnion.AutoSize = true;
            this.ckbOnion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckbOnion.Location = new System.Drawing.Point(359, 7);
            this.ckbOnion.Name = "ckbOnion";
            this.ckbOnion.Size = new System.Drawing.Size(88, 25);
            this.ckbOnion.TabIndex = 8;
            this.ckbOnion.Text = "Onion";
            this.ckbOnion.UseVisualStyleBackColor = true;
            // 
            // ckbSpicyItalianSausage
            // 
            this.ckbSpicyItalianSausage.AutoSize = true;
            this.ckbSpicyItalianSausage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckbSpicyItalianSausage.Location = new System.Drawing.Point(128, 166);
            this.ckbSpicyItalianSausage.Name = "ckbSpicyItalianSausage";
            this.ckbSpicyItalianSausage.Size = new System.Drawing.Size(227, 25);
            this.ckbSpicyItalianSausage.TabIndex = 7;
            this.ckbSpicyItalianSausage.Text = "Spicy Italian Sausage";
            this.ckbSpicyItalianSausage.UseVisualStyleBackColor = true;
            // 
            // ckbCanadianBacon
            // 
            this.ckbCanadianBacon.AutoSize = true;
            this.ckbCanadianBacon.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckbCanadianBacon.Location = new System.Drawing.Point(128, 112);
            this.ckbCanadianBacon.Name = "ckbCanadianBacon";
            this.ckbCanadianBacon.Size = new System.Drawing.Size(182, 25);
            this.ckbCanadianBacon.TabIndex = 6;
            this.ckbCanadianBacon.Text = "Canadian Bacon";
            this.ckbCanadianBacon.UseVisualStyleBackColor = true;
            // 
            // ckbSausage
            // 
            this.ckbSausage.AutoSize = true;
            this.ckbSausage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckbSausage.Location = new System.Drawing.Point(128, 57);
            this.ckbSausage.Name = "ckbSausage";
            this.ckbSausage.Size = new System.Drawing.Size(113, 25);
            this.ckbSausage.TabIndex = 5;
            this.ckbSausage.Text = "Sausage";
            this.ckbSausage.UseVisualStyleBackColor = true;
            // 
            // ckbPepperoni
            // 
            this.ckbPepperoni.AutoSize = true;
            this.ckbPepperoni.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckbPepperoni.Location = new System.Drawing.Point(128, 7);
            this.ckbPepperoni.Name = "ckbPepperoni";
            this.ckbPepperoni.Size = new System.Drawing.Size(127, 25);
            this.ckbPepperoni.TabIndex = 2;
            this.ckbPepperoni.Text = "Pepperoni";
            this.ckbPepperoni.UseVisualStyleBackColor = true;
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Bernard MT Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblToppings.Location = new System.Drawing.Point(0, 3);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(122, 33);
            this.lblToppings.TabIndex = 1;
            this.lblToppings.Text = "Toppings:";
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Bernard MT Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSummary.Location = new System.Drawing.Point(37, 576);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(193, 33);
            this.lblSummary.TabIndex = 6;
            this.lblSummary.Text = "Order Summary:";
            // 
            // rtfSummary
            // 
            this.rtfSummary.Location = new System.Drawing.Point(240, 571);
            this.rtfSummary.Name = "rtfSummary";
            this.rtfSummary.Size = new System.Drawing.Size(473, 196);
            this.rtfSummary.TabIndex = 7;
            this.rtfSummary.Text = "";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Bernard MT Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubTotal.Location = new System.Drawing.Point(731, 576);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(118, 33);
            this.lblSubTotal.TabIndex = 8;
            this.lblSubTotal.Text = "SubTotal:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Bernard MT Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTax.Location = new System.Drawing.Point(787, 620);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(62, 33);
            this.lblTax.TabIndex = 9;
            this.lblTax.Text = "Tax:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Bernard MT Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(770, 665);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(79, 33);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total:";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSubTotal.Location = new System.Drawing.Point(855, 576);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(202, 35);
            this.txtSubTotal.TabIndex = 11;
            // 
            // txtTax
            // 
            this.txtTax.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTax.Location = new System.Drawing.Point(855, 620);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(202, 35);
            this.txtTax.TabIndex = 12;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotal.Location = new System.Drawing.Point(855, 665);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(202, 35);
            this.txtTotal.TabIndex = 13;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Bernard MT Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalculate.Location = new System.Drawing.Point(752, 716);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(319, 51);
            this.btnCalculate.TabIndex = 14;
            this.btnCalculate.Text = "CALCULATE";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // PizzaPlanet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 801);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.rtfSummary);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.gboToppings);
            this.Controls.Add(this.gbo);
            this.Controls.Add(this.cboSize);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblPizzaPlanet);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PizzaPlanet";
            this.Text = "Pizza Planet";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbo.ResumeLayout(false);
            this.gbo.PerformLayout();
            this.gboToppings.ResumeLayout(false);
            this.gboToppings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblPizzaPlanet;
        private Label lblSize;
        private ComboBox cboSize;
        private GroupBox gbo;
        private RadioButton rboRegular;
        private RadioButton rboThick;
        private RadioButton rboThin;
        private Label lblCrust;
        private GroupBox gboToppings;
        private CheckBox ckbMushroom;
        private CheckBox ckbExtraCheese;
        private CheckBox ckbJalapeno;
        private CheckBox ckbBP;
        private CheckBox ckbGreenOlives;
        private CheckBox ckbBlackOlives;
        private CheckBox ckbGP;
        private CheckBox ckbOnion;
        private CheckBox ckbSpicyItalianSausage;
        private CheckBox ckbCanadianBacon;
        private CheckBox ckbSausage;
        private CheckBox ckbPepperoni;
        private Label lblToppings;
        private Label lblSummary;
        private RichTextBox rtfSummary;
        private Label lblSubTotal;
        private Label lblTax;
        private Label lblTotal;
        private TextBox txtSubTotal;
        private TextBox txtTax;
        private TextBox txtTotal;
        private Button btnCalculate;
    }
}