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
    public class Supplier
    {
        public string Name { get; set; }
        public string ContactInfo { get; set; }
        public string Email { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();

        // Add Supplier
        public void AddSupplier(string name, string contactInfo, string email)
        {
            string query = "INSERT INTO suppliers (SupplierName, ContactInfo, Email) VALUES (@SupplierName, @ContactInfo, @Email)";
            var parameters = new Dictionary<string, object>
            {
                {"@SupplierName", name},
                {"@ContactInfo", contactInfo},
                {"@Email", email}
            };
            new DBconnection().ExecuteQuery(query, parameters);
        }

        // Update Supplier
        public void UpdateSupplier(string name, string contactInfo, string email)
        {
            string query = "UPDATE suppliers SET ContactInfo = @ContactInfo, Email = @Email WHERE SupplierName = @SupplierName";
            var parameters = new Dictionary<string, object>
            {
                {"@SupplierName", name},
                {"@ContactInfo", contactInfo},
                {"@Email", email}
            };
            new DBconnection().ExecuteQuery(query, parameters);
        }

        // Delete Supplier
        public void DeleteSupplier(string name)
        {
            string query = "DELETE FROM suppliers WHERE SupplierName = @SupplierName";
            var parameters = new Dictionary<string, object>
            {
                {"@SupplierName", name}
            };
            new DBconnection().ExecuteQuery(query, parameters);
        }

        // Load Products for a Supplier
        public void LoadProducts()
        {
            string query = "SELECT * FROM products WHERE SupplierName = @SupplierName";
            var parameters = new Dictionary<string, object>
            {
                {"@SupplierName", Name}
            };

            DataTable productData = new DBconnection().GetData(query, parameters);

            Products.Clear(); // Clear the current list to avoid duplicates
            foreach (DataRow row in productData.Rows)
            {
                Products.Add(new Product
                {
                    Name = row["ProductName"].ToString(),
                    SKU = row["SKU"].ToString(),
                    Quantity = Convert.ToInt32(row["Quantity"]),
                    Price = Convert.ToDecimal(row["Price"])
                });
            }
        }

        public DataTable GetAllSuppliers()
        {
            try
            {
                string query = "SELECT SupplierName AS 'Name', ContactInfo AS 'Contact Info', Email AS 'Email' FROM suppliers";
                return new DBconnection().GetData(query);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving suppliers: {ex.Message}");
            }
        }
    }
}
