using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Inventory_Managment_System.Models;
using MySql.Data.MySqlClient;
using Inventory_Managment_System.SystemUI;
using Inventory_Managment_System.Forms;
using Inventory_Managment_System.SystemUi;



namespace Inventory_Managment_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginUI());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AdminDashboardUI());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SupplierDashboardUI());
        }

    }
}
