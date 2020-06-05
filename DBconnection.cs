using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Renci.SshNet;
using Ubiety.Dns.Core.Records;

namespace Programme_pizzeria2
{
    class DBconnection
    {
        private MySqlConnection conn;
        public DBconnection()
        {
            InitConnexion();
        }

        private void InitConnexion()
        {
            // Création de la chaîne de connexion 
            string cs = @"server=localhost;userid=root;
            password=root;database=Pizzeria";


            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();
                Console.WriteLine("MySQL version : {0}", conn.ServerVersion);

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

            }

        }

        public void OpenDB()
        { 
                conn.Open();
           
        }

        public void CloseDB()
        {
            conn.Close();
        }

        public void NouvelleCommande()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO Commands(Number, Emloyees_ID) VALUES(@Number, @Emloyees_ID)";
            cmd.Prepare();

            cmd.Parameters.AddWithValue("@Number", "2200");
            //cmd.Parameters.AddWithValue("@DATE", "20/10/2020");
            cmd.Parameters.AddWithValue("@Emloyees_ID", 1);
            cmd.ExecuteNonQuery();

        }
        public void Login(string username,string password)
        {
            int i=0;
            MySqlCommand cmd = new MySqlCommand();
            cmd = conn.CreateCommand();
            //cmd.Connection = conn;
            
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM login WHERE username='" + username +"' and password= '" + password+"'";
            
           
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {
                MessageBox.Show("Username ou mot de passe incorrecte");
                //label = "Username ou mot de passe incorrecte";

            }
            else
            {
                frmPizza frmPizza = new frmPizza();
                frmPizza.Show();
            }
        }


    



        public void InsertPizza(int quantity, string product, string commands, string basis, string size)
        {

            //Console.WriteLine(product + " " + basis + " " + size);
            int commands_id = 1;
            int basis_id = GetBasisID(basis);
            int product_id = GetProductsID(product);
            //int basis_id = 3;
            int size_id = GetSizeID(size);

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO Commands_has_products(Quantity, Products_id, Commands_id, Basis_id, Sizes_id) VALUES(@Q, @P, @C, @B, @S)";
            cmd.Prepare();

            cmd.Parameters.AddWithValue("@Q", quantity);
            cmd.Parameters.AddWithValue("@P", product_id);
            cmd.Parameters.AddWithValue("@C", commands_id);
            cmd.Parameters.AddWithValue("@B", basis_id);
            cmd.Parameters.AddWithValue("@S", size_id);
            cmd.ExecuteNonQuery();

        }

        public void InsertBoisson(List<String> boissons, List<int> Quantities)
        {

            int commands_id = 1;
            int basis_id = 1;
            int product_id = 0;
            //int basis_id = 3;
            int size_id = 1;
            int i = 0;
            //Console.WriteLine(product + " " + basis + " " + size);
            foreach (var b in boissons)
            {
                Console.WriteLine(b);
                product_id = GetProductsID(b);
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO Commands_has_products(Quantity, Products_id, Commands_id, Basis_id, Sizes_id) VALUES(@Q, @P, @C, @B, @S)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@Q", Quantities.ElementAt(i++));
                cmd.Parameters.AddWithValue("@P", product_id);
                cmd.Parameters.AddWithValue("@C", commands_id);
                cmd.Parameters.AddWithValue("@B", basis_id);
                cmd.Parameters.AddWithValue("@S", size_id);
                cmd.ExecuteNonQuery();
            }


        }

        public void InsertDessert(List<String> Desserts, List<int> Quantities)
        {

            int commands_id = 1;
            int basis_id = 1;
            int product_id = 0;
            //int basis_id = 3;
            int size_id = 1;
            int i = 0;
            //Console.WriteLine(product + " " + basis + " " + size);
            foreach (var b in Desserts)
            {
                Console.WriteLine(b);
                product_id = GetProductsID(b);
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO Commands_has_products(Quantity, Products_id, Commands_id, Basis_id, Sizes_id) VALUES(@Q, @P, @C, @B, @S)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@Q", Quantities.ElementAt(i++));
                cmd.Parameters.AddWithValue("@P", product_id);
                cmd.Parameters.AddWithValue("@C", commands_id);
                cmd.Parameters.AddWithValue("@B", basis_id);
                cmd.Parameters.AddWithValue("@S", size_id);
                cmd.ExecuteNonQuery();
            }


        }

        public int GetSizeID(string size)
        {
            int r = -1;
            MySqlDataReader rdr = null;
            string stm = "SELECT id FROM Sizes where Value like '%" + size + "%'";
            MySqlCommand cmd = new MySqlCommand(stm, conn);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                r = rdr.GetInt32(0);
            }
            if (rdr != null)
            {
                rdr.Close();
            }
            return r;

        }
        public int GetBasisID(string basis)
        {
            int r = -1;
            MySqlDataReader rdr = null;
            string stm = "SELECT id FROM Basis where Value like '%" + basis + "%'";
            MySqlCommand cmd = new MySqlCommand(stm, conn);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                r = rdr.GetInt32(0);
            }
            if (rdr != null)
            {
                rdr.Close();
            }
            return r;
        }

        public int GetProductsID(string product)
        {
            int r = -1;
            MySqlDataReader rdr = null;
            string stm = "SELECT id FROM Products where Name like '%" + product + "%'";
            MySqlCommand cmd = new MySqlCommand(stm, conn);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                r = rdr.GetInt32(0);
            }
            if (rdr != null)
            {
                rdr.Close();
            }
            return r;

        }

        public int GetProductsAmount(string product)
        {
            int r = -1;
            MySqlDataReader rdr = null;
            string stm = "SELECT amount FROM Products where Name like '%" + product + "%'";
            MySqlCommand cmd = new MySqlCommand(stm, conn);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                r = rdr.GetInt32(0);
            }
            if (rdr != null)
            {
                rdr.Close();
            }
            return r;

        }

    }
}
