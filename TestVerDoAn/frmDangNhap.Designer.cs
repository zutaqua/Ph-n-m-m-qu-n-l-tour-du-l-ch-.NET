namespace TestVerDoAn
{
    partial class FrmDangNhap
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
            this.lblDangNhap = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.cbHienMK = new System.Windows.Forms.CheckBox();
            this.btnDangNhap = new TestVerDoAn.VBButton();
            this.rounded1 = new khanhtoan.rounded();
            this.rounded2 = new khanhtoan.rounded();
            this.rounded3 = new khanhtoan.rounded();
            this.SuspendLayout();
            // 
            // lblDangNhap
            // 
            this.lblDangNhap.AutoSize = true;
            this.lblDangNhap.BackColor = System.Drawing.SystemColors.Window;
            this.lblDangNhap.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangNhap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDangNhap.Location = new System.Drawing.Point(262, 74);
            this.lblDangNhap.Name = "lblDangNhap";
            this.lblDangNhap.Size = new System.Drawing.Size(330, 40);
            this.lblDangNhap.TabIndex = 5;
            this.lblDangNhap.Text = "Đăng Nhập Quản Lý";
            this.lblDangNhap.Click += new System.EventHandler(this.lblDangNhap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email / số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật Khẩu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.Location = new System.Drawing.Point(253, 165);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(322, 24);
            this.txtTaiKhoan.TabIndex = 3;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(256, 232);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(319, 24);
            this.txtMatKhau.TabIndex = 1;
            // 
            // cbHienMK
            // 
            this.cbHienMK.AutoSize = true;
            this.cbHienMK.BackColor = System.Drawing.SystemColors.Window;
            this.cbHienMK.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHienMK.Location = new System.Drawing.Point(255, 268);
            this.cbHienMK.Name = "cbHienMK";
            this.cbHienMK.Size = new System.Drawing.Size(105, 17);
            this.cbHienMK.TabIndex = 13;
            this.cbHienMK.Text = "Hiện mật khẩu";
            this.cbHienMK.UseVisualStyleBackColor = false;
            this.cbHienMK.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.SystemColors.Window;
            this.btnDangNhap.BackgroundColor = System.Drawing.SystemColors.Window;
            this.btnDangNhap.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDangNhap.BorderRadius = 20;
            this.btnDangNhap.BorderSize = 1;
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.Black;
            this.btnDangNhap.Location = new System.Drawing.Point(240, 289);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(346, 40);
            this.btnDangNhap.TabIndex = 0;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.TextColor = System.Drawing.Color.Black;
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click_1);
            // 
            // rounded1
            // 
            this.rounded1.BackColor = System.Drawing.SystemColors.Window;
            this.rounded1.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rounded1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rounded1.BorderRadius = 15;
            this.rounded1.BorderSize = 2;
            this.rounded1.Location = new System.Drawing.Point(240, 157);
            this.rounded1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rounded1.Name = "rounded1";
            this.rounded1.PasswordChar = false;
            this.rounded1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rounded1.PlaceholderText = "";
            this.rounded1.Size = new System.Drawing.Size(346, 40);
            this.rounded1.TabIndex = 11;
            this.rounded1.UnderlinedStyle = false;
            // 
            // rounded2
            // 
            this.rounded2.BackColor = System.Drawing.SystemColors.Window;
            this.rounded2.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rounded2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rounded2.BorderRadius = 15;
            this.rounded2.BorderSize = 2;
            this.rounded2.Location = new System.Drawing.Point(240, 224);
            this.rounded2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rounded2.Name = "rounded2";
            this.rounded2.PasswordChar = false;
            this.rounded2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rounded2.PlaceholderText = "";
            this.rounded2.Size = new System.Drawing.Size(346, 40);
            this.rounded2.TabIndex = 12;
            this.rounded2.UnderlinedStyle = false;
            // 
            // rounded3
            // 
            this.rounded3.BackColor = System.Drawing.SystemColors.Window;
            this.rounded3.BorderColor = System.Drawing.SystemColors.Window;
            this.rounded3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rounded3.BorderRadius = 30;
            this.rounded3.BorderSize = 2;
            this.rounded3.Location = new System.Drawing.Point(182, 58);
            this.rounded3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rounded3.Name = "rounded3";
            this.rounded3.PasswordChar = false;
            this.rounded3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rounded3.PlaceholderText = "";
            this.rounded3.Size = new System.Drawing.Size(466, 309);
            this.rounded3.TabIndex = 10;
            this.rounded3.UnderlinedStyle = false;
            this.rounded3.Load += new System.EventHandler(this.rounded3_Load);
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbHienMK);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDangNhap);
            this.Controls.Add(this.rounded1);
            this.Controls.Add(this.rounded2);
            this.Controls.Add(this.rounded3);
            this.Name = "FrmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập hệ thống ";
            this.Load += new System.EventHandler(this.FrmDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private VBButton btnDangNhap;
        private khanhtoan.rounded rounded3;
        private khanhtoan.rounded rounded1;
        private khanhtoan.rounded rounded2;
        private System.Windows.Forms.CheckBox cbHienMK;
    }
}

