using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_Managment_System.Models;
using MySql.Data.MySqlClient;
using Inventory_Managment_System.Classes;

namespace Inventory_Managment_System.SystemUi
{
    public partial class ManageOrder : Form
    {
        public ManageOrder()
        {
            InitializeComponent();
        }

        private List<Order> orders = new List<Order>();

        private void labelPurchaseOrder_Click(object sender, EventArgs e)
        {

        }

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

        private void buttonOrderUpdate_Click(object sender, EventArgs e)
        {
            int orderId = int.Parse(txtOrderID.Text);
            Order order = orders.FirstOrDefault(o => o.OrderID == orderId);

            if (order != null)
            {
                order.TotalPrice = decimal.Parse(txtOrderTotalPrice.Text);
                order.Status = txtOrderStatus.Text;

                MessageBox.Show("Order updated successfully!");
            }
            else
            {
                MessageBox.Show("Order not found.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            dgvOrders.DataSource = null;
            dgvOrders.DataSource = orders.Select(o => new
            {
                o.OrderID,
                SupplierName = o.Supplier.Name,
                o.TotalPrice,
                o.Status
            }).ToList();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int orderId = int.Parse(txtOrderID.Text);
            Order order = orders.FirstOrDefault(o => o.OrderID == orderId);

            if (order != null)
            {
                orders.Remove(order);
                MessageBox.Show("Order deleted successfully!");
            }
            else
            {
                MessageBox.Show("Order not found.");
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOrderTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManageOrder_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewManageOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
