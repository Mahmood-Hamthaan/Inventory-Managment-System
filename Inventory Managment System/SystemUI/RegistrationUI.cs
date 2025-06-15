using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Inventory_Managment_System.Models;
using Inventory_Managment_System.SystemUI;

namespace Inventory_Managment_System.Forms
{
    public partial class RegistrationUI : Form
    {
        private Registration registrationLogic;

        public RegistrationUI()
        {
            InitializeComponent();

            registrationLogic = new Registration();

            // Setup role combo box options
            cmbRole.Items.Clear();
            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("Supplier");
            cmbRole.Items.Add("Customer");
            cmbRole.SelectedIndex = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text; // for now plain text
            string contact = txtContactNumber.Text.Trim();
            string role = cmbRole.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(contact))
            {
                MessageBox.Show("Please fill all the fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = registrationLogic.RegisterUser(name, username, password, contact, role);

            if (success)
            {
                // Clear fields after successful registration
                txtName.Clear();
                txtUsername.Clear();
                txtPassword.Clear();
                txtContactNumber.Clear();
                cmbRole.SelectedIndex = 0;
            }
        }

        private void textBoxRegistrationName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBacktoLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginUI loginForm = new LoginUI();
            loginForm.Show();
        }
    }
}
