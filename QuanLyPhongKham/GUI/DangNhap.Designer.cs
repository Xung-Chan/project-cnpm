using System.Drawing;
namespace QuanLyPhongKham.GUI
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
            this.tbxPhoneNumber = new System.Windows.Forms.TextBox();
            lblDontHaveAccount = new System.Windows.Forms.Label();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDontHaveAccount
            // 
            lblDontHaveAccount.AutoSize = true;
            lblDontHaveAccount.BackColor = System.Drawing.Color.Transparent;
            lblDontHaveAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            lblDontHaveAccount.Location = new System.Drawing.Point(115, 422);
            lblDontHaveAccount.Name = "lblDontHaveAccount";
            lblDontHaveAccount.Size = new System.Drawing.Size(184, 20);
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
            this.btnDangNhap.Location = new System.Drawing.Point(119, 347);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(429, 57);
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
            this.lblHeader.Location = new System.Drawing.Point(201, 46);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(241, 51);
            this.lblHeader.TabIndex = 9;
            this.lblHeader.Text = "Đăng nhập";
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
            this.pnlContainer.Controls.Add(this.tbxPhoneNumber);
            this.pnlContainer.Controls.Add(this.lblHeader);
            this.pnlContainer.Location = new System.Drawing.Point(740, 169);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(577, 494);
            this.pnlContainer.TabIndex = 10;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPassword.Location = new System.Drawing.Point(13, 247);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(93, 25);
            this.lblPassword.TabIndex = 18;
            this.lblPassword.Text = "Mật khẩu";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblUsername.Location = new System.Drawing.Point(3, 150);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(126, 25);
            this.lblUsername.TabIndex = 17;
            this.lblUsername.Text = "Số điện thoại";
            // 
            // lblCreateAccount
            // 
            this.lblCreateAccount.AutoSize = true;
            this.lblCreateAccount.BackColor = System.Drawing.Color.Transparent;
            this.lblCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCreateAccount.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblCreateAccount.LinkColor = System.Drawing.Color.Black;
            this.lblCreateAccount.Location = new System.Drawing.Point(325, 423);
            this.lblCreateAccount.Name = "lblCreateAccount";
            this.lblCreateAccount.Size = new System.Drawing.Size(103, 18);
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
            this.cbkShowPassword.Location = new System.Drawing.Point(405, 309);
            this.cbkShowPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbkShowPassword.Name = "cbkShowPassword";
            this.cbkShowPassword.Size = new System.Drawing.Size(144, 22);
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
            this.lblForgetPassword.Location = new System.Drawing.Point(444, 425);
            this.lblForgetPassword.Name = "lblForgetPassword";
            this.lblForgetPassword.Size = new System.Drawing.Size(111, 18);
            this.lblForgetPassword.TabIndex = 13;
            this.lblForgetPassword.TabStop = true;
            this.lblForgetPassword.Text = "Quên Mật Khẩu";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.Location = new System.Drawing.Point(154, 236);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPassword.Multiline = true;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(398, 45);
            this.tbxPassword.TabIndex = 11;
            this.tbxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPassword_Enter);
            // 
            // tbxPhoneNumber
            // 
            this.tbxPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPhoneNumber.Location = new System.Drawing.Point(154, 142);
            this.tbxPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPhoneNumber.Multiline = true;
            this.tbxPhoneNumber.Name = "tbxPhoneNumber";
            this.tbxPhoneNumber.Size = new System.Drawing.Size(398, 45);
            this.tbxPhoneNumber.TabIndex = 10;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1376, 750);
            this.Controls.Add(this.pnlContainer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.TextBox tbxPhoneNumber;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnDangNhap;
    }
}

