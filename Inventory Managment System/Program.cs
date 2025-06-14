using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Data;
using Inventory_Managment_System.Models;
using MySql.Data.MySqlClient;

namespace Inventory_Managment_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing Inventory Management System...");

            // Initialize objects
            Product product = new Product();
            Supplier supplier = new Supplier();
            Order order = new Order();

            try
            {
                // 1. Test Supplier Class
                Console.WriteLine("\nTesting Supplier Class...");
                supplier.AddSupplier("Supplier A", "123-456-7890", "supplierA@example.com");
                Console.WriteLine("Supplier added.");

                DataTable suppliers = supplier.GetAllSuppliers();
                Console.WriteLine("All Suppliers:");
                foreach (DataRow row in suppliers.Rows)
                {
                    Console.WriteLine($"Name: {row["Name"]}, Contact Info: {row["Contact Info"]}, Email: {row["Email"]}");
                }

                supplier.UpdateSupplier("Supplier A", "987-654-3210", "updatedA@example.com");
                Console.WriteLine("Supplier updated.");

                supplier.DeleteSupplier("Supplier A");
                Console.WriteLine("Supplier deleted.");

                // 2. Test Product Class
                Console.WriteLine("\nTesting Product Class...");
                product.AddProduct("Product X", "SKU123", 50, 99.99M);
                Console.WriteLine("Product added.");

                DataTable products = product.GetAllProducts();
                Console.WriteLine("All Products:");
                foreach (DataRow row in products.Rows)
                {
                    Console.WriteLine($"Name: {row["ProductName"]}, SKU: {row["SKU"]}, Quantity: {row["Quantity"]}, Price: {row["Price"]}");
                }

                product.UpdateProduct(1, "Updated Product X", 100, 149.99M); // Assuming ProductID = 1
                Console.WriteLine("Product updated.");

                product.DeleteProduct(1);
                Console.WriteLine("Product deleted.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("\nTesting complete.");
        }
    }
}

