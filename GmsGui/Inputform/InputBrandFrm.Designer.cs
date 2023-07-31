
namespace GmsGui.Data_Layer
{
    partial class InputBrandFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputBrandFrm));
            this.TpDisclothGrid = new System.Windows.Forms.DataGridView();
            this.ViewLbl = new System.Windows.Forms.Label();
            this.invalidLbl = new System.Windows.Forms.Label();
            this.SearTxt = new System.Windows.Forms.TextBox();
            this.adminSearchbtn = new System.Windows.Forms.Button();
            this.ClothSearchBtn = new System.Windows.Forms.Button();
            this.ErrorLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TpDisclothGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TpDisclothGrid
            // 
            this.TpDisclothGrid.BackgroundColor = System.Drawing.Color.DarkRed;
            this.TpDisclothGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TpDisclothGrid.Location = new System.Drawing.Point(255, 160);
            this.TpDisclothGrid.Name = "TpDisclothGrid";
            this.TpDisclothGrid.Size = new System.Drawing.Size(336, 278);
            this.TpDisclothGrid.TabIndex = 15;
            this.TpDisclothGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TpDisclothGrid_CellContentClick);
            // 
            // ViewLbl
            // 
            this.ViewLbl.AutoSize = true;
            this.ViewLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewLbl.ForeColor = System.Drawing.Color.White;
            this.ViewLbl.Location = new System.Drawing.Point(325, 9);
            this.ViewLbl.Name = "ViewLbl";
            this.ViewLbl.Size = new System.Drawing.Size(173, 26);
            this.ViewLbl.TabIndex = 16;
            this.ViewLbl.Text = "VIEW PORTAL";
            // 
            // invalidLbl
            // 
            this.invalidLbl.AutoSize = true;
            this.invalidLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidLbl.ForeColor = System.Drawing.Color.Red;
            this.invalidLbl.Location = new System.Drawing.Point(284, 78);
            this.invalidLbl.Name = "invalidLbl";
            this.invalidLbl.Size = new System.Drawing.Size(83, 17);
            this.invalidLbl.TabIndex = 14;
            this.invalidLbl.Text = "Invalid Input";
            this.invalidLbl.Visible = false;
            // 
            // SearTxt
            // 
            this.SearTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearTxt.Location = new System.Drawing.Point(278, 50);
            this.SearTxt.Multiline = true;
            this.SearTxt.Name = "SearTxt";
            this.SearTxt.Size = new System.Drawing.Size(170, 25);
            this.SearTxt.TabIndex = 0;
            this.SearTxt.Text = "Search";
            // 
            // adminSearchbtn
            // 
            this.adminSearchbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("adminSearchbtn.BackgroundImage")));
            this.adminSearchbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adminSearchbtn.Location = new System.Drawing.Point(479, 50);
            this.adminSearchbtn.Name = "adminSearchbtn";
            this.adminSearchbtn.Size = new System.Drawing.Size(38, 34);
            this.adminSearchbtn.TabIndex = 1;
            this.adminSearchbtn.UseVisualStyleBackColor = true;
            this.adminSearchbtn.Click += new System.EventHandler(this.adminSearchbtn_Click);
            // 
            // ClothSearchBtn
            // 
            this.ClothSearchBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClothSearchBtn.BackgroundImage")));
            this.ClothSearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClothSearchBtn.Location = new System.Drawing.Point(479, 105);
            this.ClothSearchBtn.Name = "ClothSearchBtn";
            this.ClothSearchBtn.Size = new System.Drawing.Size(38, 34);
            this.ClothSearchBtn.TabIndex = 18;
            this.ClothSearchBtn.UseVisualStyleBackColor = true;
            // 
            // ErrorLbl
            // 
            this.ErrorLbl.AutoSize = true;
            this.ErrorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.ErrorLbl.Location = new System.Drawing.Point(284, 133);
            this.ErrorLbl.Name = "ErrorLbl";
            this.ErrorLbl.Size = new System.Drawing.Size(83, 17);
            this.ErrorLbl.TabIndex = 19;
            this.ErrorLbl.Text = "Invalid Input";
            this.ErrorLbl.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(278, 105);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 25);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "Search";
            // 
            // InputBrandFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ErrorLbl);
            this.Controls.Add(this.ClothSearchBtn);
            this.Controls.Add(this.ViewLbl);
            this.Controls.Add(this.TpDisclothGrid);
            this.Controls.Add(this.invalidLbl);
            this.Controls.Add(this.adminSearchbtn);
            this.Controls.Add(this.SearTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InputBrandFrm";
            this.Text = "2";
            this.Load += new System.EventHandler(this.InputBrandFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TpDisclothGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView TpDisclothGrid;
        private System.Windows.Forms.Label ViewLbl;
        private System.Windows.Forms.Label invalidLbl;
        private System.Windows.Forms.TextBox SearTxt;
        private System.Windows.Forms.Button adminSearchbtn;
        private System.Windows.Forms.Button ClothSearchBtn;
        private System.Windows.Forms.Label ErrorLbl;
        private System.Windows.Forms.TextBox textBox1;
    }
}