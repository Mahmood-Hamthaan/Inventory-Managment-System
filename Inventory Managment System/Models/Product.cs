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
    public class Product
    {
        public string Name { get; set; }
        public string SKU { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public void AddProduct(string productName, string sku, int quantity, decimal price)
        {
            string query = "INSERT INTO products (ProductName, SKU, Quantity, Price) VALUES (@ProductName, @SKU, @Quantity, @Price)";
            var parameters = new Dictionary<string, object>
            {
                {"@ProductName", productName},
                {"@SKU", sku},
                {"@Quantity", quantity},
                {"@Price", price}
            };
            new DBconnection().ExecuteQuery(query, parameters);
        }

        public void UpdateProduct(int productId, string productName, int quantity, decimal price)
        {
            string query = "UPDATE products SET ProductName = @ProductName, Quantity = @Quantity, Price = @Price WHERE ProductID = @ProductID";
            var parameters = new Dictionary<string, object>
            {
                {"@ProductID", productId},
                {"@ProductName", productName},
                {"@Quantity", quantity},
                {"@Price", price}
            };
            new DBconnection().ExecuteQuery(query, parameters);
        }


        public void DeleteProduct(int productId)
        {
            string query = "DELETE FROM products WHERE ProductID = @ProductID";
            var parameters = new Dictionary<string, object>
                {
                    {"@ProductID", productId}
                };
            new DBconnection().ExecuteQuery(query, parameters);
        }


        public void ViewProduct()
        {
            // Logic to view product
            Console.WriteLine($"Product: {Name}, SKU: {SKU}, Quantity: {Quantity}, Price: {Price}");
        }

        public DataTable GetAllProducts()
        {
            string query = "SELECT * FROM products";
            return new DBconnection().GetData(query);
        }
    }
}
