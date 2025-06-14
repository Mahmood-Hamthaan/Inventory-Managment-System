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

        private void buttonOrderCreate_Click(object sender, EventArgs e)
        {
            Supplier selectedSupplier = suppliers.FirstOrDefault(s => s.Name == cmbOrderSupplier.Text);
            if (selectedSupplier == null)
            {
                MessageBox.Show("Please select a valid supplier.");
                return;
            }

            Order order = new Order
            {
                OrderID = int.Parse(txtOrderID.Text),
                Supplier = selectedSupplier,
                TotalPrice = decimal.Parse(txtOrderTotalPrice.Text),
                Status = txtOrderStatus.Text
            };

            orders.Add(order);
            MessageBox.Show("Order added successfully!");
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
    }
}
