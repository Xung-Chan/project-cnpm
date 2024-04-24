using System.Drawing;

namespace QuanLyPhongKham.GUI
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
            this.tbxRole = new System.Windows.Forms.TextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.tbxSdt = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.btnLogup = new System.Windows.Forms.Button();
            this.eyeShowSecond = new System.Windows.Forms.Panel();
            this.eyeHideSecond = new System.Windows.Forms.Panel();
            this.eyeShowFirst = new System.Windows.Forms.Panel();
            this.eyeHideFirst = new System.Windows.Forms.Panel();
            this.tbxPasswordFirst = new System.Windows.Forms.TextBox();
            this.tbxPasswordSecond = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPasswordSeccond = new System.Windows.Forms.Label();
            this.tbxMaUser = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
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
            this.pnlContainer.Location = new System.Drawing.Point(292, 98);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(731, 450);
            this.pnlContainer.TabIndex = 0;
            // 
            // tbxRole
            // 
            this.tbxRole.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tbxRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRole.Location = new System.Drawing.Point(325, 187);
            this.tbxRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxRole.Multiline = true;
            this.tbxRole.Name = "tbxRole";
            this.tbxRole.Size = new System.Drawing.Size(405, 45);
            this.tbxRole.TabIndex = 2;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(204, 22);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(308, 36);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Đăng ký tài khoản mới";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(4, 98);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(190, 36);
            this.lblPhoneNumber.TabIndex = 1;
            this.lblPhoneNumber.Text = "Số điện thoại";
            // 
            // tbxSdt
            // 
            this.tbxSdt.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tbxSdt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSdt.Location = new System.Drawing.Point(325, 89);
            this.tbxSdt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxSdt.Multiline = true;
            this.tbxSdt.Name = "tbxSdt";
            this.tbxSdt.Size = new System.Drawing.Size(405, 45);
            this.tbxSdt.TabIndex = 0;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.BackColor = System.Drawing.Color.Transparent;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(4, 197);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(125, 36);
            this.lblPosition.TabIndex = 3;
            this.lblPosition.Text = "Chức vụ";
            // 
            // btnLogup
            // 
            this.btnLogup.BackColor = System.Drawing.SystemColors.Window;
            this.btnLogup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogup.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogup.Location = new System.Drawing.Point(251, 369);
            this.btnLogup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogup.Name = "btnLogup";
            this.btnLogup.Size = new System.Drawing.Size(244, 54);
            this.btnLogup.TabIndex = 1;
            this.btnLogup.Text = "Đăng ký";
            this.btnLogup.UseVisualStyleBackColor = false;
            this.btnLogup.Click += new System.EventHandler(this.btnLogup_Click);
            // 
            // eyeShowSecond
            // 
            this.eyeShowSecond.BackColor = System.Drawing.Color.PaleTurquoise;
            this.eyeShowSecond.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eyeShowSecond.BackgroundImage")));
            this.eyeShowSecond.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.eyeShowSecond.Controls.Add(this.eyeHideSecond);
            this.eyeShowSecond.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eyeShowSecond.Location = new System.Drawing.Point(691, 292);
            this.eyeShowSecond.Margin = new System.Windows.Forms.Padding(4);
            this.eyeShowSecond.Name = "eyeShowSecond";
            this.eyeShowSecond.Size = new System.Drawing.Size(40, 39);
            this.eyeShowSecond.TabIndex = 0;
            this.eyeShowSecond.Visible = false;
            this.eyeShowSecond.Click += new System.EventHandler(this.eyeShowSecond_Click);
            // 
            // eyeHideSecond
            // 
            this.eyeHideSecond.BackColor = System.Drawing.Color.PaleTurquoise;
            this.eyeHideSecond.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eyeHideSecond.BackgroundImage")));
            this.eyeHideSecond.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eyeHideSecond.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eyeHideSecond.Location = new System.Drawing.Point(1, 0);
            this.eyeHideSecond.Margin = new System.Windows.Forms.Padding(4);
            this.eyeHideSecond.Name = "eyeHideSecond";
            this.eyeHideSecond.Size = new System.Drawing.Size(40, 39);
            this.eyeHideSecond.TabIndex = 2;
            this.eyeHideSecond.Click += new System.EventHandler(this.eyeHideSecond_Click);
            // 
            // eyeShowFirst
            // 
            this.eyeShowFirst.BackColor = System.Drawing.Color.PaleTurquoise;
            this.eyeShowFirst.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eyeShowFirst.BackgroundImage")));
            this.eyeShowFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.eyeShowFirst.Controls.Add(this.eyeHideFirst);
            this.eyeShowFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eyeShowFirst.Location = new System.Drawing.Point(691, 242);
            this.eyeShowFirst.Margin = new System.Windows.Forms.Padding(4);
            this.eyeShowFirst.Name = "eyeShowFirst";
            this.eyeShowFirst.Size = new System.Drawing.Size(40, 39);
            this.eyeShowFirst.TabIndex = 5;
            this.eyeShowFirst.Visible = false;
            this.eyeShowFirst.Click += new System.EventHandler(this.eyeShowFirst_Click);
            // 
            // eyeHideFirst
            // 
            this.eyeHideFirst.BackColor = System.Drawing.Color.PaleTurquoise;
            this.eyeHideFirst.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eyeHideFirst.BackgroundImage")));
            this.eyeHideFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eyeHideFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eyeHideFirst.Location = new System.Drawing.Point(1, 0);
            this.eyeHideFirst.Margin = new System.Windows.Forms.Padding(4);
            this.eyeHideFirst.Name = "eyeHideFirst";
            this.eyeHideFirst.Size = new System.Drawing.Size(40, 39);
            this.eyeHideFirst.TabIndex = 2;
            this.eyeHideFirst.Click += new System.EventHandler(this.eyeHideFirst_Click);
            // 
            // tbxPasswordFirst
            // 
            this.tbxPasswordFirst.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tbxPasswordFirst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPasswordFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPasswordFirst.Location = new System.Drawing.Point(325, 236);
            this.tbxPasswordFirst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPasswordFirst.Multiline = true;
            this.tbxPasswordFirst.Name = "tbxPasswordFirst";
            this.tbxPasswordFirst.PasswordChar = '*';
            this.tbxPasswordFirst.Size = new System.Drawing.Size(405, 45);
            this.tbxPasswordFirst.TabIndex = 3;
            // 
            // tbxPasswordSecond
            // 
            this.tbxPasswordSecond.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tbxPasswordSecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPasswordSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPasswordSecond.Location = new System.Drawing.Point(325, 286);
            this.tbxPasswordSecond.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPasswordSecond.Multiline = true;
            this.tbxPasswordSecond.Name = "tbxPasswordSecond";
            this.tbxPasswordSecond.PasswordChar = '*';
            this.tbxPasswordSecond.Size = new System.Drawing.Size(405, 45);
            this.tbxPasswordSecond.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(4, 246);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(137, 36);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Mật khẩu";
            // 
            // lblPasswordSeccond
            // 
            this.lblPasswordSeccond.AutoSize = true;
            this.lblPasswordSeccond.BackColor = System.Drawing.Color.Transparent;
            this.lblPasswordSeccond.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordSeccond.Location = new System.Drawing.Point(4, 295);
            this.lblPasswordSeccond.Name = "lblPasswordSeccond";
            this.lblPasswordSeccond.Size = new System.Drawing.Size(253, 36);
            this.lblPasswordSeccond.TabIndex = 3;
            this.lblPasswordSeccond.Text = "Nhập lại mật khẩu";
            // 
            // tbxMaUser
            // 
            this.tbxMaUser.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tbxMaUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxMaUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMaUser.Location = new System.Drawing.Point(325, 138);
            this.tbxMaUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxMaUser.Multiline = true;
            this.tbxMaUser.Name = "tbxMaUser";
            this.tbxMaUser.Size = new System.Drawing.Size(405, 45);
            this.tbxMaUser.TabIndex = 1;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(4, 148);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(194, 36);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "Mã nhân viên";
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1261, 673);
            this.Controls.Add(this.pnlContainer);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.TextBox tbxSdt;
        private System.Windows.Forms.TextBox tbxRole;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Button btnLogup;
        private System.Windows.Forms.Panel eyeShowSecond;
        private System.Windows.Forms.Panel eyeHideSecond;
        private System.Windows.Forms.TextBox tbxPasswordSecond;
        private System.Windows.Forms.TextBox tbxMaUser;
        private System.Windows.Forms.Panel eyeShowFirst;
        private System.Windows.Forms.Panel eyeHideFirst;
        private System.Windows.Forms.TextBox tbxPasswordFirst;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPasswordSeccond;
    }
}