using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_Managment_System.Forms;
using Inventory_Managment_System.SystemUI;

namespace Inventory_Managment_System.SystemUi
{
    public partial class SupplierDashboardUI: Form
    {
        public SupplierDashboardUI()
        {
            InitializeComponent();
        }

        private void buttonSupplerManageProdect_Click(object sender, EventArgs e)
        {
            ManageProducts manageProductsForm = new ManageProducts();
            manageProductsForm.ShowDialog();
        }

        private void BtnStockMovement_Click(object sender, EventArgs e)
        {
            StockMovementUI stockMovementForm = new StockMovementUI();
            stockMovementForm.ShowDialog();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginUI loginForm = new LoginUI();
            loginForm.Show();
        }
    }
}
