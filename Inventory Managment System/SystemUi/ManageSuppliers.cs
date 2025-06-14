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
        private List<Supplier> suppliers = new List<Supplier>();

        public ManageSuppliers()
        {
            InitializeComponent();
        }

        private void buttonEditSupplier_Click(object sender, EventArgs e)
        {
            string supplierName = txtSupplierName.Text;
            Supplier supplier = suppliers.FirstOrDefault(s => s.Name == supplierName);

            if (supplier != null)
            {
                supplier.ContactInfo = txtContactInfo.Text;
                MessageBox.Show("Supplier updated successfully!");
                RefreshSupplierGrid();
            }
            else
            {
                MessageBox.Show("Supplier not found.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddSupplier_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier
            {
                Name = txtSupplierName.Text,
                ContactInfo = txtContactInfo.Text
            };

            suppliers.Add(supplier);
            MessageBox.Show("Supplier added successfully!");
        }

        private void buttonDeleteSupplier_Click(object sender, EventArgs e)
        {
            string supplierName = txtSupplierName.Text;
            Supplier supplier = suppliers.FirstOrDefault(s => s.Name == supplierName);

            if (supplier != null)
            {
                suppliers.Remove(supplier);
                MessageBox.Show("Supplier deleted successfully!");
                RefreshSupplierGrid();
            }
            else
            {
                MessageBox.Show("Supplier not found.");
            }
        }

        private void textBoxSupplierPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSupplierEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
