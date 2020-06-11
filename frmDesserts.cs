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
    public partial class frmDesserts : Form
    {
        public frmDesserts()
        {
            InitializeComponent();
        }
        

        private void btnValider_Click(object sender, EventArgs e)
        {
            List<Products> Desserts = new List<Products>();
            List<int> Quantities = new List<int>();
            Products p = new Products();
            List<DomainUpDown> listBoissonOrderedByName = gbDesserts.Controls.OfType<DomainUpDown>().OrderBy(c => c.Name).ToList();
            foreach (var c in listBoissonOrderedByName)
            {
                //Console.WriteLine("Boissons text : " + Convert.ToInt16(c.Text));
                if (Convert.ToInt16(c.Text) > 0)
                {
                    p = new Products();
                    p.Id = Convert.ToInt16(c.Name.Substring(2));
                    Desserts.Add(p);
                    Quantities.Add(Convert.ToInt16(c.Text));
                }
            }
            DBconnection db = new DBconnection();
            db.InsertDessert(Desserts, Quantities);
            frmRecapitulatif recap = new frmRecapitulatif();
            recap.Show();
            recap.frmRecapitulatif_Load(sender, e);
            this.Close();
        }

        private void gbDesserts_Enter(object sender, EventArgs e)
        {
            List<DomainUpDown> listUpDownesOrderedByName = gbDesserts.Controls.OfType<DomainUpDown>().ToList();
            foreach (var c in listUpDownesOrderedByName)
            {
                for (int i = 0; i <= 5; i++)
                {
                    c.Items.Add(i);
                }
            }
        }

        public void frmDesserts_Load(object sender, EventArgs e)
        {
            DBconnection db = new DBconnection();
            List<Products> lstProd = db.GetDesserts();
            int i = 0;
            int j = 0;
            foreach (Products prod in lstProd)
            {
                if (i < 8)
                {
                    Label lbl = new Label();
                    lbl.AutoSize = true;
                    lbl.Location = new System.Drawing.Point(20+j, 40 + 40 * i);
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

                    this.gbDesserts.Controls.Add(lbl);
                    this.gbDesserts.Controls.Add(dup);
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

                    this.gbDesserts.Controls.Add(lbl);
                    this.gbDesserts.Controls.Add(dup);
                    //this.Controls.Add(lbl);
                    //this.Controls.Add(dup);
                    j++;*/
                }


            }
        }
    }
}
