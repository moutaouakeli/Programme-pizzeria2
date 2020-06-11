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



        public void frmPizza_Load(object sender, EventArgs e)
        {
            DBconnection db = new DBconnection();
            List<Products> lstProd = db.GetPizzas();
            foreach (Products prod in lstProd)
            {
                cbPizza.Items.Add(prod.Name);
            }
            lstProd = new List<Products>();
            lstProd = db.Getingredients();
            int i = 0;
            int j = 0;
            foreach (Products prod in lstProd)
            {
                if (i < 5)// Afficher 5 par 5
                {

                    CheckBox dup = new CheckBox();
                    dup.Location = new System.Drawing.Point(10 + j, 40 + 40 * i); 
                    dup.Name = "ud" + prod.Id;
                    dup.Text = prod.Name;
                    dup.Size = new System.Drawing.Size(100, 20);
                    dup.TabIndex = 24;
                    this.gbIngredients.Controls.Add(dup);
                    i++;
                }
                else
                {
                    i = 0;
                    j = j + 110;// Le decalage our afficher la colonne suivante
                }


            }
        }

        private void gbIngredients_MouseEnter(object sender, EventArgs e)
        {
            int n = 0;
            DBconnection db = new DBconnection();
            List<CheckBox> listCheckboxesOrderedByName = gbIngredients.Controls.Cast<CheckBox>().OrderBy(c => c.Name).ToList();

            foreach (var c in listCheckboxesOrderedByName)
            {
                if (rb30cm.Checked)
                {
                    if (c.Checked)
                    {
                        n = n + db.GetsuppIngr(rb30cm.Text);
                        //n = Convert.ToInt16(label2.Text) + 2
                    }
                }
                if (rb40cm.Checked)
                {
                    Console.WriteLine("40 cm checked, BindableSupport est : " + n);
                    if (c.Checked)
                    {
                        //int n = Convert.ToInt16(label2.Text) + 3;
                        n = n + db.GetsuppIngr(rb40cm.Text);

                    }
                }
                if (rbFamily.Checked)
                {
                    if (c.Checked)
                    {
                        //int n = Convert.ToInt16(label2.Text) + 4;
                        n = n + db.GetsuppIngr(rbFamily.Text);
                    }

                }

                // 2) now this loop runs through the checkboxes 
                // that have been sorted by name

            }
            lblPrixSup.Text = Convert.ToString(n);
        }



        private void frmPizza_reset(object sender, EventArgs e)
        {

            rb30cm.Checked = true;

            List<RadioButton> listgbBasePizzaOrderedByName = gbBasePizza.Controls.Cast<RadioButton>().OrderBy(c => c.Name).ToList();

            foreach (var c in listgbBasePizzaOrderedByName)
            {
                c.Checked = false;
            }

            List<CheckBox> listCheckboxesOrderedByName = gbIngredients.Controls.Cast<CheckBox>().OrderBy(c => c.Name).ToList();

            foreach (var c in listCheckboxesOrderedByName)
            {
                c.Checked = false;
            }
        }





        private void btnPlus_Click(object sender, EventArgs e)
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
            
            Commands.command_sup = Commands.command_sup + Convert.ToInt32( lblPrixSup.Text);
            DBconnection db = new DBconnection();
            db.InsertPizza(1, cbPizza.Text, "", Base, Size);
            AddIngredient(sender, e);
            frmPizza_reset(sender, e);
        }
        private void AddIngredient(object sender, EventArgs e)
        {
            List<Products> Ingredients = new List<Products>();
            Products p = new Products();
            List<CheckBox> listBoissonOrderedByName = gbIngredients.Controls.OfType<CheckBox>().OrderBy(c => c.Name).ToList();
            foreach (var c in listBoissonOrderedByName)
            {
                if (c.Checked)
                {
                    p = new Products();
                    p.Id = Convert.ToInt16(c.Name.Substring(2));
                    Ingredients.Add(p);
                }
            }
            DBconnection db = new DBconnection();
            db.InsertIngredients(Ingredients);
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
            Commands.command_sup = Commands.command_sup + Convert.ToInt32(lblPrixSup.Text);
            DBconnection db = new DBconnection();
            db.InsertPizza(1, cbPizza.Text, "", Base, Size);
            AddIngredient(sender, e);
            frmBoissons boisson = new frmBoissons();
            boisson.Show();
            boisson.frmBoissons_Load(sender, e);
            this.Close();
        }

        private void cbPizza_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
