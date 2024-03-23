using System.Drawing;

namespace QuanLyPhongKham
{
    partial class DangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKy));
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.eyeShowSecond = new System.Windows.Forms.Panel();
            this.eyeHideSecond = new System.Windows.Forms.Panel();
            this.tbxPasswordSecond = new System.Windows.Forms.TextBox();
            this.tbxMaUser = new System.Windows.Forms.TextBox();
            this.eyeShowFirst = new System.Windows.Forms.Panel();
            this.eyeHideFirst = new System.Windows.Forms.Panel();
            this.tbxRole = new System.Windows.Forms.TextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.tbxPasswordFirst = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.tbxSdt = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPasswordSeccond = new System.Windows.Forms.Label();
            this.btnLogup = new System.Windows.Forms.Button();
            this.pnlContainer.SuspendLayout();
            this.eyeShowSecond.SuspendLayout();
            this.eyeShowFirst.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.pnlContainer.Controls.Add(this.eyeShowSecond);
            this.pnlContainer.Controls.Add(this.tbxPasswordSecond);
            this.pnlContainer.Controls.Add(this.tbxMaUser);
            this.pnlContainer.Controls.Add(this.eyeShowFirst);
            this.pnlContainer.Controls.Add(this.tbxRole);
            this.pnlContainer.Controls.Add(this.lblHeader);
            this.pnlContainer.Controls.Add(this.tbxPasswordFirst);
            this.pnlContainer.Controls.Add(this.lblPhoneNumber);
            this.pnlContainer.Controls.Add(this.lblID);
            this.pnlContainer.Controls.Add(this.tbxSdt);
            this.pnlContainer.Controls.Add(this.lblPosition);
            this.pnlContainer.Controls.Add(this.lblPassword);
            this.pnlContainer.Controls.Add(this.lblPasswordSeccond);
            this.pnlContainer.Controls.Add(this.btnLogup);
            this.pnlContainer.Location = new System.Drawing.Point(219, 80);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(2);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(548, 366);
            this.pnlContainer.TabIndex = 0;
            this.pnlContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // eyeShowSecond
            // 
            this.eyeShowSecond.BackColor = System.Drawing.Color.PaleTurquoise;
            this.eyeShowSecond.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eyeShowSecond.BackgroundImage")));
            this.eyeShowSecond.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.eyeShowSecond.Controls.Add(this.eyeHideSecond);
            this.eyeShowSecond.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eyeShowSecond.Location = new System.Drawing.Point(518, 237);
            this.eyeShowSecond.Name = "eyeShowSecond";
            this.eyeShowSecond.Size = new System.Drawing.Size(30, 32);
            this.eyeShowSecond.TabIndex = 0;
            this.eyeShowSecond.Visible = false;
            this.eyeShowSecond.Click += new System.EventHandler(this.eyeShowSecond_Click);
            this.eyeShowSecond.Paint += new System.Windows.Forms.PaintEventHandler(this.eyeShowSecond_Paint);
            // 
            // eyeHideSecond
            // 
            this.eyeHideSecond.BackColor = System.Drawing.Color.PaleTurquoise;
            this.eyeHideSecond.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eyeHideSecond.BackgroundImage")));
            this.eyeHideSecond.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eyeHideSecond.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eyeHideSecond.Location = new System.Drawing.Point(1, 0);
            this.eyeHideSecond.Name = "eyeHideSecond";
            this.eyeHideSecond.Size = new System.Drawing.Size(30, 32);
            this.eyeHideSecond.TabIndex = 2;
            this.eyeHideSecond.Click += new System.EventHandler(this.eyeHideSecond_Click);
            this.eyeHideSecond.Paint += new System.Windows.Forms.PaintEventHandler(this.eyeHideSecond_Paint);
            // 
            // tbxPasswordSecond
            // 
            this.tbxPasswordSecond.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tbxPasswordSecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPasswordSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPasswordSecond.Location = new System.Drawing.Point(244, 232);
            this.tbxPasswordSecond.Margin = new System.Windows.Forms.Padding(2);
            this.tbxPasswordSecond.Multiline = true;
            this.tbxPasswordSecond.Name = "tbxPasswordSecond";
            this.tbxPasswordSecond.PasswordChar = '*';
            this.tbxPasswordSecond.Size = new System.Drawing.Size(304, 37);
            this.tbxPasswordSecond.TabIndex = 4;
            this.tbxPasswordSecond.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tbxMaUser
            // 
            this.tbxMaUser.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tbxMaUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxMaUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMaUser.Location = new System.Drawing.Point(244, 112);
            this.tbxMaUser.Margin = new System.Windows.Forms.Padding(2);
            this.tbxMaUser.Multiline = true;
            this.tbxMaUser.Name = "tbxMaUser";
            this.tbxMaUser.Size = new System.Drawing.Size(304, 37);
            this.tbxMaUser.TabIndex = 1;
            // 
            // eyeShowFirst
            // 
            this.eyeShowFirst.BackColor = System.Drawing.Color.PaleTurquoise;
            this.eyeShowFirst.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eyeShowFirst.BackgroundImage")));
            this.eyeShowFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.eyeShowFirst.Controls.Add(this.eyeHideFirst);
            this.eyeShowFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eyeShowFirst.Location = new System.Drawing.Point(518, 197);
            this.eyeShowFirst.Name = "eyeShowFirst";
            this.eyeShowFirst.Size = new System.Drawing.Size(30, 32);
            this.eyeShowFirst.TabIndex = 5;
            this.eyeShowFirst.Visible = false;
            this.eyeShowFirst.Click += new System.EventHandler(this.eyeShowFirst_Click);
            this.eyeShowFirst.Paint += new System.Windows.Forms.PaintEventHandler(this.eyeShowFirst_Paint);
            // 
            // eyeHideFirst
            // 
            this.eyeHideFirst.BackColor = System.Drawing.Color.PaleTurquoise;
            this.eyeHideFirst.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eyeHideFirst.BackgroundImage")));
            this.eyeHideFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eyeHideFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eyeHideFirst.Location = new System.Drawing.Point(1, 0);
            this.eyeHideFirst.Name = "eyeHideFirst";
            this.eyeHideFirst.Size = new System.Drawing.Size(30, 32);
            this.eyeHideFirst.TabIndex = 2;
            this.eyeHideFirst.Click += new System.EventHandler(this.eyeHideFirst_Click);
            this.eyeHideFirst.Paint += new System.Windows.Forms.PaintEventHandler(this.eyeHide_Paint);
            // 
            // tbxRole
            // 
            this.tbxRole.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tbxRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRole.Location = new System.Drawing.Point(244, 152);
            this.tbxRole.Margin = new System.Windows.Forms.Padding(2);
            this.tbxRole.Multiline = true;
            this.tbxRole.Name = "tbxRole";
            this.tbxRole.Size = new System.Drawing.Size(304, 37);
            this.tbxRole.TabIndex = 2;
            this.tbxRole.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(153, 18);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(247, 29);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Đăng ký tài khoản mới";
            // 
            // tbxPasswordFirst
            // 
            this.tbxPasswordFirst.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tbxPasswordFirst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPasswordFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPasswordFirst.Location = new System.Drawing.Point(244, 192);
            this.tbxPasswordFirst.Margin = new System.Windows.Forms.Padding(2);
            this.tbxPasswordFirst.Multiline = true;
            this.tbxPasswordFirst.Name = "tbxPasswordFirst";
            this.tbxPasswordFirst.PasswordChar = '*';
            this.tbxPasswordFirst.Size = new System.Drawing.Size(304, 37);
            this.tbxPasswordFirst.TabIndex = 3;
            this.tbxPasswordFirst.TextChanged += new System.EventHandler(this.tbxPasswordFirst_TextChanged);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(3, 80);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(154, 29);
            this.lblPhoneNumber.TabIndex = 1;
            this.lblPhoneNumber.Text = "Số điện thoại";
            this.lblPhoneNumber.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(3, 120);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(154, 29);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "Mã nhân viên";
            this.lblID.Click += new System.EventHandler(this.label6_Click);
            // 
            // tbxSdt
            // 
            this.tbxSdt.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tbxSdt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSdt.Location = new System.Drawing.Point(244, 72);
            this.tbxSdt.Margin = new System.Windows.Forms.Padding(2);
            this.tbxSdt.Multiline = true;
            this.tbxSdt.Name = "tbxSdt";
            this.tbxSdt.Size = new System.Drawing.Size(304, 37);
            this.tbxSdt.TabIndex = 0;
            this.tbxSdt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.BackColor = System.Drawing.Color.Transparent;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(3, 160);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(98, 29);
            this.lblPosition.TabIndex = 3;
            this.lblPosition.Text = "Chức vụ";
            this.lblPosition.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(3, 200);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(109, 29);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Mật khẩu";
            this.lblPassword.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblPasswordSeccond
            // 
            this.lblPasswordSeccond.AutoSize = true;
            this.lblPasswordSeccond.BackColor = System.Drawing.Color.Transparent;
            this.lblPasswordSeccond.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordSeccond.Location = new System.Drawing.Point(3, 240);
            this.lblPasswordSeccond.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPasswordSeccond.Name = "lblPasswordSeccond";
            this.lblPasswordSeccond.Size = new System.Drawing.Size(204, 29);
            this.lblPasswordSeccond.TabIndex = 3;
            this.lblPasswordSeccond.Text = "Nhập lại mật khẩu";
            this.lblPasswordSeccond.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnLogup
            // 
            this.btnLogup.BackColor = System.Drawing.SystemColors.Window;
            this.btnLogup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogup.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogup.Location = new System.Drawing.Point(188, 300);
            this.btnLogup.Name = "btnLogup";
            this.btnLogup.Size = new System.Drawing.Size(183, 44);
            this.btnLogup.TabIndex = 1;
            this.btnLogup.Text = "Đăng ký";
            this.btnLogup.UseVisualStyleBackColor = false;
            this.btnLogup.Click += new System.EventHandler(this.btnLogup_Click);
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.pnlContainer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DangKy";
            this.Text = "DangKy";
            this.Load += new System.EventHandler(this.DangKy_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.eyeShowSecond.ResumeLayout(false);
            this.eyeShowFirst.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox tbxPasswordSecond;
        private System.Windows.Forms.TextBox tbxPasswordFirst;
        private System.Windows.Forms.TextBox tbxSdt;
        private System.Windows.Forms.Panel eyeHideSecond;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox tbxRole;
        private System.Windows.Forms.Panel eyeShowFirst;
        private System.Windows.Forms.Panel eyeShowSecond;
        private System.Windows.Forms.Panel eyeHideFirst;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPasswordSeccond;
        private System.Windows.Forms.TextBox tbxMaUser;
        private System.Windows.Forms.Button btnLogup;
    }
}