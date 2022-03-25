using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS311_Project3_SRB
{
    public partial class frmRestaurant : Form
    {
        public frmRestaurant()
        {
            InitializeComponent();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Summarize();
        } // end button click
        private void Summarize()
            {
            float subtotal = 0;
            float taxPercentage = 3;
            float tax;
            float totalOrder;
            
            // size combobox processing
            switch (cboSize.SelectedItem.ToString())
            {
                case "Small":
                    subtotal += 2;
                    break;
                case "Medium":
                    subtotal += 5;
                    break;
                case "Large":
                    subtotal += 10;
                    break;
                case "X-Large":
                    subtotal += 15;
                    break;
                case "Ginormous":
                    subtotal += 20;
                    break;
            }
            // end size combobox processing
        
            // crust radiobox processing
            String sizeData = cboSize.GetItemText(cboSize.SelectedItem);
            rtfOrderOutput.Clear();
            rtfOrderOutput.SelectedText = "You ordered a " + sizeData + " pizza with ";
            if (rdoThin.Checked)
                rtfOrderOutput.SelectedText = "Thin crust and the following toppings:" + "\n";
            else if (rdoThick.Checked)
                rtfOrderOutput.SelectedText = "Thick crust and the following toppings:" + "\n";
            else if (rdoRegular.Checked)
                rtfOrderOutput.SelectedText = "Regular crust and the following toppings:" + "\n";
            // end crust radiobox processing

            // topping checkbox processing
            rtfOrderOutput.SelectionBullet = true;
            if (ckbPepperoni.Checked)
            {
                rtfOrderOutput.SelectedText = "Pepperoni" + "\n";
                subtotal += 2;
            }
            if (ckbSausage.Checked)
            {
                rtfOrderOutput.SelectedText = "Sausage" + "\n";
                subtotal += 2;
            }
            if (ckbCanadianBacon.Checked)
            {
                rtfOrderOutput.SelectedText = "Canadian Bacon" + "\n";
                subtotal += 2;
            }
            if (ckbSpicyItalianSausage.Checked)
            {
                rtfOrderOutput.SelectedText = "Spicy Italian Sausage" + "\n";
                subtotal += 2;
            }
            if (ckbOnion.Checked)
            {
                rtfOrderOutput.SelectedText = "Onion" + "\n";
                subtotal += 1;
            }
            if (ckbGreenPepper.Checked)
            {
                rtfOrderOutput.SelectedText = "Green Pepper" + "\n";
                subtotal += 1;
            }
            if (ckbBlackOlives.Checked)
            {
                rtfOrderOutput.SelectedText = "Black Olives" + "\n";
                subtotal += 1;
            }
            if (ckbGreenOlives.Checked)
            {
                rtfOrderOutput.SelectedText = "Green Olives" + "\n";
                subtotal += 1;
            }
            if (ckbBananaPeppers.Checked)
            {
                rtfOrderOutput.SelectedText = "Banana Peppers" + "\n";
                subtotal += 1;
            }
            if (ckbJalapeno.Checked)
            {
                rtfOrderOutput.SelectedText = "Jalapeno" + "\n";
                subtotal += 1;
            }
            if (ckbExtraCheese.Checked)
            {
                rtfOrderOutput.SelectedText = "Extra Cheese" + "\n";
                subtotal += 1;
            }
            if (ckbMushroom.Checked)
            {
                rtfOrderOutput.SelectedText = "Mushroom" + "\n";
                subtotal += 1;
            }  
            rtfOrderOutput.SelectionBullet = false;
            // topping checkbox processing

            // order total math
            string subtotalDisplay = subtotal.ToString("C");
            txtSubtotal.Text = subtotalDisplay;

            tax = ((subtotal) * (taxPercentage / 100));
            string taxDisplay = tax.ToString("C");
            txtTax.Text = taxDisplay;

            totalOrder = subtotal + tax;
            txtTotal.Text = totalOrder.ToString("C");
            // end order total math

        } // end summarize method
    } // end form
} // end namespace