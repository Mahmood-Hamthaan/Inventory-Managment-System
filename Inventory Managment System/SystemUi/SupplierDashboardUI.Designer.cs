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
            this.buttonSupplierStockMovement = new System.Windows.Forms.Button();
            this.buttonSupplerManageProdect = new System.Windows.Forms.Button();
            this.buttonSupplerLogout = new System.Windows.Forms.Button();
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
            // buttonSupplierStockMovement
            // 
            this.buttonSupplierStockMovement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupplierStockMovement.Location = new System.Drawing.Point(374, 142);
            this.buttonSupplierStockMovement.Name = "buttonSupplierStockMovement";
            this.buttonSupplierStockMovement.Size = new System.Drawing.Size(188, 33);
            this.buttonSupplierStockMovement.TabIndex = 3;
            this.buttonSupplierStockMovement.Text = "StockMovement";
            this.buttonSupplierStockMovement.UseVisualStyleBackColor = true;
            // 
            // buttonSupplerManageProdect
            // 
            this.buttonSupplerManageProdect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupplerManageProdect.Location = new System.Drawing.Point(109, 142);
            this.buttonSupplerManageProdect.Name = "buttonSupplerManageProdect";
            this.buttonSupplerManageProdect.Size = new System.Drawing.Size(188, 33);
            this.buttonSupplerManageProdect.TabIndex = 4;
            this.buttonSupplerManageProdect.Text = "Manage Products";
            this.buttonSupplerManageProdect.UseVisualStyleBackColor = true;
            // 
            // buttonSupplerLogout
            // 
            this.buttonSupplerLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonSupplerLogout.Location = new System.Drawing.Point(281, 233);
            this.buttonSupplerLogout.Name = "buttonSupplerLogout";
            this.buttonSupplerLogout.Size = new System.Drawing.Size(85, 36);
            this.buttonSupplerLogout.TabIndex = 5;
            this.buttonSupplerLogout.Text = "Logout";
            this.buttonSupplerLogout.UseVisualStyleBackColor = true;
            // 
            // SupplierDashboardUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 327);
            this.Controls.Add(this.buttonSupplerLogout);
            this.Controls.Add(this.buttonSupplerManageProdect);
            this.Controls.Add(this.buttonSupplierStockMovement);
            this.Controls.Add(this.labelSupplierDashboard);
            this.Name = "SupplierDashboardUI";
            this.Text = "SupplierDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSupplierDashboard;
        private System.Windows.Forms.Button buttonSupplierStockMovement;
        private System.Windows.Forms.Button buttonSupplerManageProdect;
        private System.Windows.Forms.Button buttonSupplerLogout;
    }
}