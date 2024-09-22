using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Piza_Order : Form
    {
        public Piza_Order()
        {
            InitializeComponent();
        }

        float getSizePrice()
        {
            if (RdSmall.Checked) return Convert.ToSingle(RdSmall.Tag);
            else if (RdMedium.Checked) return Convert.ToSingle(RdMedium.Tag);
            else return Convert.ToSingle(RdLarge.Tag);
        }

        float getToppingPrice()
        {
            float toppingPrice = 0;
            if (CbExtraCheese.Checked) toppingPrice += Convert.ToSingle(CbExtraCheese.Tag);
            if (CbOnion.Checked) toppingPrice += Convert.ToSingle(CbOnion.Tag);
            if (CbMushrooms.Checked) toppingPrice += Convert.ToSingle(CbMushrooms.Tag);
            if (CbOlives.Checked) toppingPrice += Convert.ToSingle(CbMushrooms.Tag);
            if (CbTomatoes.Checked) toppingPrice += Convert.ToSingle(CbMushrooms.Tag);
            if (CbGreen.Checked) toppingPrice += Convert.ToSingle(CbGreen.Tag);
            return toppingPrice;
        }

        float getCrustPrice()
        {
            if (RdThick.Checked) return Convert.ToSingle(RdThick.Tag);
            else return Convert.ToSingle(RdThin.Tag);
        }

        float getManyOfPizz()
        {
            return Convert.ToSingle(numericUpDown1.Value);
        }

        float calculateTotalPrice()
        {
            return (getSizePrice() + getToppingPrice() + getCrustPrice()) * getManyOfPizz();
        }

        void updateTotalPrice()
        {
            LblPrice.Text = "$" + calculateTotalPrice().ToString();
        }

        void updateSize()
        {
            updateTotalPrice();
            if (RdSmall.Checked)
            {
                Size.Text = "Small";
                return;
            }
            if (RdMedium.Checked)
            {
                Size.Text = "Medium";
                return;
            }
            if (RdLarge.Checked)
            {
                Size.Text = "Large";
                return;
            }
        }

        void updateCrust()
        {
            updateTotalPrice();
            if (RdThick.Checked)
            {
                lblCrustType.Text = "Thick";
                return;
            }
            else
            {
                lblCrustType.Text = "Thin";
                return;
            }
        }

        void updateToppings()
        {
            updateTotalPrice();
            string sToppings = "";
            if (CbExtraCheese.Checked) sToppings += "Extra Cheese";
            if (CbOnion.Checked) sToppings += ", Onion";
            if (CbMushrooms.Checked) sToppings += ", Mushrooms";
            if (CbOlives.Checked) sToppings += ", Olives";
            if (CbTomatoes.Checked) sToppings += ", Tomatoes";
            if (CbGreen.Checked) sToppings += ", Green Pappers";
            if (sToppings.StartsWith(","))
            {
                sToppings = sToppings.Substring(1, sToppings.Length - 1).Trim();
            }
            LblToppings.Text = sToppings;
        }

        void updateWhereToEat()
        {
            if (RbEatIn.Checked)
            {
                lblWhereToEat.Text = "Eat In";
                return;
            }
            else
            {
                lblWhereToEat.Text = "Take Away";
                return;
            }
        }

        void updateAmount()
        {
            updateTotalPrice();
            lblNumbeOfPizza.Text = numericUpDown1.Value.ToString();
        }

        void updateOrderSummary()
        {
            updateSize();
            updateCrust();
            updateToppings();
            updateWhereToEat();
            updateTotalPrice();
        }

        void resetForm()
        {
            GbSize.Enabled = true;
            GbCrust.Enabled = true;
            GbWhereToEat.Enabled = true;
            GbToppings.Enabled = true;

            RdMedium.Checked = true;

            CbExtraCheese.Checked = false;
            CbGreen.Checked = false;
            CbMushrooms.Checked = false;
            CbOlives.Checked = false;
            CbOnion.Checked = false;
            CbTomatoes.Checked = false;
            
            RdThin.Checked = true;

            RbEatIn.Checked = true;
            
            BtnOrderPizza.Enabled = true;

            numericUpDown1.Enabled = true;
        }

        private void BtnOrderPizza_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm Order", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Order Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnOrderPizza.Enabled = false;
                GbSize.Enabled = false;
                GbCrust.Enabled = false;
                GbToppings.Enabled = false;
                GbWhereToEat.Enabled = false;
                numericUpDown1.Enabled = false;
            }
            else
            {
                MessageBox.Show("Update Your Order", "Updating Order",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void RdSmall_CheckedChanged(object sender, EventArgs e)
        {
            updateSize();
        }

        private void RdMedium_CheckedChanged(object sender, EventArgs e)
        {
            updateSize();
        }

        private void RdLarge_CheckedChanged(object sender, EventArgs e)
        {
            updateSize();
        }

        private void RdThin_CheckedChanged(object sender, EventArgs e)
        {
            updateCrust();
        }

        private void RdThick_CheckedChanged(object sender, EventArgs e)
        {
            updateCrust();
        }

        private void CbExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void CbOnion_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void CbMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void CbOlives_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void CbTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void CbGreen_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void RbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            updateWhereToEat();
        }

        private void RbTakeAway_CheckedChanged(object sender, EventArgs e)
        {
            updateWhereToEat();
        }

        private void Piza_Order_Load(object sender, EventArgs e)
        {
            updateOrderSummary();
        }

        private void BtnResetForm_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            updateAmount();
        }
    }
}
