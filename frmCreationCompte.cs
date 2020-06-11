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
    public partial class frmCreationCompte : Form
    {
        public frmCreationCompte()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            frmConnexion frmConnexion = new frmConnexion();
            frmConnexion.Show();
            this.Hide();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            DBconnection db = new DBconnection();
            db.InsertEmploye(txtPrenom.Text,txtNom.Text,txtTel.Text,txtEmail.Text,rtbAdresse.Text,1); //Rajouter une checkbox pour choisir la pizzeria
        }
    }
}
