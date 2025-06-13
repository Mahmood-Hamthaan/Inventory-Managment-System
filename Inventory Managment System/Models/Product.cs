using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment_System.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string SKU { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public void AddProduct()
        {
            // Logic to add product
            Console.WriteLine("Product added.");
        }

        public void UpdateProduct()
        {
            // Logic to update product
            Console.WriteLine("Product updated.");
        }

        public void DeleteProduct()
        {
            // Logic to delete product
            Console.WriteLine("Product deleted.");
        }

        public void ViewProduct()
        {
            // Logic to view product
            Console.WriteLine($"Product: {Name}, SKU: {SKU}, Quantity: {Quantity}, Price: {Price}");
        }
    }
}
