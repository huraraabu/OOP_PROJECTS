
namespace GmsGui
{
    partial class loginFrm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.homePng = new System.Windows.Forms.PictureBox();
            this.shopNamelbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.loginLbl = new System.Windows.Forms.Label();
            this.signupLnk = new System.Windows.Forms.LinkLabel();
            this.invalidUserLbl = new System.Windows.Forms.Label();
            this.INPassLbl = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.passwordPng = new System.Windows.Forms.PictureBox();
            this.SignInPasswordTxt = new System.Windows.Forms.TextBox();
            this.passLbl = new System.Windows.Forms.Label();
            this.userPng = new System.Windows.Forms.PictureBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.userName_txt = new System.Windows.Forms.TextBox();
            this.logni_Lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homePng)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPng)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.homePng);
            this.panel1.Controls.Add(this.shopNamelbl);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 446);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 33);
            this.button1.TabIndex = 15;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Exit_Click_1);
            // 
            // homePng
            // 
            this.homePng.BackgroundImage = global::GmsGui.Properties.Resources.icons8_shop_94;
            this.homePng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homePng.Location = new System.Drawing.Point(43, 135);
            this.homePng.Name = "homePng";
            this.homePng.Size = new System.Drawing.Size(157, 172);
            this.homePng.TabIndex = 1;
            this.homePng.TabStop = false;
            // 
            // shopNamelbl
            // 
            this.shopNamelbl.AutoSize = true;
            this.shopNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopNamelbl.ForeColor = System.Drawing.Color.FloralWhite;
            this.shopNamelbl.Location = new System.Drawing.Point(0, 48);
            this.shopNamelbl.Name = "shopNamelbl";
            this.shopNamelbl.Size = new System.Drawing.Size(239, 25);
            this.shopNamelbl.TabIndex = 0;
            this.shopNamelbl.Text = "CO PAKISTANI SHOP";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.loginLbl);
            this.panel2.Controls.Add(this.signupLnk);
            this.panel2.Controls.Add(this.invalidUserLbl);
            this.panel2.Controls.Add(this.INPassLbl);
            this.panel2.Controls.Add(this.loginBtn);
            this.panel2.Controls.Add(this.passwordPng);
            this.panel2.Controls.Add(this.SignInPasswordTxt);
            this.panel2.Controls.Add(this.passLbl);
            this.panel2.Controls.Add(this.userPng);
            this.panel2.Controls.Add(this.nameLbl);
            this.panel2.Controls.Add(this.userName_txt);
            this.panel2.Controls.Add(this.logni_Lbl);
            this.panel2.Location = new System.Drawing.Point(238, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 446);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.BackColor = System.Drawing.Color.Black;
            this.loginLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLbl.ForeColor = System.Drawing.Color.White;
            this.loginLbl.Location = new System.Drawing.Point(199, 24);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(138, 24);
            this.loginLbl.TabIndex = 15;
            this.loginLbl.Text = "LOGIN MENU";
            // 
            // signupLnk
            // 
            this.signupLnk.AutoSize = true;
            this.signupLnk.LinkColor = System.Drawing.Color.White;
            this.signupLnk.Location = new System.Drawing.Point(258, 368);
            this.signupLnk.Name = "signupLnk";
            this.signupLnk.Size = new System.Drawing.Size(106, 13);
            this.signupLnk.TabIndex = 14;
            this.signupLnk.TabStop = true;
            this.signupLnk.Text = "Create New Account";
            this.signupLnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signupLnk_LinkClicked_1);
            // 
            // invalidUserLbl
            // 
            this.invalidUserLbl.AutoSize = true;
            this.invalidUserLbl.ForeColor = System.Drawing.Color.Red;
            this.invalidUserLbl.Location = new System.Drawing.Point(231, 174);
            this.invalidUserLbl.Name = "invalidUserLbl";
            this.invalidUserLbl.Size = new System.Drawing.Size(94, 13);
            this.invalidUserLbl.TabIndex = 13;
            this.invalidUserLbl.Text = "Invalid User Name";
            this.invalidUserLbl.Visible = false;
            // 
            // INPassLbl
            // 
            this.INPassLbl.AutoSize = true;
            this.INPassLbl.ForeColor = System.Drawing.Color.Red;
            this.INPassLbl.Location = new System.Drawing.Point(231, 266);
            this.INPassLbl.Name = "INPassLbl";
            this.INPassLbl.Size = new System.Drawing.Size(87, 13);
            this.INPassLbl.TabIndex = 12;
            this.INPassLbl.Text = "Invalid Password";
            this.INPassLbl.Visible = false;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Black;
            this.loginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.loginBtn.FlatAppearance.BorderSize = 2;
            this.loginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.loginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(234, 316);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(156, 33);
            this.loginBtn.TabIndex = 9;
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // passwordPng
            // 
            this.passwordPng.BackColor = System.Drawing.Color.White;
            this.passwordPng.BackgroundImage = global::GmsGui.Properties.Resources.password;
            this.passwordPng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.passwordPng.Image = global::GmsGui.Properties.Resources.password;
            this.passwordPng.Location = new System.Drawing.Point(61, 230);
            this.passwordPng.Name = "passwordPng";
            this.passwordPng.Size = new System.Drawing.Size(47, 41);
            this.passwordPng.TabIndex = 7;
            this.passwordPng.TabStop = false;
            // 
            // SignInPasswordTxt
            // 
            this.SignInPasswordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInPasswordTxt.Location = new System.Drawing.Point(234, 243);
            this.SignInPasswordTxt.Name = "SignInPasswordTxt";
            this.SignInPasswordTxt.PasswordChar = '*';
            this.SignInPasswordTxt.Size = new System.Drawing.Size(165, 23);
            this.SignInPasswordTxt.TabIndex = 6;
            // 
            // passLbl
            // 
            this.passLbl.AutoSize = true;
            this.passLbl.BackColor = System.Drawing.Color.Transparent;
            this.passLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLbl.ForeColor = System.Drawing.Color.FloralWhite;
            this.passLbl.Location = new System.Drawing.Point(120, 246);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(86, 20);
            this.passLbl.TabIndex = 5;
            this.passLbl.Text = "Password";
            // 
            // userPng
            // 
            this.userPng.BackgroundImage = global::GmsGui.Properties.Resources.icons8_username;
            this.userPng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.userPng.Location = new System.Drawing.Point(61, 135);
            this.userPng.Name = "userPng";
            this.userPng.Size = new System.Drawing.Size(47, 47);
            this.userPng.TabIndex = 4;
            this.userPng.TabStop = false;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.BackColor = System.Drawing.Color.Transparent;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.ForeColor = System.Drawing.Color.FloralWhite;
            this.nameLbl.Location = new System.Drawing.Point(114, 147);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(105, 24);
            this.nameLbl.TabIndex = 3;
            this.nameLbl.Text = "User Name";
            // 
            // userName_txt
            // 
            this.userName_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName_txt.Location = new System.Drawing.Point(234, 151);
            this.userName_txt.Name = "userName_txt";
            this.userName_txt.Size = new System.Drawing.Size(156, 23);
            this.userName_txt.TabIndex = 2;
            this.userName_txt.Text = "Enter user name ..";
            this.userName_txt.TextChanged += new System.EventHandler(this.userName_txt_TextChanged);
            this.userName_txt.MouseEnter += new System.EventHandler(this.userName_txt_MouseEnter);
            // 
            // logni_Lbl
            // 
            this.logni_Lbl.AutoSize = true;
            this.logni_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logni_Lbl.Location = new System.Drawing.Point(239, 38);
            this.logni_Lbl.Name = "logni_Lbl";
            this.logni_Lbl.Size = new System.Drawing.Size(64, 20);
            this.logni_Lbl.TabIndex = 0;
            this.logni_Lbl.Text = "LOGIN";
            // 
            // loginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginFrm";
            this.Text = "loginFrm";
            this.Load += new System.EventHandler(this.loginFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homePng)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPng)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label shopNamelbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox userName_txt;
        private System.Windows.Forms.Label logni_Lbl;
        private System.Windows.Forms.PictureBox userPng;
        private System.Windows.Forms.PictureBox passwordPng;
        private System.Windows.Forms.TextBox SignInPasswordTxt;
        private System.Windows.Forms.Label passLbl;
        private System.Windows.Forms.PictureBox homePng;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label invalidUserLbl;
        private System.Windows.Forms.Label INPassLbl;
        private System.Windows.Forms.LinkLabel signupLnk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label loginLbl;
    }
}