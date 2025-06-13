namespace Inventory_Managment_System.Forms
{
    partial class ManageProducts
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
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.comboBoxSupplier = new System.Windows.Forms.ComboBox();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelSupplier = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.labelManageProducts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonDashboard.Location = new System.Drawing.Point(47, 454);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(575, 36);
            this.buttonDashboard.TabIndex = 34;
            this.buttonDashboard.Text = "Back To Dashboard";
            this.buttonDashboard.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonEdit.Location = new System.Drawing.Point(495, 253);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(127, 36);
            this.buttonEdit.TabIndex = 33;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonClear.Location = new System.Drawing.Point(495, 381);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(127, 36);
            this.buttonClear.TabIndex = 32;
            this.buttonClear.Text = "View";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonDelete.Location = new System.Drawing.Point(495, 297);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(127, 36);
            this.buttonDelete.TabIndex = 31;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // comboBoxSupplier
            // 
            this.comboBoxSupplier.FormattingEnabled = true;
            this.comboBoxSupplier.Location = new System.Drawing.Point(167, 393);
            this.comboBoxSupplier.Name = "comboBoxSupplier";
            this.comboBoxSupplier.Size = new System.Drawing.Size(260, 24);
            this.comboBoxSupplier.TabIndex = 30;
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(167, 360);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(260, 22);
            this.textBoxStock.TabIndex = 29;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(167, 327);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(260, 22);
            this.textBoxPrice.TabIndex = 28;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(167, 294);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(260, 22);
            this.textBoxDescription.TabIndex = 27;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(167, 261);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(260, 22);
            this.textBoxName.TabIndex = 26;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonAdd.Location = new System.Drawing.Point(495, 339);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(127, 36);
            this.buttonAdd.TabIndex = 25;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelSupplier
            // 
            this.labelSupplier.AutoSize = true;
            this.labelSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.labelSupplier.Location = new System.Drawing.Point(43, 393);
            this.labelSupplier.Name = "labelSupplier";
            this.labelSupplier.Size = new System.Drawing.Size(80, 20);
            this.labelSupplier.TabIndex = 24;
            this.labelSupplier.Text = "Supplier :";
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.labelStock.Location = new System.Drawing.Point(43, 362);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(61, 20);
            this.labelStock.TabIndex = 23;
            this.labelStock.Text = "Stock :";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.labelPrice.Location = new System.Drawing.Point(43, 329);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(58, 20);
            this.labelPrice.TabIndex = 22;
            this.labelPrice.Text = "Price :";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.labelDescription.Location = new System.Drawing.Point(43, 296);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(105, 20);
            this.labelDescription.TabIndex = 21;
            this.labelDescription.Text = "Description :";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Name.Location = new System.Drawing.Point(43, 263);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(63, 20);
            this.Name.TabIndex = 20;
            this.Name.Text = "Name :";
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(47, 80);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowHeadersWidth = 51;
            this.dataGridViewProducts.RowTemplate.Height = 24;
            this.dataGridViewProducts.Size = new System.Drawing.Size(575, 150);
            this.dataGridViewProducts.TabIndex = 19;
            // 
            // labelManageProducts
            // 
            this.labelManageProducts.AutoSize = true;
            this.labelManageProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelManageProducts.Location = new System.Drawing.Point(235, 26);
            this.labelManageProducts.Name = "labelManageProducts";
            this.labelManageProducts.Size = new System.Drawing.Size(216, 29);
            this.labelManageProducts.TabIndex = 18;
            this.labelManageProducts.Text = "Manage Products";
            // 
            // ManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 524);
            this.Controls.Add(this.buttonDashboard);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.comboBoxSupplier);
            this.Controls.Add(this.textBoxStock);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelSupplier);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.labelManageProducts);
            this.Name = "ManageProducts";
            this.Text = "ManageProducts";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ComboBox comboBoxSupplier;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelSupplier;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Label labelManageProducts;
    }
}