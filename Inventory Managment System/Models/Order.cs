using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Inventory_Managment_System.Classes;

namespace Inventory_Managment_System.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public Supplier Supplier { get; set; }
        public List<Product> ProductList { get; set; } = new List<Product>();
        public decimal TotalPrice { get; set; }
        public string Status { get; set; }

        public void AddOrder(int productId, int supplierId, int quantityOrdered)
        {
            string query = "INSERT INTO orders (ProductID, SupplierID, QuantityOrdered) VALUES (@ProductID, @SupplierID, @QuantityOrdered)";
            var parameters = new Dictionary<string, object>
            {
                {"@ProductID", productId},
                {"@SupplierID", supplierId},
                {"@QuantityOrdered", quantityOrdered}
            };
            new DBconnection().ExecuteQuery(query, parameters);
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
