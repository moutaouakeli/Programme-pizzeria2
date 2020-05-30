using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programme_pizzeria2
{
    public partial class frmPizza : Form
    {
        public frmPizza()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            gbIngredients_Enter(sender, e);
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            gbIngredients_Enter(sender, e);
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            gbIngredients_Enter(sender, e);
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            gbIngredients_Enter(sender, e);
        }

        private void frmCommande_Load(object sender, EventArgs e)
        {

        }

        private void gbIngredients_Enter(object sender, EventArgs e)
        {
            int n = 0;
            List<CheckBox> listCheckboxesOrderedByName = gbIngredients.Controls.Cast<CheckBox>().OrderBy(c => c.Name).ToList();

            foreach (var c in listCheckboxesOrderedByName)
            {
                if (rb30cm.Checked)
                {
                    if (c.Checked)
                    {
                        n = n + 2;
                        
                    }
                }
                if (rb40cm.Checked)
                {
                    if (c.Checked)
                    {
                        
                        n = n + 3;
                    }
                }
                if (rbFamily.Checked)
                {
                    if (c.Checked)
                    {
                        
                        n = n + 4;
                    }

                }

                // 2) now this loop runs through the checkboxes 
                // that have been sorted by name

            }
            lblPrixSup.Text = Convert.ToString(n);
        }

        private void lblPrix_Click(object sender, EventArgs e)
        {

        }

        private void lblCHFIngredient_Click(object sender, EventArgs e)
        {

        }

        private void lblPlus_Click(object sender, EventArgs e)
        {

        }

        private void gbBasePizza_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            frmPizza cmd = new frmPizza();
            cmd.Show();
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            List<RadioButton> listBaseOrderedByName = gbBasePizza.Controls.Cast<RadioButton>().OrderBy(c => c.Name).ToList();
            String Base = "";
            foreach (var c in listBaseOrderedByName)
            {
                if (c.Checked)
                {
                    Base = c.Text;
                }
            }
            List<RadioButton> listSizeOrderedByName = gbTaillePizza.Controls.Cast<RadioButton>().OrderBy(c => c.Name).ToList();
            String Size = "";
            foreach (var c in listSizeOrderedByName)
            {
                if (c.Checked)
                {
                    Size = c.Text;
                }
            }

            DBconnection db = new DBconnection();
            db.InsertPizza(1, "marguarita", "", Base, Size);
            frmBoissons boisson = new frmBoissons();
            boisson.Show();
        }

        private void cbChampi7_CheckedChanged(object sender, EventArgs e)
        {
            gbIngredients_Enter(sender, e);
        }

        private void cbSalami13_CheckedChanged(object sender, EventArgs e)
        {
            gbIngredients_Enter(sender, e);
        }

        private void cbOeufs19_CheckedChanged(object sender, EventArgs e)
        {
            gbIngredients_Enter(sender, e);
        }

        private void cbPoulet25_CheckedChanged(object sender, EventArgs e)
        {
            gbIngredients_Enter(sender, e);
        }

        private void cbCourg2_CheckedChanged(object sender, EventArgs e)
        {
            gbIngredients_Enter(sender, e);
        }

        private void cbOlives8_CheckedChanged(object sender, EventArgs e)
        {
            gbIngredients_Enter(sender, e);
        }

        private void cbViandeHachee26_CheckedChanged(object sender, EventArgs e)
        {
            gbIngredients_Enter(sender, e);
        }

        private void cbArtich3_CheckedChanged(object sender, EventArgs e)
        {
            gbIngredients_Enter(sender, e);
        }

        private void cbOignons9_CheckedChanged(object sender, EventArgs e)
        {
            gbIngredients_Enter(sender, e);
        }

        private void cbGruyere15_CheckedChanged(object sender, EventArgs e)
        {
            gbIngredients_Enter(sender, e);
        }

        private void cbCrevettes21_CheckedChanged(object sender, EventArgs e)
        {
            gbIngredients_Enter(sender, e);
        }

        private void cbKebab27_CheckedChanged(object sender, EventArgs e)
        {
            gbIngredients_Enter(sender, e);
        }

        private void cbPoivr4_CheckedChanged(object sender, EventArgs e)
        {
            gbIngredients_Enter(sender, e);
        }

        private void cbRucola10_CheckedChanged(object sender, EventArgs e)
        {
            gbIngredients_Enter(sender, e);
        }

        private void cbFeta16_CheckedChanged(object sender, EventArgs e)
        {
            gbIngredients_Enter(sender, e);
        }

        private void cbFruitDeMer22_CheckedChanged(object sender, EventArgs e)
        {
            gbIngredients_Enter(sender, e);
        }

        private void cbMerguez28_CheckedChanged(object sender, EventArgs e)
        {
            gbIngredients_Enter(sender, e);
        }

        private void cbTomate5_CheckedChanged(object sender, EventArgs e)
        {
            gbIngredients_Enter(sender, e);
        }

        private void cbJambon11_CheckedChanged(object sender, EventArgs e)
        {
            gbIngredients_Enter(sender, e);
        }

        private void cbGorgonzola17_CheckedChanged(object sender, EventArgs e)
        {
            gbIngredients_Enter(sender, e);
        }

        private void cbThon23_CheckedChanged(object sender, EventArgs e)
        {
            gbIngredients_Enter(sender, e);
        }

        private void cbCapre6_CheckedChanged(object sender, EventArgs e)
        {
            gbIngredients_Enter(sender, e);
        }

        private void cbLard12_CheckedChanged(object sender, EventArgs e)
        {
            gbIngredients_Enter(sender, e);
        }

        private void cbRicotta18_CheckedChanged(object sender, EventArgs e)
        {
            gbIngredients_Enter(sender, e);
        }

        private void cbParmesan29_CheckedChanged(object sender, EventArgs e)
        {
            gbIngredients_Enter(sender, e);
        }
    }
}
