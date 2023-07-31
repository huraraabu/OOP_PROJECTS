
namespace GmsGui.customerFrmFolder
{
    partial class PurchasinFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchasinFrm));
            this.purchasingGrid = new System.Windows.Forms.DataGridView();
            this.purhasingLbl = new System.Windows.Forms.Label();
            this.backtoBrand = new System.Windows.Forms.PictureBox();
            this.purPln = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.FeedbackPln = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.FeedbackTxt = new System.Windows.Forms.TextBox();
            this.feedbackLbl = new System.Windows.Forms.Label();
            this.Addbtn = new System.Windows.Forms.Button();
            this.FeedbackBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.purchasingGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backtoBrand)).BeginInit();
            this.purPln.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.FeedbackPln.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeedbackBack)).BeginInit();
            this.SuspendLayout();
            // 
            // purchasingGrid
            // 
            this.purchasingGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.purchasingGrid.BackgroundColor = System.Drawing.Color.DarkRed;
            this.purchasingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchasingGrid.Location = new System.Drawing.Point(26, 80);
            this.purchasingGrid.MultiSelect = false;
            this.purchasingGrid.Name = "purchasingGrid";
            this.purchasingGrid.ReadOnly = true;
            this.purchasingGrid.RowHeadersVisible = false;
            this.purchasingGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.purchasingGrid.Size = new System.Drawing.Size(735, 302);
            this.purchasingGrid.TabIndex = 0;
            this.purchasingGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.purchasingGrid_CellContentClick);
            // 
            // purhasingLbl
            // 
            this.purhasingLbl.AutoSize = true;
            this.purhasingLbl.BackColor = System.Drawing.Color.Black;
            this.purhasingLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purhasingLbl.ForeColor = System.Drawing.Color.White;
            this.purhasingLbl.Location = new System.Drawing.Point(249, 28);
            this.purhasingLbl.Name = "purhasingLbl";
            this.purhasingLbl.Size = new System.Drawing.Size(282, 26);
            this.purhasingLbl.TabIndex = 1;
            this.purhasingLbl.Text = "PURCHASING HISTORY";
            // 
            // backtoBrand
            // 
            this.backtoBrand.BackColor = System.Drawing.Color.White;
            this.backtoBrand.BackgroundImage = global::GmsGui.Properties.Resources.sl;
            this.backtoBrand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backtoBrand.Location = new System.Drawing.Point(1, 0);
            this.backtoBrand.Name = "backtoBrand";
            this.backtoBrand.Size = new System.Drawing.Size(39, 38);
            this.backtoBrand.TabIndex = 34;
            this.backtoBrand.TabStop = false;
            this.backtoBrand.Click += new System.EventHandler(this.backtoBrand_Click);
            // 
            // purPln
            // 
            this.purPln.Controls.Add(this.button3);
            this.purPln.Controls.Add(this.pictureBox3);
            this.purPln.Location = new System.Drawing.Point(291, 395);
            this.purPln.Name = "purPln";
            this.purPln.Size = new System.Drawing.Size(180, 43);
            this.purPln.TabIndex = 35;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(48, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 32);
            this.button3.TabIndex = 18;
            this.button3.Text = "RETURN PRODUCT";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 38);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // FeedbackPln
            // 
            this.FeedbackPln.Controls.Add(this.button1);
            this.FeedbackPln.Controls.Add(this.pictureBox9);
            this.FeedbackPln.Location = new System.Drawing.Point(291, 392);
            this.FeedbackPln.Name = "FeedbackPln";
            this.FeedbackPln.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FeedbackPln.Size = new System.Drawing.Size(182, 43);
            this.FeedbackPln.TabIndex = 19;
            this.FeedbackPln.Paint += new System.Windows.Forms.PaintEventHandler(this.FeedbackPln_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(52, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 32);
            this.button1.TabIndex = 18;
            this.button1.Text = "GIVE FEEDBACK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.White;
            this.pictureBox9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox9.BackgroundImage")));
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Location = new System.Drawing.Point(3, 2);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(43, 38);
            this.pictureBox9.TabIndex = 3;
            this.pictureBox9.TabStop = false;
            // 
            // FeedbackTxt
            // 
            this.FeedbackTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeedbackTxt.Location = new System.Drawing.Point(356, 209);
            this.FeedbackTxt.Multiline = true;
            this.FeedbackTxt.Name = "FeedbackTxt";
            this.FeedbackTxt.Size = new System.Drawing.Size(230, 26);
            this.FeedbackTxt.TabIndex = 36;
            // 
            // feedbackLbl
            // 
            this.feedbackLbl.AutoSize = true;
            this.feedbackLbl.BackColor = System.Drawing.Color.DarkRed;
            this.feedbackLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackLbl.ForeColor = System.Drawing.Color.White;
            this.feedbackLbl.Location = new System.Drawing.Point(110, 209);
            this.feedbackLbl.Name = "feedbackLbl";
            this.feedbackLbl.Size = new System.Drawing.Size(224, 20);
            this.feedbackLbl.TabIndex = 37;
            this.feedbackLbl.Text = "ENTER YOUR FEEDBACK";
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.DarkRed;
            this.Addbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Addbtn.FlatAppearance.BorderSize = 2;
            this.Addbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.ForeColor = System.Drawing.Color.White;
            this.Addbtn.Location = new System.Drawing.Point(306, 283);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(121, 32);
            this.Addbtn.TabIndex = 38;
            this.Addbtn.Text = "ADD";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // FeedbackBack
            // 
            this.FeedbackBack.BackColor = System.Drawing.Color.White;
            this.FeedbackBack.BackgroundImage = global::GmsGui.Properties.Resources.sl;
            this.FeedbackBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FeedbackBack.Location = new System.Drawing.Point(1, 0);
            this.FeedbackBack.Name = "FeedbackBack";
            this.FeedbackBack.Size = new System.Drawing.Size(39, 38);
            this.FeedbackBack.TabIndex = 39;
            this.FeedbackBack.TabStop = false;
            this.FeedbackBack.Visible = false;
            this.FeedbackBack.Click += new System.EventHandler(this.FeedbackBack_Click);
            // 
            // PurchasinFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FeedbackBack);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.feedbackLbl);
            this.Controls.Add(this.FeedbackTxt);
            this.Controls.Add(this.FeedbackPln);
            this.Controls.Add(this.purPln);
            this.Controls.Add(this.backtoBrand);
            this.Controls.Add(this.purhasingLbl);
            this.Controls.Add(this.purchasingGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PurchasinFrm";
            this.Text = "PurchasinFrm";
            this.Load += new System.EventHandler(this.PurchasinFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.purchasingGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backtoBrand)).EndInit();
            this.purPln.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.FeedbackPln.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeedbackBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView purchasingGrid;
        private System.Windows.Forms.Label purhasingLbl;
        private System.Windows.Forms.PictureBox backtoBrand;
        private System.Windows.Forms.Panel purPln;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel FeedbackPln;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.TextBox FeedbackTxt;
        private System.Windows.Forms.Label feedbackLbl;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.PictureBox FeedbackBack;
    }
}