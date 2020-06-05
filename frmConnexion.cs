using Org.BouncyCastle.Crypto.Tls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Programme_pizzeria2
{
    public partial class frmConnexion : Form
    {
        public frmConnexion()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {

            DBconnection db = new DBconnection();
            db.Login(txtEmail.Text, txtMotDePasse.Text);

        }

        private void btnAnnulerConn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConnexion_Load(object sender, EventArgs e)
        {
            //Hide password
            txtMotDePasse.PasswordChar = '*';
        }

        private void lblErreurConnexion_Click(object sender, EventArgs e)
        {
            frmCreationCompte frmCreationCompte = new frmCreationCompte();
            frmCreationCompte.Show();
            this.Hide();
        }
    }
}
