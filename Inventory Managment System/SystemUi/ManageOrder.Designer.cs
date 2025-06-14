namespace Inventory_Managment_System.SystemUi
{
    partial class ManageOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ManageOrder
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "ManageOrder";
            this.Load += new System.EventHandler(this.ManageOrder_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelManageOrders;
        private System.Windows.Forms.Button buttonOrderCreate;
        private System.Windows.Forms.Button buttonOrderUpdate;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Label labelPurchaseOrder;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtOrderTotalPrice;
        private System.Windows.Forms.TextBox txtOrderStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}