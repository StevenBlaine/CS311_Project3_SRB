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
        }
        private void Summarize()
            String sizeData = cboSize.GetItemText(cboSize.SelectedItem);
            rtfOrderOutput.Clear();
            rtfOrderOutput.SelectedText = "You ordered a " + sizeData + " pizza with ";
            if (rdoThin.Checked)
                rtfOrderOutput.SelectedText = "Thin crust and the following toppings:" + "\n";
            if (rdoThick.Checked)
                rtfOrderOutput.SelectedText = "Thick crust and the following toppings:" + "\n";
            if (rdoRegular.Checked)
                rtfOrderOutput.SelectedText = "Regular crust and the following toppings:" + "\n";
            rtfOrderOutput.SelectionBullet = true;
            if (ckbPepperoni.Checked)
                rtfOrderOutput.SelectedText = "Pepperoni" + "\n";
            if (ckbSausage.Checked)
                rtfOrderOutput.SelectedText = "Sausage" + "\n";
            if (ckbCanadianBacon.Checked)
                rtfOrderOutput.SelectedText = "Canadian Bacon" + "\n";
            if (ckbSpicyItalianSausage.Checked)
                rtfOrderOutput.SelectedText = "Spicy Italian Sausage" + "\n";
            if (ckbOnion.Checked)
                rtfOrderOutput.SelectedText = "Onion" + "\n";
            if (ckbGreenPepper.Checked)
                rtfOrderOutput.SelectedText = "Green Pepper" + "\n";
            if (ckbBlackOlives.Checked)
                rtfOrderOutput.SelectedText = "Black Olives" + "\n";
            if (ckbGreenOlives.Checked)
                rtfOrderOutput.SelectedText = "Green Olives" + "\n";
            if (ckbBananaPeppers.Checked)
                rtfOrderOutput.SelectedText = "Banana Peppers" + "\n";
            if (ckbJalapeno.Checked)
                rtfOrderOutput.SelectedText = "Jalapeno" + "\n";
            if (ckbExtraCheese.Checked)
                rtfOrderOutput.SelectedText = "Extra Cheese" + "\n";
            if (ckbMushroom.Checked)
                rtfOrderOutput.SelectedText = "Mushroom" + "\n";
            rtfOrderOutput.SelectionBullet = false;
        } 
    }
}