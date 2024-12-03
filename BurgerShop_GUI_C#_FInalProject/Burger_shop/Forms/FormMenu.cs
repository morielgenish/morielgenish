using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Burger_shop
{
    public partial class FormMenu : Form
    {
        private Order order;

        public FormMenu()
        {
            InitializeComponent();
            order = new Order();
        }

        private void BtnClickOrder_Click(object sender, EventArgs e)
        {
            FormPayment frmPayment = new FormPayment(order);
            frmPayment.ShowDialog();
        }

        private void CbxTomato_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxTomato.Checked)
            {
                order.AddToCategory("Hamburger", "Tomato");
            }
            else
            {
                order.RemoveFromCategory("Hamburger", "Tomato");
            }
        }

        private void CbxPickles_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxPickles.Checked)
            {
                order.AddToCategory("Hamburger", "Pickles");
            }
            else
            {
                order.RemoveFromCategory("Hamburger", "Pickles");
            }
        }
        private void CbxLettuce_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxLettuce.Checked)
            {
                order.AddToCategory("Hamburger", "Lettuce");
            }
            else
            {
                order.RemoveFromCategory("Hamburger", "Lettuce");
            }
        }
        private void CbxOnion_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxOnion.Checked)
            {
                order.AddToCategory("Hamburger", "Onion");
            }
            else
            {
                order.RemoveFromCategory("Hamburger", "Onion");
            }
        }

        private void CbxCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxCheese.Checked)
            {
                order.AddToCategory("Hamburger", "Cheese");
            }
            else
            {
                order.RemoveFromCategory("Hamburger", "Cheese");
            }
        }
        private void CbxHouseSauce_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxHouseSauce.Checked)
            {
                order.AddToCategory("Hamburger", "House Sauce");
            }
            else
            {
                order.RemoveFromCategory("Hamburger", "House Sauce");
            }
        }
        private void CbxLFrenchFries_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxLFrenchFries.Checked)
            {
                order.AddToCategory("Extras", "Large French Fries");
            }
            else
            {
                order.RemoveFromCategory("Extras", "Large French Fries");
            }
        }

        private void CbxSFrenchFries_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxSFrenchFries.Checked)
            {
                order.AddToCategory("Extras", "Small French Fries");
            }
            else
            {
                order.RemoveFromCategory("Extras", "Small French Fries");
            }
        }

        private void CbxOnionRings_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxOnionRings.Checked)
            {
                order.AddToCategory("Extras", "Onion Rings");
            }
            else
            {
                order.RemoveFromCategory("Extras", "Onion Rings");
            }
        }


        private void CbxPotatoes_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxPotatoes.Checked)
            {
                order.AddToCategory("Extras", "Potatoes");
            }
            else
            {
                order.RemoveFromCategory("Extras", "Potatoes");
            }
        }
        private void CbxWater_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxWater.Checked)
            {
                order.AddToCategory("Drinks", "Water");
            }
            else
            {
                order.RemoveFromCategory("Drinks", "Water");
            }
        }

        private void CbxCoke_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxCoke.Checked)
            {
                order.AddToCategory("Drinks", "Coke");
            }
            else
            {
                order.RemoveFromCategory("Drinks", "Coke");
            }
        }

        private void CbxLemonade_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxLemonade.Checked)
            {
                order.AddToCategory("Drinks", "Lemonade");
            }
            else
            {
                order.RemoveFromCategory("Drinks", "Lemonade");
            }
        }

        private void CbxSprite_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxSprite.Checked)
            {
                order.AddToCategory("Drinks", "Sprite");
            }
            else
            {
                order.RemoveFromCategory("Drinks", "Sprite");
            }
        }



        private void CbxKetchup_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxKetchup.Checked)
            {
                order.AddToCategory("Sauces", "Ketchup");
            }
            else
            {
                order.RemoveFromCategory("Sauces", "Ketchup");
            }
        }

        private void CbxMayo_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxMayo.Checked)
            {
                order.AddToCategory("Sauces", "Mayo");
            }
            else
            {
                order.RemoveFromCategory("Sauces", "Mayo");
            }
        }

        private void CbxBarbecue_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxBarbecue.Checked)
            {
                order.AddToCategory("Sauces", "Barbecue");
            }
            else
            {
                order.RemoveFromCategory("Sauces", "Barbecue");
            }
        }

        private void CbxGarlicSauce_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxGarlicSauce.Checked)
            {
                order.AddToCategory("Sauces", "Garlic Sauce");
            }
            else
            {
                order.RemoveFromCategory("Sauces", "Garlic Sauce");
            }
        }
        private void LblExtraPrice_Click(object sender, EventArgs e)
        {

        }

        private void GrpChanges_Enter(object sender, EventArgs e)
        {

        }

    }
}


    







