
namespace GmsGui.HeadBoyFrmFolder
{
    partial class customerDetailFrm
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
            this.BacktoHeadboy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.customerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BacktoHeadboy)).BeginInit();
            this.SuspendLayout();
            // 
            // customerGrid
            // 
            this.customerGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerGrid.BackgroundColor = System.Drawing.Color.DarkRed;
            this.customerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGrid.Location = new System.Drawing.Point(39, 74);
            this.customerGrid.Name = "customerGrid";
            this.customerGrid.ReadOnly = true;
            this.customerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerGrid.Size = new System.Drawing.Size(719, 262);
            this.customerGrid.TabIndex = 3;
            this.customerGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerGrid_CellContentClick);
            // 
            // customerLbl
            // 
            this.customerLbl.AutoSize = true;
            this.customerLbl.BackColor = System.Drawing.Color.Black;
            this.customerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLbl.ForeColor = System.Drawing.Color.White;
            this.customerLbl.Location = new System.Drawing.Point(263, 24);
            this.customerLbl.Name = "customerLbl";
            this.customerLbl.Size = new System.Drawing.Size(250, 26);
            this.customerLbl.TabIndex = 4;
            this.customerLbl.Text = "CUSTOMER DEATILS";
            // 
            // BacktoHeadboy
            // 
            this.BacktoHeadboy.BackColor = System.Drawing.Color.White;
            this.BacktoHeadboy.BackgroundImage = global::GmsGui.Properties.Resources.sl;
            this.BacktoHeadboy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BacktoHeadboy.Location = new System.Drawing.Point(1, -3);
            this.BacktoHeadboy.Name = "BacktoHeadboy";
            this.BacktoHeadboy.Size = new System.Drawing.Size(39, 38);
            this.BacktoHeadboy.TabIndex = 35;
            this.BacktoHeadboy.TabStop = false;
            this.BacktoHeadboy.Click += new System.EventHandler(this.backtoBrand_Click);
            // 
            // customerDetailFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BacktoHeadboy);
            this.Controls.Add(this.customerLbl);
            this.Controls.Add(this.customerGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "customerDetailFrm";
            this.Text = "customerDetailFrm";
            this.Load += new System.EventHandler(this.customerDetailFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BacktoHeadboy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customerGrid;
        private System.Windows.Forms.Label customerLbl;
        private System.Windows.Forms.PictureBox BacktoHeadboy;
    }
}