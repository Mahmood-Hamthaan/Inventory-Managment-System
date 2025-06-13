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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelPurchaseOrder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelManageOrders
            // 
            this.labelManageOrders.AutoSize = true;
            this.labelManageOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelManageOrders.Location = new System.Drawing.Point(156, 45);
            this.labelManageOrders.Name = "labelManageOrders";
            this.labelManageOrders.Size = new System.Drawing.Size(181, 29);
            this.labelManageOrders.TabIndex = 19;
            this.labelManageOrders.Text = "Manage Order";
            // 
            // buttonOrderCreate
            // 
            this.buttonOrderCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonOrderCreate.Location = new System.Drawing.Point(37, 119);
            this.buttonOrderCreate.Name = "buttonOrderCreate";
            this.buttonOrderCreate.Size = new System.Drawing.Size(184, 36);
            this.buttonOrderCreate.TabIndex = 20;
            this.buttonOrderCreate.Text = "Create";
            this.buttonOrderCreate.UseVisualStyleBackColor = true;
            // 
            // buttonOrderUpdate
            // 
            this.buttonOrderUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonOrderUpdate.Location = new System.Drawing.Point(256, 119);
            this.buttonOrderUpdate.Name = "buttonOrderUpdate";
            this.buttonOrderUpdate.Size = new System.Drawing.Size(184, 36);
            this.buttonOrderUpdate.TabIndex = 21;
            this.buttonOrderUpdate.Text = "Update";
            this.buttonOrderUpdate.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(403, 150);
            this.dataGridView1.TabIndex = 22;
            // 
            // labelPurchaseOrder
            // 
            this.labelPurchaseOrder.AutoSize = true;
            this.labelPurchaseOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPurchaseOrder.Location = new System.Drawing.Point(39, 194);
            this.labelPurchaseOrder.Name = "labelPurchaseOrder";
            this.labelPurchaseOrder.Size = new System.Drawing.Size(164, 25);
            this.labelPurchaseOrder.TabIndex = 23;
            this.labelPurchaseOrder.Text = "Purchase Order";
            // 
            // ManageOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 442);
            this.Controls.Add(this.labelPurchaseOrder);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonOrderUpdate);
            this.Controls.Add(this.buttonOrderCreate);
            this.Controls.Add(this.labelManageOrders);
            this.Name = "ManageOrder";
            this.Text = "Manage Order";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelManageOrders;
        private System.Windows.Forms.Button buttonOrderCreate;
        private System.Windows.Forms.Button buttonOrderUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelPurchaseOrder;
    }
}