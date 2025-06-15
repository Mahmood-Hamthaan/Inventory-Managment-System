using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_Managment_System.SystemUi;
using Inventory_Managment_System.SystemUI;

namespace Inventory_Managment_System.Forms
{
    public partial class AdminDashboardUI : Form
    {
        public AdminDashboardUI()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageSuppliers manageSupplier = new ManageSuppliers();
            manageSupplier.Show();
            this.Hide();
        }

        private void btnManageOrders_Click(object sender, EventArgs e)
        {
            ManageOrder manageOrder = new ManageOrder();
            manageOrder.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginUI loginUI = new LoginUI();
            loginUI.Show();
            this.Close();
        }

        private void btnManageProducts_Click(object sender, EventArgs e)
        {
            ManageProducts manageProducts = new ManageProducts();
            manageProducts.Show();
            this.Hide();
        }

        private void btnRegisterUsers_Click(object sender, EventArgs e)
        {
            RegistrationUI registrationUI = new RegistrationUI();
            registrationUI.Show();
            this.Hide();
        }
    }
}
