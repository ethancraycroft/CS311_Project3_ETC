namespace CS311_Project3_ETC
{
    public partial class PizzaPlanet : Form
    {
        double subtotal;
        double toppings;
        double pizzaSize;
        double tax;
        double total;
        String crust;

        public PizzaPlanet()
        {
            InitializeComponent();
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Summarize();
            txtSubTotal.Text = "$" + subtotal.ToString();
            tax = subtotal * 0.06;
            txtTax.Text = "$" + tax.ToString();
            total = tax + subtotal;
            txtTotal.Text = "$" + total.ToString();
        }

        private void Summarize()
        {
            rtfSummary.Clear();
            subtotal = 0;
            tax = 0;
            total = 0;

            //CHECKS FOR SELECTED CRUST TYPE AND SETS STRING TO BE PRINTED IN ORDER SUMMARY
            Crust();

            //SUMMARY OF THE TYPE OF PIZZA MINUS THE TOPPINGS
            rtfSummary.SelectedText = "You ordered a " + cboSize.Text + " pizza with " + crust + " crust and the following toppings:\n";

            //CALCULATE COST BASED ON SELECTED SIZE OF PIZZA
            size();

            //CHECKS FOR TOPPINGS AND CALCULATES THE COST OF THE TOPPINGS ACCORDINGLY - ADDS TOPPINGS TO SUMMARY (BULLETED)
            rtfSummary.SelectionBullet = true;
            Toppings();
            rtfSummary.SelectionBullet = false;


            //CALCULATES SUBTOTAL OF PIZZA BY SUMMING THE COST OF THE SIZE AND TOPPINGS
            subtotal = pizzaSize + toppings;
            txtSubTotal.Text = subtotal.ToString();


            //CALCULATES PRICE OF TAX BY MULTIPLYING SUBTOTAL BY 6%
            tax = subtotal * 0.06;
            txtTax.Text = tax.ToString();


            //CALCULATES TOTAL ORDER PRICE BY ADDING TAX TO THE SUBTOTAL
            total = tax + subtotal;
            txtTotal.Text = total.ToString();
        }//end Summarize()

        private void Crust()
        {
            crust = "";
            if (rboRegular.Checked)
            {
                crust = "Regular";
            }
            else if (rboThick.Checked)
            {
                crust = "Thick";
            }
            else if (rboThin.Checked)
            {
                crust = "Thin";
            }
        }//end Crust() 

        private void size()
        {
            pizzaSize = 0;
            if (cboSize.Text == "Small")
            {
                pizzaSize += 2.00;
            }
            else if (cboSize.Text == "Medium")
            {
                pizzaSize += 5.00;
            }
            else if (cboSize.Text == "Large")
            {
                pizzaSize += 10.00;
            }
            else if (cboSize.Text == "X-Large")
            {
                pizzaSize += 15.00;
            }
            else if (cboSize.Text == "Ginormous")
            {
                pizzaSize += 20.00;
            }
        }//end size()

        private void Toppings()
        {
            toppings = 0;
            if (ckbBlackOlives.Checked)
            {
                toppings += 1;
                rtfSummary.SelectedText = "Black Olives\n";
            }
            if (ckbBP.Checked)
            {
                toppings += 1;
                rtfSummary.SelectedText = "Banana Peppers\n";
            }
            if (ckbCanadianBacon.Checked)
            {
                toppings += 2;
                rtfSummary.SelectedText = "Canadian Bacon\n";
            }
            if (ckbExtraCheese.Checked)
            {
                toppings += 1;
                rtfSummary.SelectedText = "Extra Cheese\n";
            }
            if (ckbGP.Checked)
            {
                toppings += 1;
                rtfSummary.SelectedText = "Green Peppers\n";
            }
            if (ckbGreenOlives.Checked)
            {
                toppings += 1;
                rtfSummary.SelectedText = "Green Olives\n";
            }
            if (ckbJalapeno.Checked)
            {
                toppings += 1;
                rtfSummary.SelectedText = "Jalapenos\n";
            }
            if (ckbMushroom.Checked)
            {
                toppings += 1;
                rtfSummary.SelectedText = "Mushrooms\n";
            }
            if (ckbOnion.Checked)
            {
                toppings += 1;
                rtfSummary.SelectedText = "Onions\n";
            }
            if (ckbPepperoni.Checked)
            {
                toppings += 2;
                rtfSummary.SelectedText = "Pepperoni\n";
            }
            if (ckbSausage.Checked)
            {
                toppings += 2;
                rtfSummary.SelectedText = "Sausage\n";
            }
            if (ckbSpicyItalianSausage.Checked)
            {
                toppings += 2;
                rtfSummary.SelectedText = "Spicy Italian Sausage\n";
            }
        }//end Toppings()
    }//end class
}//end namespace