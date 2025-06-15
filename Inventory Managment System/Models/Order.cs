using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Inventory_Managment_System.Classes;
using System.Windows.Forms;

namespace Inventory_Managment_System.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public Supplier Supplier { get; set; }
        public List<Product> ProductList { get; set; } = new List<Product>();
        public decimal TotalPrice { get; set; }
        public string Status { get; set; }

        public void AddOrder(int productId, string customerName, int quantityOrdered)
        {
            try
            {
                // Step 1: Insert the order into the orders table
                string insertOrderQuery = "INSERT INTO orders (ProductID, CustomerName, Quantity, OrderDate) VALUES (@ProductID, @CustomerName, @Quantity, @OrderDate)";
                var parameters = new Dictionary<string, object>
        {
            {"@ProductID", productId},
            {"@CustomerName", customerName},
            {"@Quantity", quantityOrdered},
            {"@OrderDate", DateTime.Now}
        };

                new DBconnection().ExecuteQuery(insertOrderQuery, parameters);

                // Step 2: Adjust the product stock in the products table
                string updateStockQuery = "UPDATE products SET Quantity = Quantity - @Quantity WHERE ProductID = @ProductID";
                var updateParameters = new Dictionary<string, object>
        {
            {"@Quantity", quantityOrdered},
            {"@ProductID", productId}
        };

                new DBconnection().ExecuteQuery(updateStockQuery, updateParameters);

                MessageBox.Show("Order placed successfully and stock updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to place order or update stock: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable GetAllOrders()
        {
            string query = "SELECT o.OrderID, o.QuantityOrdered, o.OrderDate, p.ProductName, s.SupplierName " +
                           "FROM orders o " +
                           "JOIN products p ON o.ProductID = p.ProductID " +
                           "JOIN suppliers s ON o.SupplierID = s.SupplierID";
            return new DBconnection().GetData(query);
        }

        public void UpdateOrder(int orderId, int quantityOrdered)
        {
            string query = "UPDATE orders SET QuantityOrdered = @QuantityOrdered WHERE OrderID = @OrderID";
            var parameters = new Dictionary<string, object>
            {
                {"@OrderID", orderId},
                {"@QuantityOrdered", quantityOrdered}
            };
            new DBconnection().ExecuteQuery(query, parameters);
        }

        public void DeleteOrder(int orderId)
        {
            string query = "DELETE FROM orders WHERE OrderID = @OrderID";
            var parameters = new Dictionary<string, object>
            {
                {"@OrderID", orderId}
            };
            new DBconnection().ExecuteQuery(query, parameters);
        }
    }
}
