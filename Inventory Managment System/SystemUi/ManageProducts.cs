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
using System.Xml.Linq;

namespace Inventory_Managment_System.Forms
{
    public partial class ManageProducts : Form
    {


        public ManageProducts()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Name = txtName.Text,
                SKU = txtSKU.Text,
                Quantity = int.Parse(txtQuantity.Text),
                Price = decimal.Parse(txtPrice.Text)
            };

            product.AddProduct();
            MessageBox.Show("Product added successfully!");
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string sku = txtSKU.Text;
            Product product = products.FirstOrDefault(p => p.SKU == sku);

            if (product != null)
            {
                product.Name = txtName.Text;
                product.Quantity = int.Parse(txtQuantity.Text);
                product.Price = decimal.Parse(txtPrice.Text);
                MessageBox.Show("Product updated successfully!");
            }
            else
            {
                MessageBox.Show("Product not found.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string sku = txtSKU.Text;
            Product product = products.FirstOrDefault(p => p.SKU == sku);

            if (product != null)
            {
                products.Remove(product);
                MessageBox.Show("Product deleted successfully!");
            }
            else
            {
                MessageBox.Show("Product not found.");
            }
        }

        private void buttonView_Click(object sender, EventArgs e)
        {

        }

        private void ManageProducts_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }

}
