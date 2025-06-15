namespace Inventory_Managment_System.Forms
{
    partial class AdminDashboardUI
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
            this.labelAdminDashboard = new System.Windows.Forms.Label();
            this.btnManageProducts = new System.Windows.Forms.Button();
            this.btnManageSupplier = new System.Windows.Forms.Button();
            this.btnManageOrders = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnRegisterUsers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAdminDashboard
            // 
            this.labelAdminDashboard.AutoSize = true;
            this.labelAdminDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelAdminDashboard.Location = new System.Drawing.Point(369, 44);
            this.labelAdminDashboard.Name = "labelAdminDashboard";
            this.labelAdminDashboard.Size = new System.Drawing.Size(220, 29);
            this.labelAdminDashboard.TabIndex = 0;
            this.labelAdminDashboard.Text = "Admin Dashboard";
            // 
            // btnManageProducts
            // 
            this.btnManageProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageProducts.Location = new System.Drawing.Point(132, 139);
            this.btnManageProducts.Name = "btnManageProducts";
            this.btnManageProducts.Size = new System.Drawing.Size(228, 33);
            this.btnManageProducts.TabIndex = 1;
            this.btnManageProducts.Text = "Manage Products";
            this.btnManageProducts.UseVisualStyleBackColor = true;
            this.btnManageProducts.Click += new System.EventHandler(this.btnManageProducts_Click);
            // 
            // btnManageSupplier
            // 
            this.btnManageSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnManageSupplier.Location = new System.Drawing.Point(342, 76);
            this.btnManageSupplier.Name = "btnManageSupplier";
            this.btnManageSupplier.Size = new System.Drawing.Size(266, 33);
            this.btnManageSupplier.TabIndex = 2;
            this.btnManageSupplier.Text = "Manage Suppliers";
            this.btnManageSupplier.UseVisualStyleBackColor = true;
            this.btnManageSupplier.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnManageOrders
            // 
            this.btnManageOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnManageOrders.Location = new System.Drawing.Point(589, 139);
            this.btnManageOrders.Name = "btnManageOrders";
            this.btnManageOrders.Size = new System.Drawing.Size(224, 33);
            this.btnManageOrders.TabIndex = 3;
            this.btnManageOrders.Text = "Manage Orders";
            this.btnManageOrders.UseVisualStyleBackColor = true;
            this.btnManageOrders.Click += new System.EventHandler(this.btnManageOrders_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnLogout.Location = new System.Drawing.Point(426, 241);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(85, 36);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnRegisterUsers
            // 
            this.btnRegisterUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnRegisterUsers.Location = new System.Drawing.Point(342, 187);
            this.btnRegisterUsers.Name = "btnRegisterUsers";
            this.btnRegisterUsers.Size = new System.Drawing.Size(266, 33);
            this.btnRegisterUsers.TabIndex = 5;
            this.btnRegisterUsers.Text = "Register Users";
            this.btnRegisterUsers.UseVisualStyleBackColor = true;
            this.btnRegisterUsers.Click += new System.EventHandler(this.btnRegisterUsers_Click);
            // 
            // AdminDashboardUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 289);
            this.Controls.Add(this.btnRegisterUsers);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnManageOrders);
            this.Controls.Add(this.btnManageSupplier);
            this.Controls.Add(this.btnManageProducts);
            this.Controls.Add(this.labelAdminDashboard);
            this.Name = "AdminDashboardUI";
            this.Text = " Admin Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdminDashboard;
        private System.Windows.Forms.Button btnManageProducts;
        private System.Windows.Forms.Button btnManageSupplier;
        private System.Windows.Forms.Button btnManageOrders;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnRegisterUsers;
    }
}