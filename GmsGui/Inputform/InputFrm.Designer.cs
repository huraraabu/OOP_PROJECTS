
namespace GmsGui.Inputform
{
    partial class InputFrm
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
            this.brandTxt = new System.Windows.Forms.TextBox();
            this.ViewLbl = new System.Windows.Forms.Label();
            this.BrandNameLbl = new System.Windows.Forms.Label();
            this.sumbitBtn = new System.Windows.Forms.Button();
            this.clothTxt = new System.Windows.Forms.TextBox();
            this.clothNameLbl = new System.Windows.Forms.Label();
            this.NumberOfClthLbl = new System.Windows.Forms.Label();
            this.BrandinvalidLbl = new System.Windows.Forms.Label();
            this.invalidClothLbl = new System.Windows.Forms.Label();
            this.invIntegerlbl = new System.Windows.Forms.Label();
            this.numberTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // brandTxt
            // 
            this.brandTxt.Location = new System.Drawing.Point(214, 62);
            this.brandTxt.Multiline = true;
            this.brandTxt.Name = "brandTxt";
            this.brandTxt.Size = new System.Drawing.Size(121, 22);
            this.brandTxt.TabIndex = 0;
            this.brandTxt.TextChanged += new System.EventHandler(this.brandTxt_TextChanged);
            // 
            // ViewLbl
            // 
            this.ViewLbl.AutoSize = true;
            this.ViewLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewLbl.ForeColor = System.Drawing.Color.White;
            this.ViewLbl.Location = new System.Drawing.Point(152, 9);
            this.ViewLbl.Name = "ViewLbl";
            this.ViewLbl.Size = new System.Drawing.Size(182, 26);
            this.ViewLbl.TabIndex = 17;
            this.ViewLbl.Text = "INPUT PORTAL";
            // 
            // BrandNameLbl
            // 
            this.BrandNameLbl.AutoSize = true;
            this.BrandNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandNameLbl.ForeColor = System.Drawing.Color.White;
            this.BrandNameLbl.Location = new System.Drawing.Point(12, 62);
            this.BrandNameLbl.Name = "BrandNameLbl";
            this.BrandNameLbl.Size = new System.Drawing.Size(166, 17);
            this.BrandNameLbl.TabIndex = 18;
            this.BrandNameLbl.Text = "ENTER BRAND NAME";
            // 
            // sumbitBtn
            // 
            this.sumbitBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.sumbitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.sumbitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.sumbitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sumbitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumbitBtn.ForeColor = System.Drawing.Color.White;
            this.sumbitBtn.Location = new System.Drawing.Point(214, 263);
            this.sumbitBtn.Name = "sumbitBtn";
            this.sumbitBtn.Size = new System.Drawing.Size(75, 29);
            this.sumbitBtn.TabIndex = 19;
            this.sumbitBtn.Text = "SUBMIT";
            this.sumbitBtn.UseVisualStyleBackColor = true;
            this.sumbitBtn.Click += new System.EventHandler(this.sumbitBtn_Click);
            // 
            // clothTxt
            // 
            this.clothTxt.Location = new System.Drawing.Point(213, 126);
            this.clothTxt.Multiline = true;
            this.clothTxt.Name = "clothTxt";
            this.clothTxt.Size = new System.Drawing.Size(121, 22);
            this.clothTxt.TabIndex = 20;
            // 
            // clothNameLbl
            // 
            this.clothNameLbl.AutoSize = true;
            this.clothNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clothNameLbl.ForeColor = System.Drawing.Color.White;
            this.clothNameLbl.Location = new System.Drawing.Point(12, 131);
            this.clothNameLbl.Name = "clothNameLbl";
            this.clothNameLbl.Size = new System.Drawing.Size(165, 17);
            this.clothNameLbl.TabIndex = 22;
            this.clothNameLbl.Text = "ENTER CLOTH NAME";
            // 
            // NumberOfClthLbl
            // 
            this.NumberOfClthLbl.AutoSize = true;
            this.NumberOfClthLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfClthLbl.ForeColor = System.Drawing.Color.White;
            this.NumberOfClthLbl.Location = new System.Drawing.Point(12, 195);
            this.NumberOfClthLbl.Name = "NumberOfClthLbl";
            this.NumberOfClthLbl.Size = new System.Drawing.Size(175, 13);
            this.NumberOfClthLbl.TabIndex = 23;
            this.NumberOfClthLbl.Text = "ENTER  NUMBER OF CLOTH";
            // 
            // BrandinvalidLbl
            // 
            this.BrandinvalidLbl.AutoSize = true;
            this.BrandinvalidLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandinvalidLbl.ForeColor = System.Drawing.Color.Red;
            this.BrandinvalidLbl.Location = new System.Drawing.Point(211, 87);
            this.BrandinvalidLbl.Name = "BrandinvalidLbl";
            this.BrandinvalidLbl.Size = new System.Drawing.Size(83, 17);
            this.BrandinvalidLbl.TabIndex = 24;
            this.BrandinvalidLbl.Text = "Invalid Input";
            this.BrandinvalidLbl.Visible = false;
            // 
            // invalidClothLbl
            // 
            this.invalidClothLbl.AutoSize = true;
            this.invalidClothLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidClothLbl.ForeColor = System.Drawing.Color.Red;
            this.invalidClothLbl.Location = new System.Drawing.Point(211, 151);
            this.invalidClothLbl.Name = "invalidClothLbl";
            this.invalidClothLbl.Size = new System.Drawing.Size(83, 17);
            this.invalidClothLbl.TabIndex = 25;
            this.invalidClothLbl.Text = "Invalid Input";
            this.invalidClothLbl.Visible = false;
            // 
            // invIntegerlbl
            // 
            this.invIntegerlbl.AutoSize = true;
            this.invIntegerlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invIntegerlbl.ForeColor = System.Drawing.Color.Red;
            this.invIntegerlbl.Location = new System.Drawing.Point(211, 215);
            this.invIntegerlbl.Name = "invIntegerlbl";
            this.invIntegerlbl.Size = new System.Drawing.Size(127, 17);
            this.invIntegerlbl.TabIndex = 26;
            this.invIntegerlbl.Text = "enter integer value";
            this.invIntegerlbl.Visible = false;
            // 
            // numberTxt
            // 
            this.numberTxt.Location = new System.Drawing.Point(214, 190);
            this.numberTxt.Multiline = true;
            this.numberTxt.Name = "numberTxt";
            this.numberTxt.Size = new System.Drawing.Size(121, 22);
            this.numberTxt.TabIndex = 21;
            // 
            // InputFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(791, 368);
            this.Controls.Add(this.invIntegerlbl);
            this.Controls.Add(this.invalidClothLbl);
            this.Controls.Add(this.BrandinvalidLbl);
            this.Controls.Add(this.NumberOfClthLbl);
            this.Controls.Add(this.clothNameLbl);
            this.Controls.Add(this.numberTxt);
            this.Controls.Add(this.clothTxt);
            this.Controls.Add(this.sumbitBtn);
            this.Controls.Add(this.BrandNameLbl);
            this.Controls.Add(this.ViewLbl);
            this.Controls.Add(this.brandTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InputFrm";
            this.Text = "InputFrm";
            this.Load += new System.EventHandler(this.InputFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox brandTxt;
        private System.Windows.Forms.Label ViewLbl;
        private System.Windows.Forms.Label BrandNameLbl;
        private System.Windows.Forms.Button sumbitBtn;
        private System.Windows.Forms.TextBox clothTxt;
        private System.Windows.Forms.Label clothNameLbl;
        private System.Windows.Forms.Label NumberOfClthLbl;
        private System.Windows.Forms.Label BrandinvalidLbl;
        private System.Windows.Forms.Label invalidClothLbl;
        private System.Windows.Forms.Label invIntegerlbl;
        private System.Windows.Forms.TextBox numberTxt;
    }
}