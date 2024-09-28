namespace TestVerDoAn
{
    partial class frmQuanLyKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyKH));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsvDanhSach = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiaChiKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.rounded1 = new khanhtoan.rounded();
            this.label3 = new System.Windows.Forms.Label();
            this.rounded2 = new khanhtoan.rounded();
            this.rounded3 = new khanhtoan.rounded();
            this.rounded4 = new khanhtoan.rounded();
            this.btnLMoi1 = new TestVerDoAn.VBButton();
            this.btnSuaKH1 = new TestVerDoAn.VBButton();
            this.btnXoaKH1 = new TestVerDoAn.VBButton();
            this.btnThemKH1 = new TestVerDoAn.VBButton();
            this.btnTim1 = new TestVerDoAn.VBButton();
            this.vbButton1 = new TestVerDoAn.VBButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsvDanhSach);
            this.groupBox1.Location = new System.Drawing.Point(67, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khách Hàng";
            // 
            // lsvDanhSach
            // 
            this.lsvDanhSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lsvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvDanhSach.FullRowSelect = true;
            this.lsvDanhSach.GridLines = true;
            this.lsvDanhSach.HideSelection = false;
            this.lsvDanhSach.Location = new System.Drawing.Point(3, 16);
            this.lsvDanhSach.Name = "lsvDanhSach";
            this.lsvDanhSach.Size = new System.Drawing.Size(623, 214);
            this.lsvDanhSach.TabIndex = 0;
            this.lsvDanhSach.UseCompatibleStateImageBehavior = false;
            this.lsvDanhSach.View = System.Windows.Forms.View.Details;
            this.lsvDanhSach.SelectedIndexChanged += new System.EventHandler(this.lsvDanhSach_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã KH";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên KH";
            this.columnHeader2.Width = 124;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quốc Tịch";
            this.columnHeader3.Width = 73;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Địa Chỉ";
            this.columnHeader4.Width = 168;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "SĐT";
            this.columnHeader5.Width = 94;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Giới Tính";
            this.columnHeader6.Width = 98;
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSDTKH.Location = new System.Drawing.Point(466, 90);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(100, 13);
            this.txtSDTKH.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(456, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Số Điện Thoại";
            // 
            // txtDiaChiKH
            // 
            this.txtDiaChiKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiaChiKH.Location = new System.Drawing.Point(306, 90);
            this.txtDiaChiKH.Name = "txtDiaChiKH";
            this.txtDiaChiKH.Size = new System.Drawing.Size(100, 13);
            this.txtDiaChiKH.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Địa Chỉ KH";
            // 
            // txtTenKH
            // 
            this.txtTenKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenKH.Location = new System.Drawing.Point(149, 90);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(100, 13);
            this.txtTenKH.TabIndex = 20;
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.BackColor = System.Drawing.SystemColors.Window;
            this.lblTenKH.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKH.Location = new System.Drawing.Point(135, 65);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(96, 15);
            this.lblTenKH.TabIndex = 19;
            this.lblTenKH.Text = "Tên Khách Hàng";
            // 
            // rounded1
            // 
            this.rounded1.BackColor = System.Drawing.SystemColors.Window;
            this.rounded1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rounded1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rounded1.BorderRadius = 15;
            this.rounded1.BorderSize = 2;
            this.rounded1.Location = new System.Drawing.Point(67, 15);
            this.rounded1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rounded1.Name = "rounded1";
            this.rounded1.PasswordChar = false;
            this.rounded1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rounded1.PlaceholderText = "";
            this.rounded1.Size = new System.Drawing.Size(639, 102);
            this.rounded1.TabIndex = 26;
            this.rounded1.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(92, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "     Quản Lý Khách Hàng";
            // 
            // rounded2
            // 
            this.rounded2.BackColor = System.Drawing.SystemColors.Window;
            this.rounded2.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rounded2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rounded2.BorderRadius = 10;
            this.rounded2.BorderSize = 2;
            this.rounded2.Location = new System.Drawing.Point(137, 84);
            this.rounded2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rounded2.Name = "rounded2";
            this.rounded2.PasswordChar = false;
            this.rounded2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rounded2.PlaceholderText = "";
            this.rounded2.Size = new System.Drawing.Size(124, 25);
            this.rounded2.TabIndex = 28;
            this.rounded2.UnderlinedStyle = false;
            // 
            // rounded3
            // 
            this.rounded3.BackColor = System.Drawing.SystemColors.Window;
            this.rounded3.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rounded3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rounded3.BorderRadius = 10;
            this.rounded3.BorderSize = 2;
            this.rounded3.Location = new System.Drawing.Point(293, 84);
            this.rounded3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rounded3.Name = "rounded3";
            this.rounded3.PasswordChar = false;
            this.rounded3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rounded3.PlaceholderText = "";
            this.rounded3.Size = new System.Drawing.Size(124, 25);
            this.rounded3.TabIndex = 29;
            this.rounded3.UnderlinedStyle = false;
            // 
            // rounded4
            // 
            this.rounded4.BackColor = System.Drawing.SystemColors.Window;
            this.rounded4.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rounded4.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rounded4.BorderRadius = 10;
            this.rounded4.BorderSize = 2;
            this.rounded4.Location = new System.Drawing.Point(453, 84);
            this.rounded4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rounded4.Name = "rounded4";
            this.rounded4.PasswordChar = false;
            this.rounded4.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rounded4.PlaceholderText = "";
            this.rounded4.Size = new System.Drawing.Size(124, 25);
            this.rounded4.TabIndex = 30;
            this.rounded4.UnderlinedStyle = false;
            // 
            // btnLMoi1
            // 
            this.btnLMoi1.BackColor = System.Drawing.SystemColors.Control;
            this.btnLMoi1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnLMoi1.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLMoi1.BorderRadius = 10;
            this.btnLMoi1.BorderSize = 1;
            this.btnLMoi1.FlatAppearance.BorderSize = 0;
            this.btnLMoi1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLMoi1.ForeColor = System.Drawing.Color.Black;
            this.btnLMoi1.Location = new System.Drawing.Point(66, 387);
            this.btnLMoi1.Name = "btnLMoi1";
            this.btnLMoi1.Size = new System.Drawing.Size(87, 29);
            this.btnLMoi1.TabIndex = 32;
            this.btnLMoi1.Text = "Làm Mới";
            this.btnLMoi1.TextColor = System.Drawing.Color.Black;
            this.btnLMoi1.UseVisualStyleBackColor = false;
            this.btnLMoi1.Click += new System.EventHandler(this.btnLMoi1_Click);
            // 
            // btnSuaKH1
            // 
            this.btnSuaKH1.BackColor = System.Drawing.SystemColors.Control;
            this.btnSuaKH1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnSuaKH1.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSuaKH1.BorderRadius = 10;
            this.btnSuaKH1.BorderSize = 1;
            this.btnSuaKH1.FlatAppearance.BorderSize = 0;
            this.btnSuaKH1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaKH1.ForeColor = System.Drawing.Color.Black;
            this.btnSuaKH1.Location = new System.Drawing.Point(597, 387);
            this.btnSuaKH1.Name = "btnSuaKH1";
            this.btnSuaKH1.Size = new System.Drawing.Size(97, 29);
            this.btnSuaKH1.TabIndex = 33;
            this.btnSuaKH1.Text = "Sửa Khách Hàng";
            this.btnSuaKH1.TextColor = System.Drawing.Color.Black;
            this.btnSuaKH1.UseVisualStyleBackColor = false;
            this.btnSuaKH1.Click += new System.EventHandler(this.btnSuaKH1_Click);
            // 
            // btnXoaKH1
            // 
            this.btnXoaKH1.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoaKH1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnXoaKH1.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXoaKH1.BorderRadius = 10;
            this.btnXoaKH1.BorderSize = 1;
            this.btnXoaKH1.FlatAppearance.BorderSize = 0;
            this.btnXoaKH1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaKH1.ForeColor = System.Drawing.Color.Black;
            this.btnXoaKH1.Location = new System.Drawing.Point(411, 387);
            this.btnXoaKH1.Name = "btnXoaKH1";
            this.btnXoaKH1.Size = new System.Drawing.Size(110, 29);
            this.btnXoaKH1.TabIndex = 34;
            this.btnXoaKH1.Text = "Xóa Khách Hàng";
            this.btnXoaKH1.TextColor = System.Drawing.Color.Black;
            this.btnXoaKH1.UseVisualStyleBackColor = false;
            this.btnXoaKH1.Click += new System.EventHandler(this.btnXoaKH1_Click);
            // 
            // btnThemKH1
            // 
            this.btnThemKH1.BackColor = System.Drawing.SystemColors.Control;
            this.btnThemKH1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnThemKH1.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThemKH1.BorderRadius = 10;
            this.btnThemKH1.BorderSize = 1;
            this.btnThemKH1.FlatAppearance.BorderSize = 0;
            this.btnThemKH1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemKH1.ForeColor = System.Drawing.Color.Black;
            this.btnThemKH1.Location = new System.Drawing.Point(229, 387);
            this.btnThemKH1.Name = "btnThemKH1";
            this.btnThemKH1.Size = new System.Drawing.Size(106, 29);
            this.btnThemKH1.TabIndex = 35;
            this.btnThemKH1.Text = "Thêm Khách Hàng";
            this.btnThemKH1.TextColor = System.Drawing.Color.Black;
            this.btnThemKH1.UseVisualStyleBackColor = false;
            this.btnThemKH1.Click += new System.EventHandler(this.btnThemKH1_Click);
            // 
            // btnTim1
            // 
            this.btnTim1.BackColor = System.Drawing.SystemColors.Control;
            this.btnTim1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnTim1.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTim1.BorderRadius = 10;
            this.btnTim1.BorderSize = 1;
            this.btnTim1.FlatAppearance.BorderSize = 0;
            this.btnTim1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim1.ForeColor = System.Drawing.Color.Black;
            this.btnTim1.Location = new System.Drawing.Point(604, 80);
            this.btnTim1.Name = "btnTim1";
            this.btnTim1.Size = new System.Drawing.Size(87, 29);
            this.btnTim1.TabIndex = 36;
            this.btnTim1.Text = "Tìm KH";
            this.btnTim1.TextColor = System.Drawing.Color.Black;
            this.btnTim1.UseVisualStyleBackColor = false;
            this.btnTim1.Click += new System.EventHandler(this.btnTim1_Click);
            // 
            // vbButton1
            // 
            this.vbButton1.BackColor = System.Drawing.SystemColors.Window;
            this.vbButton1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.vbButton1.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.vbButton1.BorderRadius = 10;
            this.vbButton1.BorderSize = 1;
            this.vbButton1.FlatAppearance.BorderSize = 0;
            this.vbButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton1.ForeColor = System.Drawing.Color.Black;
            this.vbButton1.Image = global::TestVerDoAn.Properties.Resources.logo1;
            this.vbButton1.Location = new System.Drawing.Point(3, 17);
            this.vbButton1.Name = "vbButton1";
            this.vbButton1.Size = new System.Drawing.Size(59, 55);
            this.vbButton1.TabIndex = 37;
            this.vbButton1.TextColor = System.Drawing.Color.Black;
            this.vbButton1.UseVisualStyleBackColor = false;
            this.vbButton1.Click += new System.EventHandler(this.vbButton1_Click);
            // 
            // frmQuanLyKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.vbButton1);
            this.Controls.Add(this.btnTim1);
            this.Controls.Add(this.btnThemKH1);
            this.Controls.Add(this.btnXoaKH1);
            this.Controls.Add(this.btnSuaKH1);
            this.Controls.Add(this.btnLMoi1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSDTKH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiaChiKH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.lblTenKH);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rounded4);
            this.Controls.Add(this.rounded3);
            this.Controls.Add(this.rounded2);
            this.Controls.Add(this.rounded1);
            this.Name = "frmQuanLyKH";
            this.Text = "frmQuanLyKH";
            this.Load += new System.EventHandler(this.frmQuanLyKH_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lsvDanhSach;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox txtSDTKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiaChiKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label lblTenKH;
        private khanhtoan.rounded rounded1;
        private System.Windows.Forms.Label label3;
        private khanhtoan.rounded rounded2;
        private khanhtoan.rounded rounded3;
        private khanhtoan.rounded rounded4;
        private VBButton btnLMoi1;
        private VBButton btnSuaKH1;
        private VBButton btnXoaKH1;
        private VBButton btnThemKH1;
        private VBButton btnTim1;
        private VBButton vbButton1;
    }
}