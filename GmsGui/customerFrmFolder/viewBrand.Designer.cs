
namespace GmsGui.customerFrmFolder
{
    partial class viewBrand
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
            this.BrandGrid = new System.Windows.Forms.DataGridView();
            this.brandLbl = new System.Windows.Forms.Label();
            this.Viewbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BrandGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BrandGrid
            // 
            this.BrandGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BrandGrid.BackgroundColor = System.Drawing.Color.DarkRed;
            this.BrandGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BrandGrid.Location = new System.Drawing.Point(211, 87);
            this.BrandGrid.Name = "BrandGrid";
            this.BrandGrid.ReadOnly = true;
            this.BrandGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BrandGrid.Size = new System.Drawing.Size(426, 283);
            this.BrandGrid.TabIndex = 0;
            this.BrandGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AddtoCardDrid_CellContentClick);
            // 
            // brandLbl
            // 
            this.brandLbl.AutoSize = true;
            this.brandLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandLbl.ForeColor = System.Drawing.Color.White;
            this.brandLbl.Location = new System.Drawing.Point(338, 25);
            this.brandLbl.Name = "brandLbl";
            this.brandLbl.Size = new System.Drawing.Size(163, 29);
            this.brandLbl.TabIndex = 3;
            this.brandLbl.Text = "BRAND LIST";
            // 
            // Viewbtn
            // 
            this.Viewbtn.FlatAppearance.BorderSize = 2;
            this.Viewbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.Viewbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.Viewbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Viewbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Viewbtn.ForeColor = System.Drawing.Color.White;
            this.Viewbtn.Location = new System.Drawing.Point(360, 393);
            this.Viewbtn.Name = "Viewbtn";
            this.Viewbtn.Size = new System.Drawing.Size(102, 35);
            this.Viewbtn.TabIndex = 4;
            this.Viewbtn.Text = "View Cloth";
            this.Viewbtn.UseVisualStyleBackColor = true;
            this.Viewbtn.Click += new System.EventHandler(this.Viewbtn_Click);
            // 
            // viewBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Viewbtn);
            this.Controls.Add(this.brandLbl);
            this.Controls.Add(this.BrandGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewBrand";
            this.Text = "AddTocardViewFrm";
            this.Load += new System.EventHandler(this.AddTocardViewFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BrandGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BrandGrid;
        private System.Windows.Forms.Label brandLbl;
        private System.Windows.Forms.Button Viewbtn;
    }
}