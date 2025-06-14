using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory_Managment_System;
using Inventory_Managment_System.Models;

namespace Test1
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

                // 3. Test Order Class
                Console.WriteLine("\nTesting Order Class...");
                order.AddOrder(123, 1, 10); // Assuming ProductID = 1
                Console.WriteLine("Order added.");

                DataTable orders = order.GetAllOrders();
                Console.WriteLine("All Orders:");
                foreach (DataRow row in orders.Rows)
                {
                    Console.WriteLine($"OrderID: {row["OrderID"]}, Supplier: {row["SupplierName"]}, Product: {row["ProductName"]}, Quantity: {row["QuantityOrdered"]}");
                }

                order.UpdateOrder(1, 20); // Assuming OrderID = 1
                Console.WriteLine("Order updated.");

                order.DeleteOrder(1);
                Console.WriteLine("Order deleted.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("\nTesting complete.");
        }

    }
    
}
