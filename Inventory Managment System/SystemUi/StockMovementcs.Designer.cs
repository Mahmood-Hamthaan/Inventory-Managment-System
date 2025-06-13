namespace Inventory_Managment_System.SystemUi
{
    partial class StockMovementcs
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelStockMovement = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonAddStock = new System.Windows.Forms.Button();
            this.buttonRemoveStock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStockMovement
            // 
            this.labelStockMovement.AutoSize = true;
            this.labelStockMovement.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStockMovement.Location = new System.Drawing.Point(212, 44);
            this.labelStockMovement.Name = "labelStockMovement";
            this.labelStockMovement.Size = new System.Drawing.Size(205, 29);
            this.labelStockMovement.TabIndex = 1;
            this.labelStockMovement.Text = "Stock Movement";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(30, 86);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(545, 300);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // buttonAddStock
            // 
            this.buttonAddStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonAddStock.Location = new System.Drawing.Point(130, 412);
            this.buttonAddStock.Name = "buttonAddStock";
            this.buttonAddStock.Size = new System.Drawing.Size(127, 36);
            this.buttonAddStock.TabIndex = 3;
            this.buttonAddStock.Text = "Add";
            this.buttonAddStock.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveStock
            // 
            this.buttonRemoveStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonRemoveStock.Location = new System.Drawing.Point(275, 412);
            this.buttonRemoveStock.Name = "buttonRemoveStock";
            this.buttonRemoveStock.Size = new System.Drawing.Size(127, 36);
            this.buttonRemoveStock.TabIndex = 4;
            this.buttonRemoveStock.Text = "Remove";
            this.buttonRemoveStock.UseVisualStyleBackColor = true;
            // 
            // StockMovementcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 483);
            this.Controls.Add(this.buttonRemoveStock);
            this.Controls.Add(this.buttonAddStock);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.labelStockMovement);
            this.Name = "StockMovementcs";
            this.Text = "StockMovementcs";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStockMovement;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonAddStock;
        private System.Windows.Forms.Button buttonRemoveStock;
    }
}