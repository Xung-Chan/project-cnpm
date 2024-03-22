using System.Drawing;
namespace QuanLyPhongKham
{
    partial class DangNhap
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
            System.Windows.Forms.Label lblDontHaveAccount;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblCreateAccount = new System.Windows.Forms.LinkLabel();
            this.cbkShowPassword = new System.Windows.Forms.CheckBox();
            this.lblForgetPassword = new System.Windows.Forms.LinkLabel();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            lblDontHaveAccount = new System.Windows.Forms.Label();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDontHaveAccount
            // 
            lblDontHaveAccount.AutoSize = true;
            lblDontHaveAccount.BackColor = System.Drawing.Color.Transparent;
            lblDontHaveAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            lblDontHaveAccount.Location = new System.Drawing.Point(86, 343);
            lblDontHaveAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblDontHaveAccount.Name = "lblDontHaveAccount";
            lblDontHaveAccount.Size = new System.Drawing.Size(157, 17);
            lblDontHaveAccount.TabIndex = 15;
            lblDontHaveAccount.Text = "Bạn chưa có tài khoản?";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangNhap.Location = new System.Drawing.Point(89, 282);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(2);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(322, 46);
            this.btnDangNhap.TabIndex = 12;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHeader.Location = new System.Drawing.Point(151, 37);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(193, 39);
            this.lblHeader.TabIndex = 9;
            this.lblHeader.Text = "Đăng nhập";
            this.lblHeader.Click += new System.EventHandler(this.label2_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlContainer.Controls.Add(this.lblPassword);
            this.pnlContainer.Controls.Add(this.lblUsername);
            this.pnlContainer.Controls.Add(this.lblCreateAccount);
            this.pnlContainer.Controls.Add(lblDontHaveAccount);
            this.pnlContainer.Controls.Add(this.cbkShowPassword);
            this.pnlContainer.Controls.Add(this.lblForgetPassword);
            this.pnlContainer.Controls.Add(this.btnDangNhap);
            this.pnlContainer.Controls.Add(this.tbxPassword);
            this.pnlContainer.Controls.Add(this.tbxUsername);
            this.pnlContainer.Controls.Add(this.lblHeader);
            this.pnlContainer.Location = new System.Drawing.Point(555, 137);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(2);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(433, 401);
            this.pnlContainer.TabIndex = 10;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPassword.Location = new System.Drawing.Point(10, 201);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(75, 20);
            this.lblPassword.TabIndex = 18;
            this.lblPassword.Text = "Mật khẩu";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblUsername.Location = new System.Drawing.Point(10, 132);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(78, 20);
            this.lblUsername.TabIndex = 17;
            this.lblUsername.Text = "Tài khoản";
            // 
            // lblCreateAccount
            // 
            this.lblCreateAccount.AutoSize = true;
            this.lblCreateAccount.BackColor = System.Drawing.Color.Transparent;
            this.lblCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCreateAccount.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblCreateAccount.LinkColor = System.Drawing.Color.Black;
            this.lblCreateAccount.Location = new System.Drawing.Point(244, 344);
            this.lblCreateAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreateAccount.Name = "lblCreateAccount";
            this.lblCreateAccount.Size = new System.Drawing.Size(85, 15);
            this.lblCreateAccount.TabIndex = 16;
            this.lblCreateAccount.TabStop = true;
            this.lblCreateAccount.Text = "Tạo Tài khoản";
            this.lblCreateAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // cbkShowPassword
            // 
            this.cbkShowPassword.AutoSize = true;
            this.cbkShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.cbkShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbkShowPassword.Location = new System.Drawing.Point(304, 251);
            this.cbkShowPassword.Margin = new System.Windows.Forms.Padding(2);
            this.cbkShowPassword.Name = "cbkShowPassword";
            this.cbkShowPassword.Size = new System.Drawing.Size(122, 19);
            this.cbkShowPassword.TabIndex = 14;
            this.cbkShowPassword.Text = "Hiển thị mật khẩu";
            this.cbkShowPassword.UseVisualStyleBackColor = false;
            this.cbkShowPassword.CheckedChanged += new System.EventHandler(this.cbkShowPassword_CheckedChanged);
            // 
            // lblForgetPassword
            // 
            this.lblForgetPassword.AutoSize = true;
            this.lblForgetPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblForgetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblForgetPassword.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblForgetPassword.LinkColor = System.Drawing.Color.Black;
            this.lblForgetPassword.Location = new System.Drawing.Point(333, 345);
            this.lblForgetPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblForgetPassword.Name = "lblForgetPassword";
            this.lblForgetPassword.Size = new System.Drawing.Size(93, 15);
            this.lblForgetPassword.TabIndex = 13;
            this.lblForgetPassword.TabStop = true;
            this.lblForgetPassword.Text = "Quên Mật Khẩu";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.Location = new System.Drawing.Point(89, 192);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbxPassword.Multiline = true;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(326, 37);
            this.tbxPassword.TabIndex = 11;
            this.tbxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPassword_Enter);
            // 
            // tbxUsername
            // 
            this.tbxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsername.Location = new System.Drawing.Point(89, 115);
            this.tbxUsername.Margin = new System.Windows.Forms.Padding(2);
            this.tbxUsername.Multiline = true;
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(325, 37);
            this.tbxUsername.TabIndex = 10;
            this.tbxUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1032, 609);
            this.Controls.Add(this.pnlContainer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DangNhap";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.LinkLabel lblCreateAccount;
        private System.Windows.Forms.CheckBox cbkShowPassword;
        private System.Windows.Forms.LinkLabel lblForgetPassword;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnDangNhap;
    }
}

