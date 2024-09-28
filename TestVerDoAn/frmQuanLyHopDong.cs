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
    public partial class frmQuanLyHopDong : Form
    {
        public frmQuanLyHopDong()
        {
            InitializeComponent();
        }
        String strCon = @"Data Source=LAPTOP-J6SV1RGQ\SQLEXPRESS;Initial Catalog=QuanLyKhuDuLich;Integrated Security=True";
        SqlConnection sqlCon = null;
        private void frmQuanLyHopDong_Load(object sender, EventArgs e)
        {
            hienthidanhsach();
        }
        private void hienthidanhsach()
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
            sqlCmd.CommandText = "SELECT * FROM HOPDONG";//lấy thông tin từ bảng

            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();  //tạo đầu đọc
            lsvDanhSach.Items.Clear();//dọn list view
            while (reader.Read())//thực hiện đọc
            {
                String maHD = reader.GetString(0);//lấy cột 0 tức mã 
                String maKH = reader.GetString(1);// lấy cột 1 phần ten
                String NgayLap = Convert.ToString(reader.GetDateTime(2));

                ListViewItem lvi = new ListViewItem(maHD); //thêm phần đã lấy vô listview
                lvi.SubItems.Add(maKH);
                lvi.SubItems.Add(NgayLap);

                lsvDanhSach.Items.Add(lvi);
            }
            reader.Close();//đóng đầu đọc (không có lỗi luôn)
        }

        String MHD = "";
        private void lsvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0) return;//nếu chưa chọn j thì không làm j cả

            //lấy phần tử được chọn trên list view
            ListViewItem lvi = lsvDanhSach.SelectedItems[0];

            //lấy mã để thực hiện xóa
            MHD = lvi.SubItems[0].Text.Trim();
            hienthiNoiDungHD(MHD);
        }
        private void hienthiNoiDungHD(String MaHD)
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
            sqlCmd.CommandText = "SELECT * FROM HOPDONG WHERE MaHD = '"+MaHD+"' ";//lấy thông tin từ bảng

            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();  //tạo đầu đọc
            while (reader.Read())//thực hiện đọc
            {
                String maHD = reader.GetString(0);//lấy cột 0 tức mã 
                String maKH = reader.GetString(1);// lấy cột 1 phần ten
                String NgayLap = Convert.ToString(reader.GetDateTime(2));
                String NoiD = reader.GetString(3);

                rtbNoiDung.Text = NoiD;

            }
            reader.Close();//đóng đầu đọc (không có lỗi luôn)
        }
        public void XoaHopDong(String maHD)
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
            sqlCmd.CommandText = "DELETE FROM HOPDONG WHERE MaHD='" + maHD + "'";//lấy cái khoá chính để làm điều kiện xóa

            sqlCmd.Connection = sqlCon;

            try
            {
                int kq = sqlCmd.ExecuteNonQuery();//tại cái culoz này lắm ngoại lệ vcl nên phải thêm try ,catch
                if (kq > 0)
                {

                    MessageBox.Show("Xóa hợp đồng thành công");
                    hienthidanhsach();
                    //this.Refresh();
                }
                else
                {
                    MessageBox.Show("Xóa hợp đồng Thất bại ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa hợp đồng Thất bại, lý do:  " + ex.Message, "Thông báo");
            }
        }

        private void btnTim1_Click(object sender, EventArgs e)
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
            String MHD = "";
            String MKH = "";

            MHD = txtMaHD.Text.Trim();
            MKH = txtMaKH.Text.Trim();

            sqlCmd.CommandText = "SELECT * FROM HOPDONG WHERE MaHD LIKE N'%" + MHD + "%' AND MaKH LIKE N'%" + MKH + "%'  ;";//lấy thông tin từ bảng kh

            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();  //tạo đầu đọc
            lsvDanhSach.Items.Clear();//dọn list view
            while (reader.Read())//thực hiện đọc
            {
                String maHD = reader.GetString(0);//lấy cột 0 tức mã 
                String maKH = reader.GetString(1);// lấy cột 1 phần ten
                String NgayLap = Convert.ToString(reader.GetDateTime(2));

                ListViewItem lvi = new ListViewItem(maHD); //thêm phần đã lấy vô listview
                lvi.SubItems.Add(maKH);
                lvi.SubItems.Add(NgayLap);

                lsvDanhSach.Items.Add(lvi);
            }
            reader.Close();//đóng đầu đọc (không có lỗi luôn)
        }

        private void btnThem1_Click(object sender, EventArgs e)
        {
            frmThemHopDong ThemHopDong = new frmThemHopDong();
            ThemHopDong.ShowDialog();
        }

        private void btnXoa1_Click(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0) //nếu không chọn gì thì sẽ hiện thông báo
            {
                MessageBox.Show("Hãy chọn 1 hợp đồng để xóa ");
                return;
            }
            else
            {
                DialogResult kq = MessageBox.Show("Bạn có chắc muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (kq == DialogResult.Yes)
                {
                    XoaHopDong(MHD);
                }
            }
        }

        private void btnLMoi1_Click(object sender, EventArgs e)
        {
            hienthidanhsach();
            hienthiNoiDungHD(MHD);
            rtbNoiDung.Text = "";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    
