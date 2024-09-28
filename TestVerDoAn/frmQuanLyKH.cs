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
    public partial class frmQuanLyKH : Form
    {
        public frmQuanLyKH()
        {
            InitializeComponent();
        }
        String strCon = @"Data Source=LAPTOP-J6SV1RGQ\SQLEXPRESS;Initial Catalog=QuanLyKhuDuLich;Integrated Security=True";
        SqlConnection sqlCon = null;
        private void frmQuanLyKH_Load(object sender, EventArgs e)
        {
            hienthidanhsach();

        }

        //hàm Hiển thị danh sách
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
            sqlCmd.CommandText = "SELECT * FROM KHACHHANG";//lấy thông tin từ bảng kh

            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();  //tạo đầu đọc
            lsvDanhSach.Items.Clear();//dọn list view
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

                lsvDanhSach.Items.Add(lvi);
            }
            reader.Close();//đóng đầu đọc (không có lỗi luôn)

        }

        String maKH = "";
        String tenKH = "";
        String QTich = "";
        String DChi = "";
        String SDT = "";
        String Gtinh = "";


        private void lsvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0) return;//nếu chưa chọn j thì không làm j cả

            //lấy phần tử được chọn trên list view
            ListViewItem lvi = lsvDanhSach.SelectedItems[0];

            //lấy mã khách hàng để thực hiện xóa
            maKH = lvi.SubItems[0].Text.Trim();
            tenKH = lvi.SubItems[1].Text.Trim();
            QTich = lvi.SubItems[2].Text.Trim();
            DChi = lvi.SubItems[3].Text.Trim();
            SDT = lvi.SubItems[4].Text.Trim(); 
            Gtinh = lvi.SubItems[5].Text.Trim();    


        }

        //Tạo hàm xoa
        public void XoaKH(String maKH)
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
            sqlCmd.CommandText = "DELETE FROM KHACHHANG WHERE MaKH='"+maKH+"'";//

            sqlCmd.Connection = sqlCon;

            try
            {
                int kq = sqlCmd.ExecuteNonQuery();//tại cái culoz này lắm ngoại lệ vcl nên phải thêm try ,catch
                if (kq > 0)
                {

                    MessageBox.Show("Xóa khách hàng thành công");
                    frmQuanLyKH QuanLyKH = new frmQuanLyKH();
                    hienthidanhsach();
                    //this.Refresh();
                }
                else
                {
                    MessageBox.Show("Xóa khách hàng Thất bại ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa khách hàng Thất bại, lý do:  " + ex.Message, "Thông báo");
            }
        }

        private void btnLMoi1_Click(object sender, EventArgs e)
        {
            hienthidanhsach();
            this.Refresh();
        }

        private void btnThemKH1_Click(object sender, EventArgs e)
        {
            frmThemKH ThemKH = new frmThemKH();
            ThemKH.ShowDialog();//bắt buộc thực hiện thêm khách hành hoặc
                                //phải thoát cái frm kia ms được dùng tiếp
        }

        private void btnXoaKH1_Click(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0) //nếu không chọn gì thì sẽ hiện thông báo
            {
                MessageBox.Show("Hãy chọn 1 Khách hàng để xóa ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DialogResult kq = MessageBox.Show("Bạn có chắc muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (kq == DialogResult.Yes)
                {
                    XoaKH(maKH);
                }
            }
        }

        private void btnSuaKH1_Click(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0) //nếu không chọn gì thì sẽ hiện thông báo
            {
                MessageBox.Show("Hãy chọn 1 Khách hàng để Sửa ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                frmSuaKH SuaKH = new frmSuaKH();
                SuaKH.layTT(maKH, tenKH, QTich, DChi, SDT, Gtinh);
                SuaKH.ShowDialog();
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
            String TKH = "";
            String DCKH = "";
            String SDTKH = "";

            TKH = txtTenKH.Text.Trim();
            DCKH = txtDiaChiKH.Text.Trim();
            SDTKH = txtSDTKH.Text.Trim();

            sqlCmd.CommandText = "SELECT * FROM KHACHHANG WHERE TenKH LIKE N'%" + TKH + "%' AND DiaChi LIKE N'%" + DCKH + "%' AND SDT LIKE '%" + SDTKH + "%' ;";//lấy thông tin từ bảng kh

            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();  //tạo đầu đọc
            lsvDanhSach.Items.Clear();//dọn list view
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

                lsvDanhSach.Items.Add(lvi);
            }
            reader.Close();//đóng đầu đọc (không có lỗi luôn)
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
