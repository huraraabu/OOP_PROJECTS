
namespace GmsGui.customerFrmFolder
{
    partial class PurchasingFrm
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
            this.PurchasingGrid = new System.Windows.Forms.DataGridView();
            this.CustomerLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PurchasingGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PurchasingGrid
            // 
            this.PurchasingGrid.BackgroundColor = System.Drawing.Color.DarkRed;
            this.PurchasingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PurchasingGrid.Location = new System.Drawing.Point(220, 88);
            this.PurchasingGrid.Name = "PurchasingGrid";
            this.PurchasingGrid.Size = new System.Drawing.Size(407, 281);
            this.PurchasingGrid.TabIndex = 0;
            this.PurchasingGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PurchasingGrid_CellContentClick);
            // 
            // CustomerLbl
            // 
            this.CustomerLbl.AutoSize = true;
            this.CustomerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerLbl.ForeColor = System.Drawing.Color.White;
            this.CustomerLbl.Location = new System.Drawing.Point(271, 35);
            this.CustomerLbl.Name = "CustomerLbl";
            this.CustomerLbl.Size = new System.Drawing.Size(301, 29);
            this.CustomerLbl.TabIndex = 4;
            this.CustomerLbl.Text = "PURCHASING HISTORY";
            // 
            // PurchasingFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CustomerLbl);
            this.Controls.Add(this.PurchasingGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PurchasingFrm";
            this.Text = "PurchasingFrm";
            ((System.ComponentModel.ISupportInitialize)(this.PurchasingGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PurchasingGrid;
        private System.Windows.Forms.Label CustomerLbl;
    }
}