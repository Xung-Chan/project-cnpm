namespace QuanLyPhongKham.GUI {
    partial class QuanLyNhanVien {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnListEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListEmployee
            // 
            this.btnListEmployee.Location = new System.Drawing.Point(195, 261);
            this.btnListEmployee.Name = "btnListEmployee";
            this.btnListEmployee.Size = new System.Drawing.Size(221, 76);
            this.btnListEmployee.TabIndex = 0;
            this.btnListEmployee.Text = "Danh sách nhân viên";
            this.btnListEmployee.UseVisualStyleBackColor = true;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(634, 261);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(233, 76);
            this.btnAddEmployee.TabIndex = 1;
            this.btnAddEmployee.Text = "Thêm nhân viên";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.Location = new System.Drawing.Point(1093, 261);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(184, 76);
            this.btnAttendance.TabIndex = 2;
            this.btnAttendance.Text = "Dữ liệu điểm danh";
            this.btnAttendance.UseVisualStyleBackColor = true;
            // 
            // QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAttendance);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnListEmployee);
            this.Name = "QuanLyNhanVien";
            this.Size = new System.Drawing.Size(1539, 745);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnAttendance;
    }
}
