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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.comboBoxSupplier = new System.Windows.Forms.ComboBox();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textSKU = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelSupplier = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.labelManageProducts = new System.Windows.Forms.Label();
            this.buttonView = new System.Windows.Forms.Button();
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
            // textQuantity
            // 
            this.textQuantity.Location = new System.Drawing.Point(167, 360);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Size = new System.Drawing.Size(260, 22);
            this.textQuantity.TabIndex = 29;
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(167, 327);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(260, 22);
            this.textPrice.TabIndex = 28;
            // 
            // textSKU
            // 
            this.textSKU.Location = new System.Drawing.Point(167, 294);
            this.textSKU.Multiline = true;
            this.textSKU.Name = "textSKU";
            this.textSKU.Size = new System.Drawing.Size(260, 22);
            this.textSKU.TabIndex = 27;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(167, 261);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(260, 22);
            this.textName.TabIndex = 26;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
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
            // buttonView
            // 
            this.buttonView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonView.Location = new System.Drawing.Point(495, 381);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(127, 39);
            this.buttonView.TabIndex = 35;
            this.buttonView.Text = "View";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 524);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.buttonDashboard);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.comboBoxSupplier);
            this.Controls.Add(this.textQuantity);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textSKU);
            this.Controls.Add(this.textName);
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
            this.Load += new System.EventHandler(this.ManageProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ComboBox comboBoxSupplier;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.TextBox textSKU;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelSupplier;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Label labelManageProducts;
        private System.Windows.Forms.Button buttonView;
    }
}