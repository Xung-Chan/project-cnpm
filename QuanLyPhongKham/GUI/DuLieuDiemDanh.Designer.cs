namespace QuanLyPhongKham.GUI {
    partial class DuLieuDiemDanh {
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
            this.lvwAttendance = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvwAttendance
            // 
            this.lvwAttendance.GridLines = true;
            this.lvwAttendance.HideSelection = false;
            this.lvwAttendance.Location = new System.Drawing.Point(24, 137);
            this.lvwAttendance.Name = "lvwAttendance";
            this.lvwAttendance.Size = new System.Drawing.Size(696, 349);
            this.lvwAttendance.TabIndex = 0;
            this.lvwAttendance.UseCompatibleStateImageBehavior = false;
            this.lvwAttendance.View = System.Windows.Forms.View.Details;
            // 
            // DuLieuDiemDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvwAttendance);
            this.Name = "DuLieuDiemDanh";
            this.Size = new System.Drawing.Size(758, 509);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwAttendance;
    }
}
