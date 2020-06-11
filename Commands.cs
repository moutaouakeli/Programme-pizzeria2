using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programme_pizzeria2
{
    public class Commands
    {

		public static int command_id;
		public static int command_sup=0;
		public Commands()
		{
			DBconnection db = new DBconnection();
			command_id = db.createCommands();
			command_sup = 0;
			frmPizza frmPizza = new frmPizza();
			frmPizza.Show();
			
		}

		private int number;

		public int Number
		{
			get { return number; }
			set { number = value; }
		}

		private DateTime dateOrder;

		public DateTime DateOrder
		{
			get { return dateOrder; }
			set { dateOrder = value; }
		}


	}
}
