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
using Inventory_Managment_System.Classes;

namespace Inventory_Managment_System.SystemUI
{
    public partial class PlaceOrderUI : Form
    {
        public string LoggedInCustomerName { get; set; }

        public PlaceOrderUI()
        {
            InitializeComponent();
            LoadAvailableProducts();
        }



        private void BtnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (dataGridView2.DataSource == null || ((DataTable)dataGridView2.DataSource).Rows.Count == 0)
            {
                MessageBox.Show("No products added to the order.", "Order Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable orderItems = (DataTable)dataGridView2.DataSource;
            bool allSuccess = true;

            foreach (DataRow row in orderItems.Rows)
            {
                try
                {
                    int productId = Convert.ToInt32(row["ProductID"]);
                    int quantityOrdered = Convert.ToInt32(row["Quantity"]);

                    // Create and save the order
                    Order order = new Order();
                    order.AddOrder(productId, LoggedInCustomerName, quantityOrdered);
                }
                catch (Exception ex)
                {
                    allSuccess = false;
                    MessageBox.Show($"Failed to place order for product {row["ProductName"]}: {ex.Message}", "Order Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (allSuccess)
            {
                MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView2.DataSource = null;  // Clear the order grid
                LoadAvailableProducts();         // Refresh available products
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridView1.Rows[e.RowIndex];

                // Initialize order grid DataTable if null
                DataTable dt = dataGridView2.DataSource as DataTable ?? CreateOrderTable();

                int productId = Convert.ToInt32(selectedRow.Cells["ProductID"].Value);
                string productName = selectedRow.Cells["ProductName"].Value.ToString();
                decimal price = Convert.ToDecimal(selectedRow.Cells["Price"].Value);
                int availableQuantity = Convert.ToInt32(selectedRow.Cells["Quantity"].Value);

                // Check if product is already added
                var existingRow = dt.AsEnumerable().FirstOrDefault(r => r.Field<int>("ProductID") == productId);
                if (existingRow != null)
                {
                    int newQuantity = (int)existingRow["Quantity"] + 1;
                    if (newQuantity > availableQuantity)
                    {
                        MessageBox.Show($"Only {availableQuantity} units available for {productName}.", "Stock Limit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    existingRow["Quantity"] = newQuantity;
                    existingRow["Total"] = newQuantity * price;
                }
                else
                {
                    dt.Rows.Add(productId, productName, 1, price, price);
                }

                dataGridView2.DataSource = dt;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private DataTable CreateOrderTable()
        {
            var dt = new DataTable();
            dt.Columns.Add("ProductID", typeof(int));
            dt.Columns.Add("ProductName", typeof(string));
            dt.Columns.Add("Quantity", typeof(int));
            dt.Columns.Add("Price", typeof(decimal));
            dt.Columns.Add("Total", typeof(decimal));
            return dt;
        }

        private void LoadAvailableProducts()
        {
            string query = "SELECT ProductID, ProductName, SKU, Quantity, Price FROM products WHERE Quantity > 0";
            DataTable products = new DBconnection().GetData(query);

            dataGridView1.DataSource = products;
            dataGridView1.Columns["ProductID"].Visible = false; // Hide ProductID
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Set column headers
            dataGridView1.Columns["ProductName"].HeaderText = "Product Name";
            dataGridView1.Columns["SKU"].HeaderText = "SKU";
            dataGridView1.Columns["Quantity"].HeaderText = "Available Stock";
            dataGridView1.Columns["Price"].HeaderText = "Price (USD)";
        }


    }
}
