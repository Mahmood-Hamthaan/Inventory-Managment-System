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
using Inventory_Managment_System.SystemUi;
using Inventory_Managment_System;

namespace Inventory_Managment_System.SystemUI
{
    public partial class LoginUI: Form
    {
        private Login loginLogic;

        public LoginUI()
        {
            InitializeComponent();
            loginLogic = new Login();   
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string selectedRole = cmbRole.SelectedItem.ToString();

            var result = loginLogic.Authenticate(username, password, selectedRole);

            if (result.IsValid)
            {
                MessageBox.Show(result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RedirectToDashboard(selectedRole);
            }
            else
            {
                MessageBox.Show(result.Message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RedirectToDashboard(string role)
        {
            Form dashboard = null;

            if (role == "Admin")
            {
                AdminDashboardUI adminDashboard = new AdminDashboardUI();
                adminDashboard.Show();
                this.Hide();
            }
            else if (role == "Supplier")
            {
                SupplierDashboardUI supplierDashboard = new SupplierDashboardUI();
                supplierDashboard.Show();
                this.Hide();
            }
            else if (role == "Customer")
            {
                CustomerDashboardUI customerDashboard = new CustomerDashboardUI();
                customerDashboard.Show();
                this.Hide();
            }

            if (dashboard != null)
            {
                this.Hide();
                dashboard.ShowDialog();
                this.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
