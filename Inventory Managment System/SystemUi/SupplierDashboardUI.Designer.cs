namespace Inventory_Managment_System.SystemUi
{
    partial class SupplierDashboardUI
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
            this.labelSupplierDashboard = new System.Windows.Forms.Label();
            this.BtnStockMovement = new System.Windows.Forms.Button();
            this.BtnManageProducts = new System.Windows.Forms.Button();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSupplierDashboard
            // 
            this.labelSupplierDashboard.AutoSize = true;
            this.labelSupplierDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelSupplierDashboard.Location = new System.Drawing.Point(226, 46);
            this.labelSupplierDashboard.Name = "labelSupplierDashboard";
            this.labelSupplierDashboard.Size = new System.Drawing.Size(246, 29);
            this.labelSupplierDashboard.TabIndex = 1;
            this.labelSupplierDashboard.Text = "Supplier Dashboard";
            // 
            // BtnStockMovement
            // 
            this.BtnStockMovement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStockMovement.Location = new System.Drawing.Point(374, 142);
            this.BtnStockMovement.Name = "BtnStockMovement";
            this.BtnStockMovement.Size = new System.Drawing.Size(188, 33);
            this.BtnStockMovement.TabIndex = 3;
            this.BtnStockMovement.Text = "StockMovement";
            this.BtnStockMovement.UseVisualStyleBackColor = true;
            this.BtnStockMovement.Click += new System.EventHandler(this.BtnStockMovement_Click);
            // 
            // BtnManageProducts
            // 
            this.BtnManageProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManageProducts.Location = new System.Drawing.Point(109, 142);
            this.BtnManageProducts.Name = "BtnManageProducts";
            this.BtnManageProducts.Size = new System.Drawing.Size(188, 33);
            this.BtnManageProducts.TabIndex = 4;
            this.BtnManageProducts.Text = "Manage Products";
            this.BtnManageProducts.UseVisualStyleBackColor = true;
            this.BtnManageProducts.Click += new System.EventHandler(this.buttonSupplerManageProdect_Click);
            // 
            // BtnLogout
            // 
            this.BtnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.BtnLogout.Location = new System.Drawing.Point(281, 233);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(85, 36);
            this.BtnLogout.TabIndex = 5;
            this.BtnLogout.Text = "Logout";
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // SupplierDashboardUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 327);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.BtnManageProducts);
            this.Controls.Add(this.BtnStockMovement);
            this.Controls.Add(this.labelSupplierDashboard);
            this.Name = "SupplierDashboardUI";
            this.Text = "SupplierDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSupplierDashboard;
        private System.Windows.Forms.Button BtnStockMovement;
        private System.Windows.Forms.Button BtnManageProducts;
        private System.Windows.Forms.Button BtnLogout;
    }
}