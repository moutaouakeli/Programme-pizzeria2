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
        private string NomBoisson(String b)
        {
            switch (b)
            {
                case "ud7up": return "7 UP MOJITO";
                case "udCafe": return "CAFE";
                case "udCaprisun": return "CAPRISUN";
                case "udCoca": return "COCA COLA";
                case "udCoca15L": return "COCA COLA 1.5 L";
                case "udCocaZero": return "COCA COLA ZERO";
                case "udEauGaz50cl": return "EAU GAZEUSE 50 CL";
                case "udEauPlate50cl": return "EAU PLATE 50 CL";
                case "udFantaLemon": return "FANTA LEMON";
                case "udFantaOrange": return "FANTA ORANGE";
                case "udNesteaCitron": return "NESTEA CITRON";
                case "udNesteaPeche": return "NESTEA PECHE";
                case "udOasis": return "OASIS";
                case "udOasis2l": return "OASIS 2L";
                case "udOasisPomme": return "OASIS POMME CASSIS FRAMBOISE";
                case "udOrangina": return "ORANGINA";
                case "udSprite": return "SPRITE";
                case "udTropico": return "TROPICO";

                default: return "erreur";
            }
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {

            List<string> Boissons = new List<string>();
            List<int> Quantities = new List<int>();
            List<DomainUpDown> listBoissonOrderedByName = gbBoissons.Controls.OfType<DomainUpDown>().OrderBy(c => c.Name).ToList();
            foreach (var c in listBoissonOrderedByName)
            {
                //Console.WriteLine("Boissons text : " + Convert.ToInt16(c.Text));
                if (Convert.ToInt16(c.Text) > 0)
                {
                    Boissons.Add(NomBoisson(c.Name));
                    Quantities.Add(Convert.ToInt16(c.Text));
                }
            }
            Console.WriteLine("Boissons Count : " + Boissons.Count());
            DBconnection db = new DBconnection();
            db.InsertBoisson(Boissons, Quantities);
            frmDesserts dessert = new frmDesserts();
            dessert.Show();







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

        private void frmBoissons_Load(object sender, EventArgs e)
        {
            gbBoissons_Enter(sender, e);
        }
    }
}
//Test