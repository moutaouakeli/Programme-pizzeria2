using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programme_pizzeria2
{
    public class Products
    {

        public Products(String n, Double a)
        {
            Name = n;
            Amount = a;
        }

        public Products()
        {
        }

        public int Id;

        public int id
        {
            get { return Id; }
            set { Id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private double amount;

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }




    }
}
