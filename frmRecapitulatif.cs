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
    public partial class frmRecapitulatif : Form
    {
        public frmRecapitulatif()
        {
            InitializeComponent();
        }

        public void frmRecapitulatif_Load(object sender, EventArgs e)
        {
            DBconnection db = new DBconnection();
            List<Commands_has_products> lstCP = db.GetCommandsRecap(Commands.command_id);
            int i = 0;
            double total = 0;
            foreach (Commands_has_products prod in lstCP)
            {
                Label lbl = new Label();
                lbl.AutoSize = true;
                lbl.Location = new System.Drawing.Point(50, 40 + 40 * i);
                lbl.Name = "lbl" + i;
                lbl.Size = new System.Drawing.Size(84, 20);
                lbl.TabIndex = 53;
                lbl.Text = prod.name;
                this.listView1.Controls.Add(lbl);

                Label lbl1 = new Label();
                lbl1.AutoSize = true;
                lbl1.Location = new System.Drawing.Point(350, 40 + 40 * i);
                lbl1.Name = "lbl" + i;
                lbl1.Size = new System.Drawing.Size(84, 20);
                lbl1.TabIndex = 53;
                lbl1.Text = Convert.ToString(prod.quantity);
                this.listView1.Controls.Add(lbl1);


                Label lbl2 = new Label();
                lbl2.AutoSize = true;
                lbl2.Location = new System.Drawing.Point(450, 40 + 40 * i);
                lbl2.Name = "lbl" + i;
                lbl2.Size = new System.Drawing.Size(84, 20);
                lbl2.TabIndex = 53;
                lbl2.Text = Convert.ToString(prod.TotalProduct);
                this.listView1.Controls.Add(lbl2);
                total = total + prod.TotalProduct;

                

                i++;

            }
            Label lbl3 = new Label();
            lbl3.AutoSize = true;
            lbl3.Location = new System.Drawing.Point(50, 40 + 40 * i);
            lbl3.Name = "lbl" + i;
            lbl3.Size = new System.Drawing.Size(84, 20);
            lbl3.TabIndex = 53;
            lbl3.Text = "Supplément";
            this.listView1.Controls.Add(lbl3);

            Label lbl4 = new Label();
            lbl4.AutoSize = true;
            lbl4.Location = new System.Drawing.Point(450, 40 + 40 * i);
            lbl4.Name = "lbl" + i;
            lbl4.Size = new System.Drawing.Size(84, 20);
            lbl4.TabIndex = 53;
            lbl4.Text = Convert.ToString(Commands.command_sup);
            this.listView1.Controls.Add(lbl4);

            textBox1.Enabled = false;
            textBox1.Text = Convert.ToString(total+Commands.command_sup);

        }

        private void btnNouvelleCommande_Click(object sender, EventArgs e)
        {
            this.Close();
            new Commands();
        }
    }
}
