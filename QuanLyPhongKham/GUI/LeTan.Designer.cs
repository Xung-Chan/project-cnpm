namespace QuanLyPhongKham.GUI
{
    partial class LeTan
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
            this.components = new System.ComponentModel.Container();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.quanLiHosobenhnhan1 = new QuanLyPhongKham.GUI.QuanLiHoSoBenhhan();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.label13);
            this.panel9.Location = new System.Drawing.Point(3, 1);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1759, 47);
            this.panel9.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(9, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(243, 24);
            this.label13.TabIndex = 2;
            this.label13.Text = "Phòng khám Siu cấp vip pro";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Silver;
            this.panel11.Controls.Add(this.button12);
            this.panel11.Controls.Add(this.button17);
            this.panel11.Controls.Add(this.button29);
            this.panel11.Location = new System.Drawing.Point(12, 66);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(424, 446);
            this.panel11.TabIndex = 7;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Silver;
            this.button12.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button12.Location = new System.Drawing.Point(3, 147);
            this.button12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(419, 63);
            this.button12.TabIndex = 15;
            this.button12.Text = "Thanh toán";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Silver;
            this.button17.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button17.Location = new System.Drawing.Point(3, 78);
            this.button17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(419, 65);
            this.button17.TabIndex = 15;
            this.button17.Text = "Quản lí lịch làm việc bác sĩ";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.Color.Silver;
            this.button29.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button29.Location = new System.Drawing.Point(3, 7);
            this.button29.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(419, 65);
            this.button29.TabIndex = 15;
            this.button29.Text = "Quản lý hồ sơ bệnh nhân";
            this.button29.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Crimson;
            this.btnLogout.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogout.Location = new System.Drawing.Point(21, 182);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnLogout.Size = new System.Drawing.Size(145, 49);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Honeydew;
            this.panel10.Controls.Add(this.btnLogout);
            this.panel10.Location = new System.Drawing.Point(12, 518);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(425, 245);
            this.panel10.TabIndex = 7;
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = global::QuanLyPhongKham.Properties.Resources.N9_NiceNight__1_;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel8.Location = new System.Drawing.Point(1703, 1);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(48, 47);
            this.panel8.TabIndex = 6;
            // 
            // quanLiHosobenhnhan1
            // 
            this.quanLiHosobenhnhan1.Location = new System.Drawing.Point(448, 66);
            this.quanLiHosobenhnhan1.Margin = new System.Windows.Forms.Padding(5);
            this.quanLiHosobenhnhan1.Name = "quanLiHosobenhnhan1";
            this.quanLiHosobenhnhan1.Size = new System.Drawing.Size(1313, 702);
            this.quanLiHosobenhnhan1.TabIndex = 8;
            // 
            // LeTan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1763, 763);
            this.Controls.Add(this.quanLiHosobenhnhan1);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LeTan";
            this.Text = "Letan";
            this.Load += new System.EventHandler(this.Letan_Load);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button button17;
        private QuanLiHoSoBenhhan quanLiHosobenhnhan1;
        private System.Windows.Forms.Timer timer1;
    }
}