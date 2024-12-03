using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Burger_shop
{
    public partial class FormPayment : Form
    {
        private Order order;
        private Customer customer;
        private int hamburgerPrice = 20;
        private int extrasCount = 0;
        private int drinksCount = 0;
        private int totalPrice = 0;
        private string hamburger = "";
        private string extras = "";
        private string drinks = "";
        private string sauces = "";

        public FormPayment(Order order)
        {
            InitializeComponent();
            this.order = order;
            GrpPayment.Enabled = false;
            customer = new Customer();
            LstDisplayOrder.Items.Clear();
            LstDisplayOrder.HorizontalScrollbar = true;

            LstDisplayOrder.Items.Add("Your Order is: \n");

            string[] options = order.GetOptions();
            if (options[0] != null)
            {
                if (options[0].Contains("Tomato"))
                    hamburger += "Tomato, ";
                if (options[0].Contains("Pickles"))
                    hamburger += "Pickles, ";
                if (options[0].Contains("Lettuce"))
                    hamburger += "Lettuce, ";
                if (options[0].Contains("Onion"))
                    hamburger += "Onion, ";
                if (options[0].Contains("Cheese"))
                    hamburger += "Cheese, ";
                if (options[0].Contains("House Sauce"))
                    hamburger += "House Sauce, ";
                if (!string.IsNullOrEmpty(hamburger))
                {
                    LstDisplayPrice.Items.Add("Hamburger " + hamburgerPrice + "$");
                    totalPrice += hamburgerPrice;
                    this.LstDisplayOrder.Items.Add("Hamburger with: ");
                    this.LstDisplayOrder.Items.Add(hamburger);
                }
            }

            if (options[1] != null)
            {
                if (options[1].Contains("Large French Fries"))
                {
                    extras += "Large French Fries, ";
                    extrasCount++;
                }

                if (options[1].Contains("Small French Fries"))
                {
                    extras += "Small French Fries, ";
                    extrasCount++;
                }
                if (options[1].Contains("Onion Rings"))
                {
                    extras += "Onion Rings, ";
                    extrasCount++;
                }
                if (options[1].Contains("Potatoes"))
                {
                    extras += "Potatoes, ";
                    extrasCount++;
                }
                if (!string.IsNullOrEmpty(extras))
                {
                    this.LstDisplayOrder.Items.Add("Your Extras:");
                    this.LstDisplayOrder.Items.Add(extras);
                    int extrasPrice = extrasCount * 5;
                    LstDisplayPrice.Items.Add("Extras: " + extrasPrice + "$");
                    totalPrice += extrasPrice;
                }
            }

            if (options[2] != null)
            {
                if (options[2].Contains("Water"))
                {
                    drinks += "Water, ";
                    drinksCount++;
                }

                if (options[2].Contains("Coke"))
                {
                    drinks += "Coke, ";
                    drinksCount++;
                }
                if (options[2].Contains("Lemonade"))
                {
                    drinks += "Lemonade, ";
                    drinksCount++;
                }
                if (options[2].Contains("Sprite"))
                {
                    drinks += "Sprite, ";
                    drinksCount++;
                }
                if (!string.IsNullOrEmpty(drinks))
                {
                    this.LstDisplayOrder.Items.Add("Drinks: ");
                    LstDisplayOrder.Items.Add(drinks);
                    int drinksPrice = drinksCount * 5;
                    LstDisplayPrice.Items.Add("Drinks: " + drinksPrice + "$");
                    totalPrice += drinksPrice;
                }
            }


            if (options[3] != null)
            {
                if (options[3].Contains("Ketchup"))
                    sauces += "Ketchup, ";
                if (options[3].Contains("Mayo"))
                    sauces += "Mayo, ";
                if (options[3].Contains("Barbecue"))
                    sauces += "Barbecue, ";
                if (options[3].Contains("Garlic Sauce"))
                    sauces += "Garlic Sauce, ";
                if (!string.IsNullOrEmpty(sauces))
                {
                    this.LstDisplayOrder.Items.Add("Sauces: ");
                    LstDisplayOrder.Items.Add(sauces);
                }
            }


            

            LstDisplayPrice.Items.Add("Total: " + totalPrice + "$");
        }
    

        private void BtnGoPay_Click(object sender, EventArgs e)
        {
            GrpPayment.Enabled = true;
        }

        private void BtnBackToChange_Click(object sender, EventArgs e)
        {
            LstDisplayOrder.Items.Clear();
            this.Close();
        }

        private void BtnFinalOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtFName.Text == "" || TxtID.Text == "" || TxtAddress.Text == "" || TxtCardNumber.Text == "" || TxtLName.Text == "")
                {
                    MessageBox.Show("Please enter all the deatils");
                    return;
                }
                if (CmbCardType.SelectedItem == null)
                {
                    MessageBox.Show("Please choose card type.");
                    return;
                }
                customer.Firstname = TxtFName.Text;
                customer.Lastname = TxtLName.Text;
                customer.ID = TxtID.Text;
                customer.Address = TxtAddress.Text;
                customer.CardNumber = TxtCardNumber.Text;

                //ComboBox CardType    
                if (CmbCardType.SelectedItem.ToString() == "Visa")
                    customer.CardType = "Visa";
                else if (CmbCardType.SelectedItem.ToString() == "Master Card")
                    customer.CardType = "Master Card";
                else if (CmbCardType.SelectedItem.ToString() == "American Express")
                    customer.CardType = "American Express";

                TxtFName.Text = "";
                TxtLName.Text = "";
                TxtID.Text = "";
                TxtAddress.Text = "";
                TxtCardNumber.Text = "";

                //Timer
                timer1.Enabled = true;

                MessageBox.Show(customer.ToString());

                
                
   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
    
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Your Order has been sent to you, Enjoy Your Meal! ");
            
        }
    }
}
