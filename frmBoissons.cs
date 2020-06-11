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
    public partial class frmBoissons : Form
    {
        public frmBoissons()
        {
            InitializeComponent();
        }
        

        private void btnSuivant_Click(object sender, EventArgs e)
        {

            List<Products> Boissons = new List<Products>();
            Products p = new Products();
            List<int> Quantities = new List<int>();
            List<DomainUpDown> listBoissonOrderedByName = gbBoissons.Controls.OfType<DomainUpDown>().OrderBy(c => c.Name).ToList();
            foreach (var c in listBoissonOrderedByName)
            {
                //Console.WriteLine("Boissons text : " + Convert.ToInt16(c.Text));
                if (Convert.ToInt16(c.Text) > 0)
                {
                    p = new Products();
                    p.Id = Convert.ToInt16(c.Name.Substring(2));
                    Boissons.Add(p);
                    Quantities.Add(Convert.ToInt16(c.Text));
                }
            }
            DBconnection db = new DBconnection();
            db.InsertBoisson(Boissons, Quantities);
            frmDesserts dessert = new frmDesserts();
            dessert.Show();
            dessert.frmDesserts_Load(sender, e);
            this.Close();






        }

        private void gbBoissons_Enter(object sender, EventArgs e)
        {
            List<DomainUpDown> listUpDownesOrderedByName = gbBoissons.Controls.OfType<DomainUpDown>().ToList();
            foreach (var c in listUpDownesOrderedByName)
            {
                for (int i = 0; i <= 5; i++)
                {
                    c.Items.Add(i);
                }
            }
        }

        public void frmBoissons_Load(object sender, EventArgs e)
        {
            DBconnection db = new DBconnection();
            List<Products> lstProd = db.GetDrinks();
            int i = 0;
            int j = 0;
            foreach (Products prod in lstProd)
            {
                if (i < 9)
                {
                    Label lbl = new Label();
                    lbl.AutoSize = true;
                    lbl.Location = new System.Drawing.Point(50+j, 40 + 40 * i);
                    lbl.Name = "lbl" + prod.Id;
                    lbl.Size = new System.Drawing.Size(84, 20);
                    lbl.TabIndex = 53;
                    lbl.Text = prod.Name;

                    DomainUpDown dup = new DomainUpDown();
                    dup.Location = new System.Drawing.Point(200+j, 40 + 40 * i);
                    dup.Name = "ud" + prod.Id;
                    dup.Size = new System.Drawing.Size(58, 27);
                    dup.TabIndex = 24;
                    dup.Text = "0";

                    this.gbBoissons.Controls.Add(lbl);
                    this.gbBoissons.Controls.Add(dup);
                    //this.Controls.Add(lbl);
                    //this.Controls.Add(dup);
                    i++;
                }
                else
                {
                    i = 0;
                    j = j + 250;
                    /* Label lbl = new Label();
                     lbl.AutoSize = true;
                     lbl.Location = new System.Drawing.Point(300, 40 + 40 * j);
                     lbl.Name = "lbl" + prod.Id;
                     lbl.Size = new System.Drawing.Size(84, 20);
                     lbl.TabIndex = 53;
                     lbl.Text = prod.Name;

                     DomainUpDown dup = new DomainUpDown();
                     dup.Location = new System.Drawing.Point(400, 40 + 40 * j);
                     dup.Name = "ud" + prod.Id;
                     dup.Size = new System.Drawing.Size(58, 27);
                     dup.TabIndex = 24;
                     dup.Text = "0";

                     this.gbBoissons.Controls.Add(lbl);
                     this.gbBoissons.Controls.Add(dup);
                     //this.Controls.Add(lbl);
                     //this.Controls.Add(dup);
                     j++;*/

                }


            }
        }
    }
}
//Test