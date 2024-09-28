namespace TestVerDoAn
{
    partial class frmDKTourCoSan
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
            this.lsvDanhSach = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimTour1 = new TestVerDoAn.VBButton();
            this.txtTenTour = new System.Windows.Forms.TextBox();
            this.txtDiaDiem = new System.Windows.Forms.TextBox();
            this.txtCMonNV = new System.Windows.Forms.TextBox();
            this.rounded3 = new khanhtoan.rounded();
            this.rounded2 = new khanhtoan.rounded();
            this.rounded1 = new khanhtoan.rounded();
            this.grbKhachHang = new System.Windows.Forms.GroupBox();
            this.rounded6 = new khanhtoan.rounded();
            this.rounded5 = new khanhtoan.rounded();
            this.rounded4 = new khanhtoan.rounded();
            this.lsvKhachHang = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTenKH = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiaChiKH = new System.Windows.Forms.TextBox();
            this.lbDiaDiem = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtThongTin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtThongTinKH = new System.Windows.Forms.TextBox();
            this.btnTimKH1 = new TestVerDoAn.VBButton();
            this.rounded7 = new khanhtoan.rounded();
            this.rounded8 = new khanhtoan.rounded();
            this.btnDangKyTour1 = new TestVerDoAn.VBButton();
            this.btnLamMoi = new TestVerDoAn.VBButton();
            this.vbButton1 = new TestVerDoAn.VBButton();
            this.groupBox2.SuspendLayout();
            this.grbKhachHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvDanhSach
            // 
            this.lsvDanhSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader7,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lsvDanhSach.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvDanhSach.FullRowSelect = true;
            this.lsvDanhSach.GridLines = true;
            this.lsvDanhSach.HideSelection = false;
            this.lsvDanhSach.Location = new System.Drawing.Point(3, 16);
            this.lsvDanhSach.Name = "lsvDanhSach";
            this.lsvDanhSach.Size = new System.Drawing.Size(432, 145);
            this.lsvDanhSach.TabIndex = 1;
            this.lsvDanhSach.UseCompatibleStateImageBehavior = false;
            this.lsvDanhSach.View = System.Windows.Forms.View.Details;
            this.lsvDanhSach.SelectedIndexChanged += new System.EventHandler(this.lsvDanhSach_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Tour";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tên Tour";
            this.columnHeader7.Width = 66;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Địa Điểm";
            this.columnHeader2.Width = 79;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số Ngày";
            this.columnHeader3.Width = 55;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên Dịch Vụ";
            this.columnHeader4.Width = 75;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Chuyên Môn NV";
            this.columnHeader5.Width = 94;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mô Tả";
            this.columnHeader6.Width = 189;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsvDanhSach);
            this.groupBox2.Controls.Add(this.btnTimTour1);
            this.groupBox2.Controls.Add(this.txtTenTour);
            this.groupBox2.Controls.Add(this.txtDiaDiem);
            this.groupBox2.Controls.Add(this.txtCMonNV);
            this.groupBox2.Controls.Add(this.rounded3);
            this.groupBox2.Controls.Add(this.rounded2);
            this.groupBox2.Controls.Add(this.rounded1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(644, 164);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đăng Ký Tour";
            // 
            // btnTimTour1
            // 
            this.btnTimTour1.BackColor = System.Drawing.SystemColors.Window;
            this.btnTimTour1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.btnTimTour1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTimTour1.BorderRadius = 10;
            this.btnTimTour1.BorderSize = 0;
            this.btnTimTour1.FlatAppearance.BorderSize = 0;
            this.btnTimTour1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimTour1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTour1.ForeColor = System.Drawing.Color.Black;
            this.btnTimTour1.Location = new System.Drawing.Point(524, 132);
            this.btnTimTour1.Name = "btnTimTour1";
            this.btnTimTour1.Size = new System.Drawing.Size(87, 26);
            this.btnTimTour1.TabIndex = 25;
            this.btnTimTour1.Text = "Tìm Tour";
            this.btnTimTour1.TextColor = System.Drawing.Color.Black;
            this.btnTimTour1.UseVisualStyleBackColor = false;
            this.btnTimTour1.Click += new System.EventHandler(this.btnTimTour1_Click);
            // 
            // txtTenTour
            // 
            this.txtTenTour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTour.Location = new System.Drawing.Point(523, 18);
            this.txtTenTour.Name = "txtTenTour";
            this.txtTenTour.Size = new System.Drawing.Size(109, 13);
            this.txtTenTour.TabIndex = 12;
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiaDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaDiem.Location = new System.Drawing.Point(523, 58);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.Size = new System.Drawing.Size(109, 13);
            this.txtDiaDiem.TabIndex = 14;
            // 
            // txtCMonNV
            // 
            this.txtCMonNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCMonNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMonNV.Location = new System.Drawing.Point(523, 98);
            this.txtCMonNV.Name = "txtCMonNV";
            this.txtCMonNV.Size = new System.Drawing.Size(109, 13);
            this.txtCMonNV.TabIndex = 19;
            // 
            // rounded3
            // 
            this.rounded3.BackColor = System.Drawing.SystemColors.Window;
            this.rounded3.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rounded3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rounded3.BorderRadius = 8;
            this.rounded3.BorderSize = 2;
            this.rounded3.Location = new System.Drawing.Point(513, 8);
            this.rounded3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rounded3.Name = "rounded3";
            this.rounded3.PasswordChar = false;
            this.rounded3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rounded3.PlaceholderText = "";
            this.rounded3.Size = new System.Drawing.Size(129, 31);
            this.rounded3.TabIndex = 28;
            this.rounded3.UnderlinedStyle = false;
            // 
            // rounded2
            // 
            this.rounded2.BackColor = System.Drawing.SystemColors.Window;
            this.rounded2.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rounded2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rounded2.BorderRadius = 8;
            this.rounded2.BorderSize = 2;
            this.rounded2.Location = new System.Drawing.Point(513, 48);
            this.rounded2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rounded2.Name = "rounded2";
            this.rounded2.PasswordChar = false;
            this.rounded2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rounded2.PlaceholderText = "";
            this.rounded2.Size = new System.Drawing.Size(129, 31);
            this.rounded2.TabIndex = 27;
            this.rounded2.UnderlinedStyle = false;
            // 
            // rounded1
            // 
            this.rounded1.BackColor = System.Drawing.SystemColors.Window;
            this.rounded1.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rounded1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rounded1.BorderRadius = 8;
            this.rounded1.BorderSize = 2;
            this.rounded1.Location = new System.Drawing.Point(513, 88);
            this.rounded1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rounded1.Name = "rounded1";
            this.rounded1.PasswordChar = false;
            this.rounded1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rounded1.PlaceholderText = "";
            this.rounded1.Size = new System.Drawing.Size(129, 31);
            this.rounded1.TabIndex = 26;
            this.rounded1.UnderlinedStyle = false;
            // 
            // grbKhachHang
            // 
            this.grbKhachHang.Controls.Add(this.rounded6);
            this.grbKhachHang.Controls.Add(this.rounded5);
            this.grbKhachHang.Controls.Add(this.rounded4);
            this.grbKhachHang.Controls.Add(this.lsvKhachHang);
            this.grbKhachHang.Controls.Add(this.lblTenKH);
            this.grbKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbKhachHang.Location = new System.Drawing.Point(21, 222);
            this.grbKhachHang.Name = "grbKhachHang";
            this.grbKhachHang.Size = new System.Drawing.Size(642, 168);
            this.grbKhachHang.TabIndex = 10;
            this.grbKhachHang.TabStop = false;
            this.grbKhachHang.Text = "Chọn Khách Hàng";
            // 
            // rounded6
            // 
            this.rounded6.BackColor = System.Drawing.SystemColors.Window;
            this.rounded6.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rounded6.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rounded6.BorderRadius = 8;
            this.rounded6.BorderSize = 2;
            this.rounded6.Location = new System.Drawing.Point(519, 44);
            this.rounded6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rounded6.Name = "rounded6";
            this.rounded6.PasswordChar = false;
            this.rounded6.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rounded6.PlaceholderText = "";
            this.rounded6.Size = new System.Drawing.Size(121, 31);
            this.rounded6.TabIndex = 31;
            this.rounded6.UnderlinedStyle = false;
            // 
            // rounded5
            // 
            this.rounded5.BackColor = System.Drawing.SystemColors.Window;
            this.rounded5.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rounded5.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rounded5.BorderRadius = 8;
            this.rounded5.BorderSize = 2;
            this.rounded5.Location = new System.Drawing.Point(519, 10);
            this.rounded5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rounded5.Name = "rounded5";
            this.rounded5.PasswordChar = false;
            this.rounded5.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rounded5.PlaceholderText = "";
            this.rounded5.Size = new System.Drawing.Size(121, 31);
            this.rounded5.TabIndex = 30;
            this.rounded5.UnderlinedStyle = false;
            // 
            // rounded4
            // 
            this.rounded4.BackColor = System.Drawing.SystemColors.Window;
            this.rounded4.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rounded4.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rounded4.BorderRadius = 8;
            this.rounded4.BorderSize = 2;
            this.rounded4.Location = new System.Drawing.Point(519, 81);
            this.rounded4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rounded4.Name = "rounded4";
            this.rounded4.PasswordChar = false;
            this.rounded4.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rounded4.PlaceholderText = "";
            this.rounded4.Size = new System.Drawing.Size(121, 31);
            this.rounded4.TabIndex = 29;
            this.rounded4.UnderlinedStyle = false;
            // 
            // lsvKhachHang
            // 
            this.lsvKhachHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.lsvKhachHang.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvKhachHang.FullRowSelect = true;
            this.lsvKhachHang.GridLines = true;
            this.lsvKhachHang.HideSelection = false;
            this.lsvKhachHang.Location = new System.Drawing.Point(3, 16);
            this.lsvKhachHang.Name = "lsvKhachHang";
            this.lsvKhachHang.Size = new System.Drawing.Size(429, 149);
            this.lsvKhachHang.TabIndex = 0;
            this.lsvKhachHang.UseCompatibleStateImageBehavior = false;
            this.lsvKhachHang.View = System.Windows.Forms.View.Details;
            this.lsvKhachHang.SelectedIndexChanged += new System.EventHandler(this.lsvKhachHang_SelectedIndexChanged);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Mã KH";
            this.columnHeader8.Width = 56;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tên KH";
            this.columnHeader9.Width = 67;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Quốc Tịch";
            this.columnHeader10.Width = 65;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Địa Chỉ";
            this.columnHeader11.Width = 75;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "SĐT";
            this.columnHeader12.Width = 94;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Giới Tính";
            this.columnHeader13.Width = 98;
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKH.Location = new System.Drawing.Point(444, 19);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(68, 13);
            this.lblTenKH.TabIndex = 11;
            this.lblTenKH.Text = "Tên K.Hàng";
            // 
            // txtTenKH
            // 
            this.txtTenKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenKH.Location = new System.Drawing.Point(552, 242);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(100, 13);
            this.txtTenKH.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(465, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Địa Chỉ KH";
            // 
            // txtDiaChiKH
            // 
            this.txtDiaChiKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiaChiKH.Location = new System.Drawing.Point(552, 276);
            this.txtDiaChiKH.Name = "txtDiaChiKH";
            this.txtDiaChiKH.Size = new System.Drawing.Size(100, 13);
            this.txtDiaChiKH.TabIndex = 14;
            // 
            // lbDiaDiem
            // 
            this.lbDiaDiem.AutoSize = true;
            this.lbDiaDiem.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaDiem.Location = new System.Drawing.Point(453, 108);
            this.lbDiaDiem.Name = "lbDiaDiem";
            this.lbDiaDiem.Size = new System.Drawing.Size(78, 13);
            this.lbDiaDiem.TabIndex = 13;
            this.lbDiaDiem.Text = "Tên Địa Điểm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(469, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tên Tour";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(483, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "SDT";
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSDTKH.Location = new System.Drawing.Point(551, 313);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(100, 13);
            this.txtSDTKH.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(462, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "C. Môn NV";
            // 
            // txtThongTin
            // 
            this.txtThongTin.BackColor = System.Drawing.SystemColors.Window;
            this.txtThongTin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtThongTin.Location = new System.Drawing.Point(119, 409);
            this.txtThongTin.Name = "txtThongTin";
            this.txtThongTin.ReadOnly = true;
            this.txtThongTin.Size = new System.Drawing.Size(402, 13);
            this.txtThongTin.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Thông Tin Tour";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 446);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Thông Tin KH";
            // 
            // txtThongTinKH
            // 
            this.txtThongTinKH.BackColor = System.Drawing.SystemColors.Window;
            this.txtThongTinKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtThongTinKH.Location = new System.Drawing.Point(119, 446);
            this.txtThongTinKH.Name = "txtThongTinKH";
            this.txtThongTinKH.ReadOnly = true;
            this.txtThongTinKH.Size = new System.Drawing.Size(402, 13);
            this.txtThongTinKH.TabIndex = 24;
            // 
            // btnTimKH1
            // 
            this.btnTimKH1.BackColor = System.Drawing.SystemColors.Window;
            this.btnTimKH1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.btnTimKH1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTimKH1.BorderRadius = 10;
            this.btnTimKH1.BorderSize = 0;
            this.btnTimKH1.FlatAppearance.BorderSize = 0;
            this.btnTimKH1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKH1.ForeColor = System.Drawing.Color.Black;
            this.btnTimKH1.Location = new System.Drawing.Point(537, 350);
            this.btnTimKH1.Name = "btnTimKH1";
            this.btnTimKH1.Size = new System.Drawing.Size(87, 26);
            this.btnTimKH1.TabIndex = 26;
            this.btnTimKH1.Text = "Tìm KH";
            this.btnTimKH1.TextColor = System.Drawing.Color.Black;
            this.btnTimKH1.UseVisualStyleBackColor = false;
            this.btnTimKH1.Click += new System.EventHandler(this.btnTimKH1_Click);
            // 
            // rounded7
            // 
            this.rounded7.BackColor = System.Drawing.SystemColors.Window;
            this.rounded7.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rounded7.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rounded7.BorderRadius = 8;
            this.rounded7.BorderSize = 2;
            this.rounded7.Location = new System.Drawing.Point(113, 401);
            this.rounded7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rounded7.Name = "rounded7";
            this.rounded7.PasswordChar = false;
            this.rounded7.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rounded7.PlaceholderText = "";
            this.rounded7.Size = new System.Drawing.Size(414, 28);
            this.rounded7.TabIndex = 27;
            this.rounded7.UnderlinedStyle = false;
            // 
            // rounded8
            // 
            this.rounded8.BackColor = System.Drawing.SystemColors.Window;
            this.rounded8.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rounded8.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rounded8.BorderRadius = 8;
            this.rounded8.BorderSize = 2;
            this.rounded8.Location = new System.Drawing.Point(113, 438);
            this.rounded8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rounded8.Name = "rounded8";
            this.rounded8.PasswordChar = false;
            this.rounded8.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rounded8.PlaceholderText = "";
            this.rounded8.Size = new System.Drawing.Size(414, 28);
            this.rounded8.TabIndex = 28;
            this.rounded8.UnderlinedStyle = false;
            // 
            // btnDangKyTour1
            // 
            this.btnDangKyTour1.BackColor = System.Drawing.SystemColors.Window;
            this.btnDangKyTour1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.btnDangKyTour1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDangKyTour1.BorderRadius = 8;
            this.btnDangKyTour1.BorderSize = 0;
            this.btnDangKyTour1.FlatAppearance.BorderSize = 0;
            this.btnDangKyTour1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKyTour1.ForeColor = System.Drawing.Color.Black;
            this.btnDangKyTour1.Location = new System.Drawing.Point(542, 401);
            this.btnDangKyTour1.Name = "btnDangKyTour1";
            this.btnDangKyTour1.Size = new System.Drawing.Size(95, 30);
            this.btnDangKyTour1.TabIndex = 0;
            this.btnDangKyTour1.Text = "Đăng Ký";
            this.btnDangKyTour1.TextColor = System.Drawing.Color.Black;
            this.btnDangKyTour1.UseVisualStyleBackColor = false;
            this.btnDangKyTour1.Click += new System.EventHandler(this.btnDangKyTour1_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.SystemColors.Window;
            this.btnLamMoi.BackgroundColor = System.Drawing.SystemColors.Window;
            this.btnLamMoi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLamMoi.BorderRadius = 8;
            this.btnLamMoi.BorderSize = 0;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.ForeColor = System.Drawing.Color.Black;
            this.btnLamMoi.Location = new System.Drawing.Point(542, 438);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(95, 30);
            this.btnLamMoi.TabIndex = 1;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.TextColor = System.Drawing.Color.Black;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // vbButton1
            // 
            this.vbButton1.BackColor = System.Drawing.SystemColors.Window;
            this.vbButton1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.vbButton1.BackgroundImage = global::TestVerDoAn.Properties.Resources.logo1;
            this.vbButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.vbButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton1.BorderRadius = 8;
            this.vbButton1.BorderSize = 0;
            this.vbButton1.FlatAppearance.BorderSize = 0;
            this.vbButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton1.ForeColor = System.Drawing.Color.Black;
            this.vbButton1.Location = new System.Drawing.Point(24, 2);
            this.vbButton1.Name = "vbButton1";
            this.vbButton1.Size = new System.Drawing.Size(55, 45);
            this.vbButton1.TabIndex = 31;
            this.vbButton1.TextColor = System.Drawing.Color.Black;
            this.vbButton1.UseVisualStyleBackColor = false;
            this.vbButton1.Click += new System.EventHandler(this.vbButton1_Click);
            // 
            // frmDKTourCoSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(667, 478);
            this.Controls.Add(this.vbButton1);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnTimKH1);
            this.Controls.Add(this.txtThongTinKH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtThongTin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSDTKH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDiaDiem);
            this.Controls.Add(this.txtDiaChiKH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbKhachHang);
            this.Controls.Add(this.rounded8);
            this.Controls.Add(this.rounded7);
            this.Controls.Add(this.btnDangKyTour1);
            this.Name = "frmDKTourCoSan";
            this.Text = "frmTourCoSan";
            this.Load += new System.EventHandler(this.frmTourCoSan_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grbKhachHang.ResumeLayout(false);
            this.grbKhachHang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lsvDanhSach;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grbKhachHang;
        private System.Windows.Forms.ListView lsvKhachHang;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtDiaChiKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiaDiem;
        private System.Windows.Forms.Label lbDiaDiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenTour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSDTKH;
        private System.Windows.Forms.TextBox txtCMonNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtThongTin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtThongTinKH;
        private VBButton btnTimTour1;
        private VBButton btnTimKH1;
        private khanhtoan.rounded rounded3;
        private khanhtoan.rounded rounded2;
        private khanhtoan.rounded rounded1;
        private khanhtoan.rounded rounded6;
        private khanhtoan.rounded rounded5;
        private khanhtoan.rounded rounded4;
        private khanhtoan.rounded rounded7;
        private khanhtoan.rounded rounded8;
        private VBButton btnDangKyTour1;
        private VBButton btnLamMoi;
        private VBButton vbButton1;
    }
}