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
    public partial class LoginUI : Form
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
            string selectedRole = cmbRole.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrEmpty(selectedRole))
            {
                MessageBox.Show("Please fill in all fields and select a role.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = loginLogic.Authenticate(username, password, selectedRole);

            if (result.IsValid)
            {
                MessageBox.Show(result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RedirectToDashboard(selectedRole, username);
            }
            else
            {
                MessageBox.Show(result.Message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RedirectToDashboard(string role, string username)
        {
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
                PlaceOrderUI placeOrderForm = new PlaceOrderUI
                {
                    LoggedInCustomerName = username
                };
                placeOrderForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid role selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Placeholder for handling text change if needed
        }
    }
}
