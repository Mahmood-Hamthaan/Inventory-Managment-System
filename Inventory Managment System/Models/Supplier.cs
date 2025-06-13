using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment_System.Models
{
    public class Supplier
    {
        public string Name { get; set; }
        public string ContactInfo { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();

        public void AddSupplier()
        {
            // Logic to add supplier
            Console.WriteLine("Supplier added.");
        }

        public void UpdateSupplier()
        {
            // Logic to update supplier
            Console.WriteLine("Supplier updated.");
        }

        public void DeleteSupplier()
        {
            // Logic to delete supplier
            Console.WriteLine("Supplier deleted.");
        }

        public void ViewSupplier()
        {
            // Logic to view supplier
            Console.WriteLine($"Supplier: {Name}, Contact Info: {ContactInfo}, Number of Products: {Products.Count}");
        }
    }
}
