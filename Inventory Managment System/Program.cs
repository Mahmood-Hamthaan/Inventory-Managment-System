using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Inventory_Managment_System.Models;
using MySql.Data.MySqlClient;



namespace Inventory_Managment_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing Product Class...");

            // Initialize the Product object
            Product product = new Product();

            try
            {
                // 1. Add Product
                Console.WriteLine("\nAdding a new product...");
                product.AddProduct("Test Product", "SKU001", 10, 99.99M);
                Console.WriteLine("Product added successfully.");

                // 2. Retrieve and Display All Products
                Console.WriteLine("\nRetrieving all products...");
                DataTable products = product.GetAllProducts();
                foreach (DataRow row in products.Rows)
                {
                    Console.WriteLine($"ID: {row["ProductID"]}, Name: {row["ProductName"]}, SKU: {row["SKU"]}, Quantity: {row["Quantity"]}, Price: {row["Price"]}");
                }

                // Assuming a product with ID = 1 exists (change this ID based on your database)
                int testProductId = 1;

                // 3. Update Product
                Console.WriteLine("\nUpdating product...");
                product.UpdateProduct(testProductId, "Updated Product", 20, 149.99M);
                Console.WriteLine("Product updated successfully.");

                // 4. Delete Product
                Console.WriteLine("\nDeleting product...");
                product.DeleteProduct(testProductId);
                Console.WriteLine("Product deleted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("\nProduct testing complete.");
        }
    }
}