using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment_System.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public Supplier Supplier { get; set; }
        public List<Product> ProductList { get; set; } = new List<Product>();
        public decimal TotalPrice { get; set; }
        public string Status { get; set; }

        public void CreateOrder()
        {
            // Logic to create order
            Console.WriteLine("Order created.");
        }

        public void ViewOrder()
        {
            // Logic to view order
            Console.WriteLine($"Order ID: {OrderID}, Supplier: {Supplier.Name}, Total Price: {TotalPrice}, Status: {Status}");
        }
    }
}
