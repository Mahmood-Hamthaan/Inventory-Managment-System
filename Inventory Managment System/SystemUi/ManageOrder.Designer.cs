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
            this.buttonCreateOrder = new System.Windows.Forms.Button();
            this.buttonDeleteOrder = new System.Windows.Forms.Button();
            this.labelManageOrder = new System.Windows.Forms.Label();
            this.dataGridViewManageOrder = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonCreateOrder.Location = new System.Drawing.Point(203, 102);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(127, 36);
            this.buttonCreateOrder.TabIndex = 36;
            this.buttonCreateOrder.Text = "Create";
            this.buttonCreateOrder.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteOrder
            // 
            this.buttonDeleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonDeleteOrder.Location = new System.Drawing.Point(426, 102);
            this.buttonDeleteOrder.Name = "buttonDeleteOrder";
            this.buttonDeleteOrder.Size = new System.Drawing.Size(127, 36);
            this.buttonDeleteOrder.TabIndex = 35;
            this.buttonDeleteOrder.Text = "Delete";
            this.buttonDeleteOrder.UseVisualStyleBackColor = true;
            // 
            // labelManageOrder
            // 
            this.labelManageOrder.AutoSize = true;
            this.labelManageOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelManageOrder.Location = new System.Drawing.Point(266, 31);
            this.labelManageOrder.Name = "labelManageOrder";
            this.labelManageOrder.Size = new System.Drawing.Size(181, 29);
            this.labelManageOrder.TabIndex = 34;
            this.labelManageOrder.Text = "Manage Order";
            // 
            // dataGridViewManageOrder
            // 
            this.dataGridViewManageOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManageOrder.Location = new System.Drawing.Point(157, 189);
            this.dataGridViewManageOrder.Name = "dataGridViewManageOrder";
            this.dataGridViewManageOrder.RowHeadersWidth = 51;
            this.dataGridViewManageOrder.RowTemplate.Height = 24;
            this.dataGridViewManageOrder.Size = new System.Drawing.Size(411, 150);
            this.dataGridViewManageOrder.TabIndex = 37;
            // 
            // ManageOrder
            // 
            this.ClientSize = new System.Drawing.Size(810, 405);
            this.Controls.Add(this.dataGridViewManageOrder);
            this.Controls.Add(this.buttonCreateOrder);
            this.Controls.Add(this.buttonDeleteOrder);
            this.Controls.Add(this.labelManageOrder);
            this.Name = "ManageOrder";
            this.Load += new System.EventHandler(this.ManageOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button buttonCreateOrder;
        private System.Windows.Forms.Button buttonDeleteOrder;
        private System.Windows.Forms.Label labelManageOrder;
        private System.Windows.Forms.DataGridView dataGridViewManageOrder;
    }
}