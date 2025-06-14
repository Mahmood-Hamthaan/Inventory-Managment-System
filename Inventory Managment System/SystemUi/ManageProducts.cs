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
                Name = textName.Text,
                SKU = textQuantity.Text,
                Quantity = int.Parse(textQuantity.Text),
                Price = decimal.Parse(textPrice.Text)
            };

            product.AddProduct();
            MessageBox.Show("Product added successfully!");
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string sku = textSKU.Text;
            Product product = products.FirstOrDefault(p => p.SKU == sku);

            if (product != null)
            {
                product.Name = textName.Text;
                product.Quantity = int.Parse(textQuantity.Text);
                product.Price = decimal.Parse(textPrice.Text);
                MessageBox.Show("Product updated successfully!");
            }
            else
            {
                MessageBox.Show("Product not found.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string sku = textSKU.Text;
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

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
