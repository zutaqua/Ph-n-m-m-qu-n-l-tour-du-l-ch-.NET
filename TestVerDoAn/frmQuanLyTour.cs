using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TestVerDoAn
{
    public partial class frmQuanLyTour : Form
    {
        public frmQuanLyTour()
        {
            InitializeComponent();
        }
        String strCon = @"Data Source=LAPTOP-J6SV1RGQ\SQLEXPRESS;Initial Catalog=QuanLyKhuDuLich;Integrated Security=True";
        SqlConnection sqlCon = null;
        private void frmQuanLyTour_Load(object sender, EventArgs e)
        {
            hienthidanhsach();
        }
        internal void hienthidanhsach()
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
            sqlCmd.CommandText = "SELECT * FROM TOUR";//lấy thông tin từ bảng 

            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();  //tạo đầu đọc

            lsvDanhSach.Items.Clear();//dọn list view

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

        private void btnLMoi_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            


            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }

        String maTour = "";
        String tenTour = "";
        String tenDD1 = "";
        int SoNgay = 0;
        String tenDV = "";
        String CMon = "";
        String MTa = "";
        String TDD = "";
        private void lsvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0) return;//nếu chưa chọn j thì không làm j cả

            //lấy phần tử được chọn trên list view
            ListViewItem lvi = lsvDanhSach.SelectedItems[0];

            //lấy mã  để thực hiện xóa
            maTour = lvi.SubItems[0].Text.Trim();
            tenTour = lvi.SubItems[1].Text.Trim();
            tenDD1 = lvi.SubItems[2].Text.Trim();
            SoNgay = Convert.ToInt32(lvi.SubItems[3].Text.Trim());
            tenDV = lvi.SubItems[4].Text.Trim();
            CMon = lvi.SubItems[5].Text.Trim();
            MTa = lvi.SubItems[6].Text.Trim();
        }

        public void hienthiTourtheoDD(String TDD)
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
            String DD = txtTim.Text.Trim();
            sqlCmd.CommandText = "SELECT * FROM TOUR WHERE TenDD LIKE N'%"+DD+"%';";//lấy thông tin từ bảng 

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
        public void XoaTour(String maTour)
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
            sqlCmd.CommandText = "DELETE FROM TOUR WHERE MaTour='" + maTour + "'";//lấy cái khoá chính để làm điều kiện xóa

            sqlCmd.Connection = sqlCon;

            try
            {
                int kq = sqlCmd.ExecuteNonQuery();//tại cái culoz này lắm ngoại lệ vcl nên phải thêm try ,catch
                if (kq > 0)
                {

                    MessageBox.Show("Xóa Tour thành công");
                    hienthidanhsach();
                    //this.Refresh();
                }
                else
                {
                    MessageBox.Show("Xóa Tour Thất bại ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa Tour Thất bại, lý do:  " + ex.Message, "Thông báo");
            }

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            
                
            
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDKTouTheoNhuCau DangkyTour = new frmDKTouTheoNhuCau();
            DangkyTour.ShowDialog();
        }

        private void btnTim1_Click(object sender, EventArgs e)
        {
            hienthiTourtheoDD(TDD);
        }

        private void btnLMoi1_Click(object sender, EventArgs e)
        {
            hienthidanhsach();
            this.Refresh();
            txtTim.Text = string.Empty;
        }

        private void btnThem1_Click(object sender, EventArgs e)
        {
            frmThemTour ThemTour = new frmThemTour();
            ThemTour.ShowDialog();
        }

        private void btnXoa1_Click(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 Tour để tiến hành Xóa!!!");
            }
            else
            {
                DialogResult ms = MessageBox.Show("Bạn có chắc muốn xóa Tour???", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ms == DialogResult.Yes)
                {
                    XoaTour(maTour);
                }
            }

        }

        private void btnSua1_Click(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 Tour để tiến hành sửa!!!");
            }
            else
            {
                frmSuaTour SuaTour = new frmSuaTour();
                SuaTour.layTT(maTour, tenTour, tenDD1, SoNgay, tenDV, CMon, MTa);
                SuaTour.ShowDialog();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
