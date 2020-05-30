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
        private string NomDesserts(String d)
        {
            switch (d)
            {
                case "udFondantCaramel1": return "FONDANT AU CARAMEL";
                case "udFondantChocolat2": return "FONDANT AU CHOCOLAT";
                case "udTarteDaim3": return "TARTE AU DAIM";
                case "udTiramisuDaim4": return "TIRAMISU DAIM";
                case "udTiramisuOreo5": return "TIRAMISU OREO";
                case "udTiramisuSpeculos6": return "TIRAMISU SPECULOS";
               

                default: return "erreur";
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            List<string> Desserts = new List<string>();
            List<int> Quantities = new List<int>();
            List<DomainUpDown> listBoissonOrderedByName = gbDesserts.Controls.OfType<DomainUpDown>().OrderBy(c => c.Name).ToList();
            foreach (var c in listBoissonOrderedByName)
            {
                //Console.WriteLine("Boissons text : " + Convert.ToInt16(c.Text));
                if (Convert.ToInt16(c.Text) > 0)
                {
                    Desserts.Add(NomDesserts(c.Name));
                    Quantities.Add(Convert.ToInt16(c.Text));
                }
            }
            Console.WriteLine("Desserts Count : " + Desserts.Count());
            DBconnection db = new DBconnection();
            db.InsertDessert(Desserts, Quantities);
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

        private void frmDesserts_Load(object sender, EventArgs e)
        {
            gbDesserts_Enter(sender, e);
        }
    }
}
