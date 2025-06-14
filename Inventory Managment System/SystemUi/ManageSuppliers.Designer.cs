namespace Inventory_Managment_System.Forms
{
    partial class ManageSuppliers
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
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.buttonEditSupplier = new System.Windows.Forms.Button();
            this.buttonDeleteSupplier = new System.Windows.Forms.Button();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.buttonAddSupplier = new System.Windows.Forms.Button();
            this.lebeleSupplierName = new System.Windows.Forms.Label();
            this.labelManageSuppliers = new System.Windows.Forms.Label();
            this.dataGridViewSuppliers = new System.Windows.Forms.DataGridView();
            this.textBoxSupplierPhone = new System.Windows.Forms.TextBox();
            this.labelSupplierPhone = new System.Windows.Forms.Label();
            this.textBoxSupplierEmail = new System.Windows.Forms.TextBox();
            this.labelSupplierEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonDashboard.Location = new System.Drawing.Point(47, 454);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(575, 36);
            this.buttonDashboard.TabIndex = 51;
            this.buttonDashboard.Text = "Back To Dashboard";
            this.buttonDashboard.UseVisualStyleBackColor = true;
            // 
            // buttonEditSupplier
            // 
            this.buttonEditSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonEditSupplier.Location = new System.Drawing.Point(418, 385);
            this.buttonEditSupplier.Name = "buttonEditSupplier";
            this.buttonEditSupplier.Size = new System.Drawing.Size(127, 36);
            this.buttonEditSupplier.TabIndex = 50;
            this.buttonEditSupplier.Text = "Edit";
            this.buttonEditSupplier.UseVisualStyleBackColor = true;
            this.buttonEditSupplier.Click += new System.EventHandler(this.buttonEditSupplier_Click);
            // 
            // buttonDeleteSupplier
            // 
            this.buttonDeleteSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonDeleteSupplier.Location = new System.Drawing.Point(135, 385);
            this.buttonDeleteSupplier.Name = "buttonDeleteSupplier";
            this.buttonDeleteSupplier.Size = new System.Drawing.Size(127, 36);
            this.buttonDeleteSupplier.TabIndex = 48;
            this.buttonDeleteSupplier.Text = "Delete";
            this.buttonDeleteSupplier.UseVisualStyleBackColor = true;
            this.buttonDeleteSupplier.Click += new System.EventHandler(this.buttonDeleteSupplier_Click);
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(167, 76);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(260, 22);
            this.txtSupplierName.TabIndex = 43;
            // 
            // buttonAddSupplier
            // 
            this.buttonAddSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonAddSupplier.Location = new System.Drawing.Point(474, 106);
            this.buttonAddSupplier.Name = "buttonAddSupplier";
            this.buttonAddSupplier.Size = new System.Drawing.Size(148, 40);
            this.buttonAddSupplier.TabIndex = 42;
            this.buttonAddSupplier.Text = "Add";
            this.buttonAddSupplier.UseVisualStyleBackColor = true;
            this.buttonAddSupplier.Click += new System.EventHandler(this.buttonAddSupplier_Click);
            // 
            // lebeleSupplierName
            // 
            this.lebeleSupplierName.AutoSize = true;
            this.lebeleSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lebeleSupplierName.Location = new System.Drawing.Point(43, 76);
            this.lebeleSupplierName.Name = "lebeleSupplierName";
            this.lebeleSupplierName.Size = new System.Drawing.Size(63, 20);
            this.lebeleSupplierName.TabIndex = 37;
            this.lebeleSupplierName.Text = "Name :";
            // 
            // labelManageSuppliers
            // 
            this.labelManageSuppliers.AutoSize = true;
            this.labelManageSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelManageSuppliers.Location = new System.Drawing.Point(235, 26);
            this.labelManageSuppliers.Name = "labelManageSuppliers";
            this.labelManageSuppliers.Size = new System.Drawing.Size(225, 29);
            this.labelManageSuppliers.TabIndex = 35;
            this.labelManageSuppliers.Text = "Manage Suppliers";
            // 
            // dataGridViewSuppliers
            // 
            this.dataGridViewSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSuppliers.Location = new System.Drawing.Point(47, 220);
            this.dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            this.dataGridViewSuppliers.RowHeadersWidth = 51;
            this.dataGridViewSuppliers.RowTemplate.Height = 24;
            this.dataGridViewSuppliers.Size = new System.Drawing.Size(575, 150);
            this.dataGridViewSuppliers.TabIndex = 52;
            // 
            // textBoxSupplierPhone
            // 
            this.textBoxSupplierPhone.Location = new System.Drawing.Point(167, 114);
            this.textBoxSupplierPhone.Name = "textBoxSupplierPhone";
            this.textBoxSupplierPhone.Size = new System.Drawing.Size(260, 22);
            this.textBoxSupplierPhone.TabIndex = 54;
            this.textBoxSupplierPhone.TextChanged += new System.EventHandler(this.textBoxSupplierPhone_TextChanged);
            // 
            // labelSupplierPhone
            // 
            this.labelSupplierPhone.AutoSize = true;
            this.labelSupplierPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.labelSupplierPhone.Location = new System.Drawing.Point(43, 116);
            this.labelSupplierPhone.Name = "labelSupplierPhone";
            this.labelSupplierPhone.Size = new System.Drawing.Size(66, 20);
            this.labelSupplierPhone.TabIndex = 53;
            this.labelSupplierPhone.Text = "Phone :";
            // 
            // textBoxSupplierEmail
            // 
            this.textBoxSupplierEmail.Location = new System.Drawing.Point(167, 154);
            this.textBoxSupplierEmail.Name = "textBoxSupplierEmail";
            this.textBoxSupplierEmail.Size = new System.Drawing.Size(260, 22);
            this.textBoxSupplierEmail.TabIndex = 56;
            this.textBoxSupplierEmail.TextChanged += new System.EventHandler(this.textBoxSupplierEmail_TextChanged);
            // 
            // labelSupplierEmail
            // 
            this.labelSupplierEmail.AutoSize = true;
            this.labelSupplierEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.labelSupplierEmail.Location = new System.Drawing.Point(43, 154);
            this.labelSupplierEmail.Name = "labelSupplierEmail";
            this.labelSupplierEmail.Size = new System.Drawing.Size(61, 20);
            this.labelSupplierEmail.TabIndex = 55;
            this.labelSupplierEmail.Text = "Email :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(42, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 26);
            this.label1.TabIndex = 57;
            this.label1.Text = "Assigned Products";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ManageSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 517);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSupplierEmail);
            this.Controls.Add(this.labelSupplierEmail);
            this.Controls.Add(this.textBoxSupplierPhone);
            this.Controls.Add(this.labelSupplierPhone);
            this.Controls.Add(this.dataGridViewSuppliers);
            this.Controls.Add(this.buttonDashboard);
            this.Controls.Add(this.buttonEditSupplier);
            this.Controls.Add(this.buttonDeleteSupplier);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.buttonAddSupplier);
            this.Controls.Add(this.lebeleSupplierName);
            this.Controls.Add(this.labelManageSuppliers);
            this.Name = "ManageSuppliers";
            this.Text = "ManageSuppliers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Button buttonEditSupplier;
        private System.Windows.Forms.Button buttonDeleteSupplier;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Button buttonAddSupplier;
        private System.Windows.Forms.Label lebeleSupplierName;
        private System.Windows.Forms.Label labelManageSuppliers;
        private System.Windows.Forms.DataGridView dataGridViewSuppliers;
        private System.Windows.Forms.TextBox textBoxSupplierPhone;
        private System.Windows.Forms.Label labelSupplierPhone;
        private System.Windows.Forms.TextBox textBoxSupplierEmail;
        private System.Windows.Forms.Label labelSupplierEmail;
        private System.Windows.Forms.Label label1;
    }
}