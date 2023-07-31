
namespace GmsGui.EmployeeFrmFolder
{
    partial class CusDeatilFrm
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
            this.customerGrid = new System.Windows.Forms.DataGridView();
            this.customerLbl = new System.Windows.Forms.Label();
            this.BacktoEmployee = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.customerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BacktoEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // customerGrid
            // 
            this.customerGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerGrid.BackgroundColor = System.Drawing.Color.DarkRed;
            this.customerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGrid.Location = new System.Drawing.Point(41, 94);
            this.customerGrid.Name = "customerGrid";
            this.customerGrid.ReadOnly = true;
            this.customerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerGrid.Size = new System.Drawing.Size(719, 262);
            this.customerGrid.TabIndex = 4;
            // 
            // customerLbl
            // 
            this.customerLbl.AutoSize = true;
            this.customerLbl.BackColor = System.Drawing.Color.Black;
            this.customerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLbl.ForeColor = System.Drawing.Color.White;
            this.customerLbl.Location = new System.Drawing.Point(261, 27);
            this.customerLbl.Name = "customerLbl";
            this.customerLbl.Size = new System.Drawing.Size(250, 26);
            this.customerLbl.TabIndex = 5;
            this.customerLbl.Text = "CUSTOMER DEATILS";
            // 
            // BacktoEmployee
            // 
            this.BacktoEmployee.BackColor = System.Drawing.Color.White;
            this.BacktoEmployee.BackgroundImage = global::GmsGui.Properties.Resources.sl;
            this.BacktoEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BacktoEmployee.Location = new System.Drawing.Point(0, -4);
            this.BacktoEmployee.Name = "BacktoEmployee";
            this.BacktoEmployee.Size = new System.Drawing.Size(39, 38);
            this.BacktoEmployee.TabIndex = 36;
            this.BacktoEmployee.TabStop = false;
            this.BacktoEmployee.Click += new System.EventHandler(this.BacktoEmployee_Click);
            // 
            // CusDeatilFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BacktoEmployee);
            this.Controls.Add(this.customerLbl);
            this.Controls.Add(this.customerGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CusDeatilFrm";
            this.Text = "CusDeatilFrm";
            this.Load += new System.EventHandler(this.CusDeatilFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BacktoEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customerGrid;
        private System.Windows.Forms.Label customerLbl;
        private System.Windows.Forms.PictureBox BacktoEmployee;
    }
}