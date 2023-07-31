
namespace GmsGui.ViewFormFolder
{
    partial class ClothFrm
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
            this.clothGrid = new System.Windows.Forms.DataGridView();
            this.Exitpng = new System.Windows.Forms.PictureBox();
            this.backtoemployee = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.clothGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exitpng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backtoemployee)).BeginInit();
            this.SuspendLayout();
            // 
            // clothGrid
            // 
            this.clothGrid.BackgroundColor = System.Drawing.Color.DarkRed;
            this.clothGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clothGrid.Location = new System.Drawing.Point(148, 68);
            this.clothGrid.Name = "clothGrid";
            this.clothGrid.Size = new System.Drawing.Size(410, 241);
            this.clothGrid.TabIndex = 0;
            this.clothGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clothGrid_CellContentClick);
            // 
            // Exitpng
            // 
            this.Exitpng.BackColor = System.Drawing.Color.White;
            this.Exitpng.BackgroundImage = global::GmsGui.Properties.Resources.icons8_back_arrow_301;
            this.Exitpng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exitpng.Location = new System.Drawing.Point(-1, -3);
            this.Exitpng.Name = "Exitpng";
            this.Exitpng.Size = new System.Drawing.Size(43, 38);
            this.Exitpng.TabIndex = 24;
            this.Exitpng.TabStop = false;
            this.Exitpng.Click += new System.EventHandler(this.Exitpng_Click);
            // 
            // backtoemployee
            // 
            this.backtoemployee.BackColor = System.Drawing.Color.White;
            this.backtoemployee.BackgroundImage = global::GmsGui.Properties.Resources.icons8_back_arrow_301;
            this.backtoemployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backtoemployee.Location = new System.Drawing.Point(-1, -3);
            this.backtoemployee.Name = "backtoemployee";
            this.backtoemployee.Size = new System.Drawing.Size(43, 38);
            this.backtoemployee.TabIndex = 25;
            this.backtoemployee.TabStop = false;
            this.backtoemployee.Click += new System.EventHandler(this.backtoemployee_Click);
            // 
            // ClothFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(662, 366);
            this.Controls.Add(this.backtoemployee);
            this.Controls.Add(this.Exitpng);
            this.Controls.Add(this.clothGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClothFrm";
            this.Text = "ClothFrm";
            this.Load += new System.EventHandler(this.ClothFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clothGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exitpng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backtoemployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView clothGrid;
        private System.Windows.Forms.PictureBox Exitpng;
        private System.Windows.Forms.PictureBox backtoemployee;
    }
}