using System.Windows.Forms;

namespace QuanLyPhongKham.GUI
{
    public partial class DonThuoc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel9 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.lvwStockMedicine = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbsSearch = new System.Windows.Forms.TextBox();
            this.btnAddMedicine = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwPrescription = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.label13);
            this.panel9.Location = new System.Drawing.Point(3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1593, 34);
            this.panel9.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(12, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 24);
            this.label13.TabIndex = 2;
            this.label13.Text = "Đơn thuốc";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lvwStockMedicine
            // 
            this.lvwStockMedicine.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvwStockMedicine.FullRowSelect = true;
            this.lvwStockMedicine.GridLines = true;
            this.lvwStockMedicine.HideSelection = false;
            this.lvwStockMedicine.Location = new System.Drawing.Point(19, 134);
            this.lvwStockMedicine.MultiSelect = false;
            this.lvwStockMedicine.Name = "lvwStockMedicine";
            this.lvwStockMedicine.Size = new System.Drawing.Size(840, 235);
            this.lvwStockMedicine.TabIndex = 7;
            this.lvwStockMedicine.UseCompatibleStateImageBehavior = false;
            this.lvwStockMedicine.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Thuốc";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên thuốc";
            this.columnHeader2.Width = 450;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tồn kho";
            this.columnHeader3.Width = 110;
            // 
            // tbsSearch
            // 
            this.tbsSearch.Location = new System.Drawing.Point(105, 62);
            this.tbsSearch.Multiline = true;
            this.tbsSearch.Name = "tbsSearch";
            this.tbsSearch.Size = new System.Drawing.Size(501, 39);
            this.tbsSearch.TabIndex = 8;
            this.tbsSearch.TextChanged += new System.EventHandler(this.tbsSearch_TextChanged);
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddMedicine.Location = new System.Drawing.Point(767, 65);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(92, 39);
            this.btnAddMedicine.TabIndex = 10;
            this.btnAddMedicine.Text = "Thêm";
            this.btnAddMedicine.UseVisualStyleBackColor = false;
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAddMedicine_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(15, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tên thuốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(608, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "SL";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Crimson;
            this.btnReset.Location = new System.Drawing.Point(1457, 377);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 40);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(338, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Danh sách thuốc ";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(641, 74);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(120, 22);
            this.nudQuantity.TabIndex = 14;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwPrescription);
            this.groupBox1.Location = new System.Drawing.Point(901, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 318);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toa thuốc";
            // 
            // lvwPrescription
            // 
            this.lvwPrescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwPrescription.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvwPrescription.GridLines = true;
            this.lvwPrescription.HideSelection = false;
            this.lvwPrescription.Location = new System.Drawing.Point(6, 20);
            this.lvwPrescription.Name = "lvwPrescription";
            this.lvwPrescription.Size = new System.Drawing.Size(670, 292);
            this.lvwPrescription.TabIndex = 0;
            this.lvwPrescription.UseCompatibleStateImageBehavior = false;
            this.lvwPrescription.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mã thuốc";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tên thuốc";
            this.columnHeader5.Width = 320;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Số lượng";
            this.columnHeader6.Width = 80;
            // 
            // DonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddMedicine);
            this.Controls.Add(this.tbsSearch);
            this.Controls.Add(this.lvwStockMedicine);
            this.Controls.Add(this.panel9);
            this.Name = "DonThuoc";
            this.Size = new System.Drawing.Size(1599, 420);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListView lvwStockMedicine;
        private System.Windows.Forms.TextBox tbsSearch;
        private System.Windows.Forms.Button btnAddMedicine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvwPrescription;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}
