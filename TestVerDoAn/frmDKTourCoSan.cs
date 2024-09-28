using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestVerDoAn
{
    public partial class frmDKTourCoSan : Form
    {
        public frmDKTourCoSan()
        {
            InitializeComponent();
        }
        private void frmTourCoSan_Load(object sender, EventArgs e)
        {
            hienthi();
            hienthikhachhang();
        }
        String strCon = @"Data Source=LAPTOP-J6SV1RGQ\SQLEXPRESS;Initial Catalog=QuanLyKhuDuLich;Integrated Security=True";
        SqlConnection sqlCon = null;

        //khai báo các thành phần để lấy dữ liệu từ lishview
        String DD = "";
        String DV = "";
        String NV = "";
        int SoNg = 0;
        String GhiC = "";
        private void lsvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lsvDanhSach.SelectedItems.Count == 0) return;//nếu chưa chọn j thì không làm j cả

            //lấy phần tử được chọn trên list view
            ListViewItem lvi = lsvDanhSach.SelectedItems[0];

            //lấy text từ các cột trong listview
            DD = lvi.SubItems[2].Text.Trim();
            DV = lvi.SubItems[4].Text.Trim();
            NV = lvi.SubItems[5].Text.Trim();
            SoNg = Convert.ToInt32(lvi.SubItems[3].Text.Trim());
            GhiC = lvi.SubItems[6].Text.Trim();

            String ThongTin = DD + "/" + DV + "/" + NV + "/"+SoNg;
            txtThongTin.Text = ThongTin;
        }
        public void DangKyTour(String DD, String DV, String NV, int SoNg, String GhiC,String MaKH)
        {
            if (sqlCon == null)//rỗng thì tạo mới
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)//đóng thì mở
            {
                sqlCon.Open();
            }

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "INSERT INTO  TOUR_DA_DK(TenDD,TenDV,ChuyenMon,SoNgay,Mota,MaKH) VALUES (N'" + DD + "',N'" + DV + "',N'" + NV + "'," + SoNg + ",N'" + GhiC + "','"+MaKH+"')";//lấy cái khoá chính để làm điều kiện xóa

            sqlCmd.Connection = sqlCon;

            try
            {
                int kq = sqlCmd.ExecuteNonQuery();//tại cái culoz này lắm ngoại lệ vcl nên phải thêm try ,catch
                if (kq > 0)
                {

                    DialogResult ms = MessageBox.Show("Đăng ký thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (ms == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Đăng ký Tour Thất bại ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng Tour Thất bại, lý do:  " + ex.Message, "Thông báo");
            }

        }
        private void hienthi()
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM TOUR";//lấy thông tin từ bảng 

            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();  //tạo đầu đọc

            lsvDanhSach.Items.Clear();//dọn list view

            while (reader.Read())//thực hiện đọc
            {
                String maTour = reader.GetString(0);//lấy cột 0 tức mã
                String tenTour = reader.GetString(1);
                String tenDD = reader.GetString(2);// 
                String SoNgay = Convert.ToString(reader.GetInt32(3));// 
                String TenDichVu = reader.GetString(4);
                String NhanVien = reader.GetString(5);
                String Mota = reader.GetString(6);// 

                ListViewItem lvi = new ListViewItem(maTour); //thêm phần đã lấy vô listview
                lvi.SubItems.Add(tenTour);
                lvi.SubItems.Add(tenDD);
                lvi.SubItems.Add(SoNgay);
                lvi.SubItems.Add(TenDichVu);
                lvi.SubItems.Add(NhanVien);
                lvi.SubItems.Add(Mota);

                lsvDanhSach.Items.Add(lvi);

            }
            reader.Close();//đóng đầu đọc 
        }
        private void hienthikhachhang()
        {
            if (sqlCon == null)//rỗng thì tạo mới
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)//đóng thì mở
            {
                sqlCon.Open();
            }
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM KHACHHANG";//lấy thông tin từ bảng kh

            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();  //tạo đầu đọc
            lsvKhachHang.Items.Clear();//dọn list view
            while (reader.Read())//thực hiện đọc
            {
                String maKH = reader.GetString(0);//lấy cột 0 tức mã kh
                String tenKH = reader.GetString(1);// lấy cột 3 phần ten
                String QuocTich = reader.GetString(2);// lấy cột 2 phần qtich
                String DiaChi = reader.GetString(3);
                String SDT = reader.GetString(4);
                String GT = reader.GetString(5);

                ListViewItem lvi = new ListViewItem(maKH); //thêm phần đã lấy vô listview
                lvi.SubItems.Add(tenKH);
                lvi.SubItems.Add(QuocTich);
                lvi.SubItems.Add(DiaChi);
                lvi.SubItems.Add(SDT);
                lvi.SubItems.Add(GT);

                lsvKhachHang.Items.Add(lvi);
            }
            reader.Close();//đóng đầu đọc (không có lỗi luôn)

        }

        String maKH = "";
        private void lsvKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (lsvKhachHang.SelectedItems.Count == 0) return;//nếu chưa chọn j thì không làm j cả

             //lấy phần tử được chọn trên list view
             ListViewItem lvi = lsvKhachHang.SelectedItems[0];

             //lấy mã khách hàng để thực hiện xóa
            maKH = lvi.SubItems[0].Text.Trim();
            String ten = lvi.SubItems[1].Text;
            String QTich = lvi.SubItems[2].Text;
            String DiaC = lvi.SubItems[3].Text;
            String SD = lvi.SubItems[4].Text;
            String GT = lvi.SubItems[5].Text;

            String ThongTin = ten + "/" + QTich+"/"+DiaC+"/"+SD+"/"+GT;
            txtThongTinKH.Text = ThongTin;
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimTour1_Click(object sender, EventArgs e)
        {
            if (sqlCon == null)//rỗng thì tạo mới
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)//đóng thì mở
            {
                sqlCon.Open();
            }
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            String DD = "";
            String TenTo = "";
            String CMon = "";
            DD = txtDiaDiem.Text.Trim();
            TenTo = txtTenTour.Text.Trim();
            CMon = txtCMonNV.Text.Trim();

            sqlCmd.CommandText = "SELECT * FROM TOUR WHERE TenTour LIKE N'%" + TenTo + "%' AND TenDD LIKE N'%" + DD + "%' AND ChuyenMon LIKE N'%" + CMon + "%' ;";//lấy thông tin từ bảng 

            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();  //tạo đầu đọc

            lsvDanhSach.Items.Clear();//dọn list view cũ
            while (reader.Read())//thực hiện đọc
            {
                String maTour = reader.GetString(0);//lấy cột 0 tức mã kh
                String tenTour = reader.GetString(1);
                String tenDD = reader.GetString(2);// 
                String SoNgay = Convert.ToString(reader.GetInt32(3));// 
                String TenDichVu = reader.GetString(4);
                String TenNhanVien = reader.GetString(5);
                String Mota = reader.GetString(6);// 

                ListViewItem lvi = new ListViewItem(maTour); //thêm phần đã lấy vô listview
                lvi.SubItems.Add(tenTour);
                lvi.SubItems.Add(tenDD);
                lvi.SubItems.Add(SoNgay);
                lvi.SubItems.Add(TenDichVu);
                lvi.SubItems.Add(TenNhanVien);
                lvi.SubItems.Add(Mota);

                lsvDanhSach.Items.Add(lvi);



            }
            reader.Close();//đóng đầu đọc (không có lỗi luôn)
        }

        private void btnTimKH1_Click(object sender, EventArgs e)
        {
            if (sqlCon == null)//rỗng thì tạo mới
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)//đóng thì mở
            {
                sqlCon.Open();
            }
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            String TKH = "";
            String DCKH = "";
            String SDTKH = "";

            TKH = txtTenKH.Text.Trim();
            DCKH = txtDiaChiKH.Text.Trim();
            SDTKH = txtSDTKH.Text.Trim();

            sqlCmd.CommandText = "SELECT * FROM KHACHHANG WHERE TenKH LIKE N'%" + TKH + "%' AND DiaChi LIKE N'%" + DCKH + "%' AND SDT LIKE '%" + SDTKH + "%' ;";//lấy thông tin từ bảng kh

            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();  //tạo đầu đọc
            lsvKhachHang.Items.Clear();//dọn list view
            while (reader.Read())//thực hiện đọc
            {
                String maKH = reader.GetString(0);//lấy cột 0 tức mã kh
                String tenKH = reader.GetString(1);// lấy cột 3 phần ten
                String QuocTich = reader.GetString(2);// lấy cột 2 phần qtich
                String DiaChi = reader.GetString(3);
                String SDT = reader.GetString(4);
                String GT = reader.GetString(5);

                ListViewItem lvi = new ListViewItem(maKH); //thêm phần đã lấy vô listview
                lvi.SubItems.Add(tenKH);
                lvi.SubItems.Add(QuocTich);
                lvi.SubItems.Add(DiaChi);
                lvi.SubItems.Add(SDT);
                lvi.SubItems.Add(GT);

                lsvKhachHang.Items.Add(lvi);
            }
            reader.Close();//đóng đầu đọc (không có lỗi luôn)
        }

        private void btnDangKyTour1_Click(object sender, EventArgs e)
        {
            DangKyTour(DD, DV, NV, SoNg, GhiC, maKH);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtCMonNV.Text = "";
            txtDiaChiKH.Text = "";
            txtDiaDiem.Text = "";
            txtSDTKH.Text = "";
            txtTenKH.Text = "";
            txtTenTour.Text = "";
            txtThongTin.Text = "";
            txtThongTinKH.Text = "";
            hienthi();
            hienthikhachhang();
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
