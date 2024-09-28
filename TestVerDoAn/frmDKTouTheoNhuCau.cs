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
    public partial class frmDKTouTheoNhuCau : Form
    {
        public frmDKTouTheoNhuCau()
        {
            InitializeComponent();
        }
        String strCon = @"Data Source=LAPTOP-J6SV1RGQ\SQLEXPRESS;Initial Catalog=QuanLyKhuDuLich;Integrated Security=True";
        SqlConnection sqlCon = null;
        private void frmDKTouTheoNhuCau_Load(object sender, EventArgs e)
        {
            hienthidanhsach();
            hienthikhachhang();
        }
        private void hienthidanhsach()
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            SqlCommand sqlCmdDD = new SqlCommand();
            sqlCmdDD.CommandType = CommandType.Text;
            sqlCmdDD.CommandText = "SELECT * FROM GiaDiaDiem";

            SqlCommand sqlCmdDV = new SqlCommand();
            sqlCmdDV.CommandType = CommandType.Text;
            sqlCmdDV.CommandText = "SELECT * FROM GiaDichVu";

            SqlCommand sqlCmdNV = new SqlCommand();
            sqlCmdNV.CommandType = CommandType.Text;
            sqlCmdNV.CommandText = "SELECT * FROM GiaThueNV";


            sqlCmdDD.Connection = sqlCon;
            sqlCmdDV.Connection = sqlCon;
            sqlCmdNV.Connection = sqlCon;

            SqlDataReader readerDD = sqlCmdDD.ExecuteReader();
            cboDiaDiem.Items.Clear();
            while (readerDD.Read())
            {
                String TenDD = readerDD.GetString(0);
                cboDiaDiem.Items.Add(TenDD);
            }
            readerDD.Close();

            SqlDataReader readerDV = sqlCmdDV.ExecuteReader();
            cboDichVu.Items.Clear();
            while (readerDV.Read())
            {
                String TenDV = readerDV.GetString(0);
                cboDichVu.Items.Add(TenDV);
            }
            readerDV.Close();

            SqlDataReader readerNV = sqlCmdNV.ExecuteReader();
            cboNhanVien.Items.Clear();
            while (readerNV.Read())
            {
                String TenNV = readerNV.GetString(0);
                cboNhanVien.Items.Add(TenNV);
            }
            readerNV.Close();

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

            String ThongTin = "Mã KH: " + maKH + "\n\n" + "Tên KH: " + ten + "\n\nQuốc Tịch: " + QTich + "\n\nDịa Chỉ: " + DiaC + "\n\nSDT: " + SD + "\n\nGiới Tính: " + GT;
            rtbThongtin.Text=ThongTin;
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

        private void btnDangKyTC_Click_1(object sender, EventArgs e)
        {
            if (sqlCon == null)//rỗng thì tạo mới
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)//đóng thì mở
            {
                sqlCon.Open();
            }

            //Lấy dữ liệu từ các ô textbox,combobox
            String DD = cboDiaDiem.Text.Trim();// cái Trim() sẽ loại bỏ khoảng trắng ở đầu và cuối
            String DV = cboDichVu.Text.Trim();
            String NV = cboNhanVien.Text.Trim();
            int SoNg = Convert.ToInt32(txtSoNgay.Text.Trim());
            String GhiC = rtbGhiChu.Text.Trim();


            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "INSERT INTO  TOUR_DA_DK(TenDD,TenDV,ChuyenMon,SoNgay,Mota,MaKH) VALUES (N'" + DD + "',N'" + DV + "',N'" + NV + "'," + SoNg + ",N'" + GhiC + "','" + maKH + "')";//lấy cái khoá chính để làm điều kiện xóa
            sqlCmd.Connection = sqlCon;


            try
            {
                int kq = sqlCmd.ExecuteNonQuery();//tại cái culoz này lắm ngoại lệ vcl nên phải thêm try ,catch
                if (kq > 0)
                {
                    MessageBox.Show("Đăng ký thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đăng Ký Thất bại ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng ký Thất bại, lý do:  " + ex.Message, "Thông báo");
            }
        }

        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            txtDiaChiKH.Text = "";
            txtSDTKH.Text = "";
            txtSoNgay.Text = "";
            txtTenKH.Text = "";
            rtbThongtin.Text = "";
            rtbGhiChu.Text = "";
            cboDiaDiem.Text = "";
            cboDichVu.Text = "";
            cboNhanVien.Text = "";
            hienthidanhsach();
            hienthikhachhang();
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

        private void vbButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
