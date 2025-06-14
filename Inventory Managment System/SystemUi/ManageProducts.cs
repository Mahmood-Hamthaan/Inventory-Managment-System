using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Inventory_Managment_System.Models; // Ensure your Product class is in this namespace.

namespace Inventory_Managment_System.Forms
{
    public partial class ManageProducts : Form
    {
        public ManageProducts()
        {
            InitializeComponent();
        }

        // Add Product
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new product and add to the database
                Product product = new Product
                {
                    Name = textName.Text,
                    SKU = textSKU.Text,
                    Quantity = int.Parse(textQuantity.Text),
                    Price = decimal.Parse(textPrice.Text)
                };

                product.AddProduct(product.Name, product.SKU, product.Quantity, product.Price);
                MessageBox.Show("Product added successfully!");

                // Refresh the product list
                RefreshProductGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding product: {ex.Message}");
            }
        }

        // Edit Product
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int productId = int.Parse(textProductID.Text);
                string name = textName.Text;
                int quantity = int.Parse(textQuantity.Text);
                decimal price = decimal.Parse(textPrice.Text);

                Product product = new Product();
                product.UpdateProduct(productId, name, quantity, price);

                MessageBox.Show("Product updated successfully!");

                // Refresh the product list
                RefreshProductGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating product: {ex.Message}");
            }
        }

        // Delete Product
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int productId = int.Parse(textProductID.Text);

                Product product = new Product();
                product.DeleteProduct(productId);

                MessageBox.Show("Product deleted successfully!");

                // Refresh the product list
                RefreshProductGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting product: {ex.Message}");
            }
        }

        // View Products
        private void buttonView_Click(object sender, EventArgs e)
        {
            RefreshProductGrid();
        }

        // Refresh Product DataGridView
        private void RefreshProductGrid()
        {
            try
            {
                Product product = new Product();
                DataTable productData = product.GetAllProducts();

                dataGridViewProducts.DataSource = productData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}");
            }
        }

        // Form Load Event
        private void ManageProducts_Load(object sender, EventArgs e)
        {
            RefreshProductGrid();
        }

        // Other event handlers can remain as placeholders
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void labelSupplier_Click(object sender, EventArgs e)
        {

        }
    }
}
