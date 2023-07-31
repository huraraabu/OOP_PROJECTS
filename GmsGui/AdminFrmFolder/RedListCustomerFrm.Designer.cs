
namespace GmsGui.AdminFrmFolder
{
    partial class RedListCustomerFrm
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
            this.RedCustmerGrid = new System.Windows.Forms.DataGridView();
            this.RedListcustomerLbl = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.RemCusBtn = new System.Windows.Forms.Button();
            this.menIcn = new System.Windows.Forms.PictureBox();
            this.Exitpng = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.RedCustmerGrid)).BeginInit();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menIcn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exitpng)).BeginInit();
            this.SuspendLayout();
            // 
            // RedCustmerGrid
            // 
            this.RedCustmerGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RedCustmerGrid.BackgroundColor = System.Drawing.Color.DarkRed;
            this.RedCustmerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RedCustmerGrid.GridColor = System.Drawing.Color.DarkRed;
            this.RedCustmerGrid.Location = new System.Drawing.Point(47, 76);
            this.RedCustmerGrid.Name = "RedCustmerGrid";
            this.RedCustmerGrid.ReadOnly = true;
            this.RedCustmerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RedCustmerGrid.Size = new System.Drawing.Size(708, 254);
            this.RedCustmerGrid.TabIndex = 1;
            this.RedCustmerGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RedCustmerGrid_CellContentClick);
            // 
            // RedListcustomerLbl
            // 
            this.RedListcustomerLbl.AutoSize = true;
            this.RedListcustomerLbl.BackColor = System.Drawing.Color.Black;
            this.RedListcustomerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedListcustomerLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RedListcustomerLbl.Location = new System.Drawing.Point(265, 19);
            this.RedListcustomerLbl.Name = "RedListcustomerLbl";
            this.RedListcustomerLbl.Size = new System.Drawing.Size(281, 29);
            this.RedListcustomerLbl.TabIndex = 4;
            this.RedListcustomerLbl.Text = "RED LIST CUSTOMER";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.RemCusBtn);
            this.panel13.Controls.Add(this.menIcn);
            this.panel13.Location = new System.Drawing.Point(284, 356);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(180, 43);
            this.panel13.TabIndex = 7;
            // 
            // RemCusBtn
            // 
            this.RemCusBtn.BackColor = System.Drawing.Color.DarkRed;
            this.RemCusBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RemCusBtn.FlatAppearance.BorderSize = 2;
            this.RemCusBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.RemCusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemCusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemCusBtn.ForeColor = System.Drawing.Color.White;
            this.RemCusBtn.Location = new System.Drawing.Point(49, 3);
            this.RemCusBtn.Name = "RemCusBtn";
            this.RemCusBtn.Size = new System.Drawing.Size(121, 32);
            this.RemCusBtn.TabIndex = 18;
            this.RemCusBtn.Text = "REMOVE CUSTOMER";
            this.RemCusBtn.UseVisualStyleBackColor = false;
            this.RemCusBtn.Click += new System.EventHandler(this.RemCusBtn_Click);
            // 
            // menIcn
            // 
            this.menIcn.BackColor = System.Drawing.Color.White;
            this.menIcn.BackgroundImage = global::GmsGui.Properties.Resources.manager;
            this.menIcn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menIcn.Image = global::GmsGui.Properties.Resources.sale;
            this.menIcn.Location = new System.Drawing.Point(0, 3);
            this.menIcn.Name = "menIcn";
            this.menIcn.Size = new System.Drawing.Size(43, 38);
            this.menIcn.TabIndex = 3;
            this.menIcn.TabStop = false;
            // 
            // Exitpng
            // 
            this.Exitpng.BackColor = System.Drawing.Color.White;
            this.Exitpng.BackgroundImage = global::GmsGui.Properties.Resources.icons8_back_arrow_301;
            this.Exitpng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exitpng.Location = new System.Drawing.Point(0, 0);
            this.Exitpng.Name = "Exitpng";
            this.Exitpng.Size = new System.Drawing.Size(43, 38);
            this.Exitpng.TabIndex = 20;
            this.Exitpng.TabStop = false;
            this.Exitpng.Click += new System.EventHandler(this.exit_Click);
            // 
            // RedListCustomerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exitpng);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.RedListcustomerLbl);
            this.Controls.Add(this.RedCustmerGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RedListCustomerFrm";
            this.Text = "RedListCustomerFrm";
            this.Load += new System.EventHandler(this.RedListCustomerFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RedCustmerGrid)).EndInit();
            this.panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menIcn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exitpng)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RedCustmerGrid;
        private System.Windows.Forms.Label RedListcustomerLbl;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button RemCusBtn;
        private System.Windows.Forms.PictureBox menIcn;
        private System.Windows.Forms.PictureBox Exitpng;
    }
}