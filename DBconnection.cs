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
            cmd.CommandText = "INSERT INTO Commands(Number, Employees_ID) VALUES(@Number, @Employees_ID)";
            cmd.Prepare();

            cmd.Parameters.AddWithValue("@Number", "2200");
            //cmd.Parameters.AddWithValue("@DATE", "20/10/2020");
            cmd.Parameters.AddWithValue("@Employees_ID", 1);
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
                 frmConnexion frmConnexion = new frmConnexion();
                //frmPizza frmPizza = new frmPizza();
                //frmPizza.Show();
                new Commands();
                frmConnexion.Hide();

                
            }
        }


        public int createCommands()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO Commands(Number, Employees_ID) VALUES(@Number, @Employees_ID)";
            cmd.Prepare();

            cmd.Parameters.AddWithValue("@Number", 0000);
            //cmd.Parameters.AddWithValue("@DATE", "20/10/2020");
            cmd.Parameters.AddWithValue("@Employees_ID", 1);
            cmd.ExecuteNonQuery();

            int r = -1;
            MySqlDataReader rdr = null;
            string stm = "SELECT max(id) FROM Commands";
            MySqlCommand cmd1 = new MySqlCommand(stm, conn);
            rdr = cmd1.ExecuteReader();

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
        


        public void InsertPizza(int quantity, string product, string commands, string basis, string size)
        {

            //Console.WriteLine(product + " " + basis + " " + size);
            int commands_id = Commands.command_id;
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
        public void InsertIngredients(List<Products> Ingredients)
        {

            int commands_id = Commands.command_id;
            int basis_id = 4;
            int product_id = 0;
            //int basis_id = 3;
            int size_id = 4;
            int i = 0;
            foreach (Products b in Ingredients)
            {
                product_id = b.Id;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO Commands_has_products(Quantity, Products_id, Commands_id, Basis_id, Sizes_id) VALUES(@Q, @P, @C, @B, @S)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@Q", 1);
                cmd.Parameters.AddWithValue("@P", product_id);
                cmd.Parameters.AddWithValue("@C", commands_id);
                cmd.Parameters.AddWithValue("@B", basis_id);
                cmd.Parameters.AddWithValue("@S", size_id);
                cmd.ExecuteNonQuery();
            }
        }

        public void InsertBoisson(List<Products> boissons, List<int> Quantities)
        {

            int commands_id = Commands.command_id;
            int basis_id = 4;
            int product_id = 0;
            //int basis_id = 3;
            int size_id = 4;
            int i = 0;
            //Console.WriteLine(product + " " + basis + " " + size);
            foreach (var b in boissons)
            {
                Console.WriteLine(b);
                product_id = b.Id; 
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

        public void InsertDessert(List<Products> Desserts, List<int> Quantities)
        {

            int commands_id = Commands.command_id;
            int basis_id = 4;
            int product_id = 0;
            //int basis_id = 3;
            int size_id = 4;
            int i = 0;
            //Console.WriteLine(product + " " + basis + " " + size);
            foreach (var b in Desserts)
            {
                Console.WriteLine(b);
                product_id = b.Id;
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
        public int GetsuppIngr(string size)
        {
            int r = -1;
            MySqlDataReader rdr = null;
            string stm = "SELECT supIngr FROM Sizes where Value like '%" + size + "%'";
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
        public List<Products> GetDrinks()
        {
            List<Products> lstProd = new List<Products>();
            Products p = new Products();
            MySqlDataReader rdr = null;
            string stm = "SELECT id, Name, amount FROM Products where Categories_id = 2";
            MySqlCommand cmd = new MySqlCommand(stm, conn);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                p = new Products();
                p.Id = rdr.GetInt32(0);
                p.Name = rdr.GetString(1);
                p.Amount = rdr.GetInt32(2);

                lstProd.Add(p);
            }
            if (rdr != null)
            {
                rdr.Close();
            }
            return lstProd;
        }
        public List<Products> GetDesserts()
        {
            List<Products> lstProd = new List<Products>();
            Products p = new Products();
            MySqlDataReader rdr = null;
            string stm = "SELECT id, Name, amount FROM Products where Categories_id = 3";
            MySqlCommand cmd = new MySqlCommand(stm, conn);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                p = new Products();
                p.Id = rdr.GetInt32(0);
                p.Name = rdr.GetString(1);
                p.Amount = rdr.GetInt32(2);
                lstProd.Add(p);
            }
            if (rdr != null)
            {
                rdr.Close();
            }
            return lstProd;
        }
        public List<Products> GetPizzas()
        {
            List<Products> lstProd = new List<Products>();
            Products p = new Products();
            MySqlDataReader rdr = null;
            string stm = "SELECT id, Name, amount FROM Products where Categories_id = 1";
            MySqlCommand cmd = new MySqlCommand(stm, conn);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                p = new Products();
                p.Id = rdr.GetInt32(0);
                p.Name = rdr.GetString(1);
                p.Amount = rdr.GetInt32(2);
                lstProd.Add(p);
            }
            if (rdr != null)
            {
                rdr.Close();
            }
            return lstProd;
        }
        public List<Products> Getingredients()
        {
            List<Products> lstProd = new List<Products>();
            Products p = new Products();
            MySqlDataReader rdr = null;
            string stm = "SELECT id, Name, amount FROM Products where Categories_id = 4";
            MySqlCommand cmd = new MySqlCommand(stm, conn);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                p = new Products();
                p.Id = rdr.GetInt32(0);
                p.Name = rdr.GetString(1);
                p.Amount = rdr.GetInt32(2);
                lstProd.Add(p);
            }
            if (rdr != null)
            {
                rdr.Close();
            }
            return lstProd;
        }
        public List<Commands_has_products> GetCommandsRecap(int command_id)
        {
            List<Commands_has_products> Allcp = new List<Commands_has_products>();
            Commands_has_products cp = new Commands_has_products();
            MySqlDataReader rdr = null;
            string stm = "select concat(p.Name,' ',b.value,' ',s.value) as 'product', cp.Quantity as 'quantity', (p.amount+s.Supplement)*cp.Quantity as 'Total' " +
                "from products p, Basis b, Sizes s, commands_has_products cp " +
                "where p.id = cp.products_id " +
                "and b.id = cp.basis_id " +
                "and s.id = cp.sizes_id " +
                "and cp.commands_id = " + command_id + " ORDER BY cp.id";

            MySqlCommand cmd = new MySqlCommand(stm, conn);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                cp = new Commands_has_products();
                cp.name = rdr.GetString(0);
                cp.quantity = rdr.GetInt32(1);
                cp.TotalProduct = rdr.GetDouble(2);
                Allcp.Add(cp);
            }
            if (rdr != null)
            {
                rdr.Close();
            }
            return Allcp;

        }

        public void InsertEmploye(string FirstName, string lastName, string tel, string Email,string Address,int pizzerias_id)
        {

           

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO employees(FirstName, LastName, Tel, Email, Address,Pizzerias_id) VALUES(@F, @L, @T, @E,@A, @P)";
            cmd.Prepare();

            cmd.Parameters.AddWithValue("@F", FirstName);
            cmd.Parameters.AddWithValue("@L", lastName);
            cmd.Parameters.AddWithValue("@T", tel);
            cmd.Parameters.AddWithValue("@E", Email);
            cmd.Parameters.AddWithValue("@A", Address);
            cmd.Parameters.AddWithValue("@P", pizzerias_id);
            cmd.ExecuteNonQuery();


        }





    }
}
