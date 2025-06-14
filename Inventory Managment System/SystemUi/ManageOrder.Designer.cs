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
            this.labelManageOrders = new System.Windows.Forms.Label();
            this.buttonOrderCreate = new System.Windows.Forms.Button();
            this.buttonOrderUpdate = new System.Windows.Forms.Button();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.labelPurchaseOrder = new System.Windows.Forms.Label();
            this.viewButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtOrderTotalPrice = new System.Windows.Forms.TextBox();
            this.txtOrderStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // labelManageOrders
            // 
            this.labelManageOrders.AutoSize = true;
            this.labelManageOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelManageOrders.Location = new System.Drawing.Point(191, 9);
            this.labelManageOrders.Name = "labelManageOrders";
            this.labelManageOrders.Size = new System.Drawing.Size(181, 29);
            this.labelManageOrders.TabIndex = 19;
            this.labelManageOrders.Text = "Manage Order";
            // 
            // buttonOrderCreate
            // 
            this.buttonOrderCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonOrderCreate.Location = new System.Drawing.Point(28, 271);
            this.buttonOrderCreate.Name = "buttonOrderCreate";
            this.buttonOrderCreate.Size = new System.Drawing.Size(121, 36);
            this.buttonOrderCreate.TabIndex = 20;
            this.buttonOrderCreate.Text = "Create";
            this.buttonOrderCreate.UseVisualStyleBackColor = true;
            this.buttonOrderCreate.Click += new System.EventHandler(this.buttonOrderCreate_Click);
            // 
            // buttonOrderUpdate
            // 
            this.buttonOrderUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonOrderUpdate.Location = new System.Drawing.Point(164, 271);
            this.buttonOrderUpdate.Name = "buttonOrderUpdate";
            this.buttonOrderUpdate.Size = new System.Drawing.Size(121, 36);
            this.buttonOrderUpdate.TabIndex = 21;
            this.buttonOrderUpdate.Text = "Update";
            this.buttonOrderUpdate.UseVisualStyleBackColor = true;
            this.buttonOrderUpdate.Click += new System.EventHandler(this.buttonOrderUpdate_Click);
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(28, 338);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.Size = new System.Drawing.Size(521, 150);
            this.dgvOrders.TabIndex = 22;
            this.dgvOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellContentClick);
            // 
            // labelPurchaseOrder
            // 
            this.labelPurchaseOrder.AutoSize = true;
            this.labelPurchaseOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPurchaseOrder.Location = new System.Drawing.Point(23, 310);
            this.labelPurchaseOrder.Name = "labelPurchaseOrder";
            this.labelPurchaseOrder.Size = new System.Drawing.Size(187, 25);
            this.labelPurchaseOrder.TabIndex = 23;
            this.labelPurchaseOrder.Text = "Purchased Orders";
            this.labelPurchaseOrder.Click += new System.EventHandler(this.labelPurchaseOrder_Click);
            // 
            // viewButton
            // 
            this.viewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.viewButton.Location = new System.Drawing.Point(291, 272);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(121, 36);
            this.viewButton.TabIndex = 24;
            this.viewButton.Text = "View";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.deleteButton.Location = new System.Drawing.Point(428, 271);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(121, 36);
            this.deleteButton.TabIndex = 25;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(352, 72);
            this.txtOrderID.Multiline = true;
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(197, 34);
            this.txtOrderID.TabIndex = 26;
            this.txtOrderID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtOrderTotalPrice
            // 
            this.txtOrderTotalPrice.Location = new System.Drawing.Point(352, 129);
            this.txtOrderTotalPrice.Multiline = true;
            this.txtOrderTotalPrice.Name = "txtOrderTotalPrice";
            this.txtOrderTotalPrice.Size = new System.Drawing.Size(197, 34);
            this.txtOrderTotalPrice.TabIndex = 27;
            this.txtOrderTotalPrice.TextChanged += new System.EventHandler(this.txtOrderTotalPrice_TextChanged);
            // 
            // txtOrderStatus
            // 
            this.txtOrderStatus.Location = new System.Drawing.Point(352, 182);
            this.txtOrderStatus.Multiline = true;
            this.txtOrderStatus.Name = "txtOrderStatus";
            this.txtOrderStatus.Size = new System.Drawing.Size(197, 34);
            this.txtOrderStatus.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(36, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "OrderID : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(36, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Total Price :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(36, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Order Status :";
            // 
            // ManageOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 524);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOrderStatus);
            this.Controls.Add(this.txtOrderTotalPrice);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.labelPurchaseOrder);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.buttonOrderUpdate);
            this.Controls.Add(this.buttonOrderCreate);
            this.Controls.Add(this.labelManageOrders);
            this.Name = "ManageOrder";
            this.Text = "Manage Order";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
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
    }
}