namespace Inventory_Managment_System.SystemUI
{
    partial class PlaceingOrder
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnPlaceOrder = new System.Windows.Forms.Button();
            this.labelOrderPlace = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(485, 363);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnPlaceOrder
            // 
            this.BtnPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlaceOrder.Location = new System.Drawing.Point(455, 498);
            this.BtnPlaceOrder.Name = "BtnPlaceOrder";
            this.BtnPlaceOrder.Size = new System.Drawing.Size(188, 33);
            this.BtnPlaceOrder.TabIndex = 5;
            this.BtnPlaceOrder.Text = "Place Order !";
            this.BtnPlaceOrder.UseVisualStyleBackColor = true;
            // 
            // labelOrderPlace
            // 
            this.labelOrderPlace.AutoSize = true;
            this.labelOrderPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelOrderPlace.Location = new System.Drawing.Point(406, 40);
            this.labelOrderPlace.Name = "labelOrderPlace";
            this.labelOrderPlace.Size = new System.Drawing.Size(216, 29);
            this.labelOrderPlace.TabIndex = 6;
            this.labelOrderPlace.Text = "Place Your Order";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(550, 109);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(485, 363);
            this.dataGridView2.TabIndex = 7;
            // 
            // PlaceingOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 543);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.labelOrderPlace);
            this.Controls.Add(this.BtnPlaceOrder);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PlaceingOrder";
            this.Text = "PlaceingOrder";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnPlaceOrder;
        private System.Windows.Forms.Label labelOrderPlace;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}