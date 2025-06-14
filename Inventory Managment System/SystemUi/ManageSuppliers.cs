using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_Managment_System.Models;

namespace Inventory_Managment_System.Forms
{
    public partial class ManageSuppliers : Form
    {
        public ManageSuppliers()
        {
            InitializeComponent();
        }

        // Add Supplier
        private void buttonAddSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                Supplier supplier = new Supplier();
                supplier.AddSupplier(
                    txtSupplierName.Text,
                    txtContactInfo.Text,
                    txtSupplierEmail.Text
                );
                MessageBox.Show("Supplier added successfully!");
                RefreshSupplierGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding supplier: {ex.Message}");
            }
        }

        // Edit Supplier
        private void buttonEditSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                string supplierName = txtSupplierName.Text;
                Supplier supplier = new Supplier();
                supplier.UpdateSupplier(
                    supplierName,
                    txtContactInfo.Text,
                    txtSupplierEmail.Text
                );
                MessageBox.Show("Supplier updated successfully!");
                RefreshSupplierGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating supplier: {ex.Message}");
            }
        }

        // Delete Supplier
        private void buttonDeleteSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                string supplierName = txtSupplierName.Text;
                Supplier supplier = new Supplier();
                supplier.DeleteSupplier(supplierName);
                MessageBox.Show("Supplier deleted successfully!");
                RefreshSupplierGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting supplier: {ex.Message}");
            }
        }

        // Refresh Supplier Grid
        private void RefreshSupplierGrid()
        {
            try
            {
                Supplier supplier = new Supplier();
                DataTable supplierData = supplier.GetAllSuppliers();
                dataGridViewSuppliers.DataSource = supplierData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading suppliers: {ex.Message}");
            }
        }

        // Form Load Event
        private void ManageSuppliers_Load(object sender, EventArgs e)
        {
            RefreshSupplierGrid();
        }

        // Other Event Placeholders
        private void textBoxSupplierPhone_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxSupplierEmail_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridViewSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
