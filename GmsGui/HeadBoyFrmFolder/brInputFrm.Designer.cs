
namespace GmsGui.HeadBoyFrmFolder
{
    partial class brInputFrm
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
            this.sumbitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sumbitBtn
            // 
            this.sumbitBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.sumbitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.sumbitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.sumbitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sumbitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumbitBtn.ForeColor = System.Drawing.Color.White;
            this.sumbitBtn.Location = new System.Drawing.Point(198, 218);
            this.sumbitBtn.Name = "sumbitBtn";
            this.sumbitBtn.Size = new System.Drawing.Size(75, 29);
            this.sumbitBtn.TabIndex = 20;
            this.sumbitBtn.Text = "SUBMIT";
            this.sumbitBtn.UseVisualStyleBackColor = true;
            this.sumbitBtn.Click += new System.EventHandler(this.sumbitBtn_Click);
            // 
            // brInputFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(522, 304);
            this.Controls.Add(this.sumbitBtn);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "brInputFrm";
            this.Text = "brandInput";
            this.Load += new System.EventHandler(this.brInputFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button sumbitBtn;
    }
}