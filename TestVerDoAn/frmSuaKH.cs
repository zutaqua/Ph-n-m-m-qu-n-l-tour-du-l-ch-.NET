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
    public partial class frmSuaKH : Form
    {
        public frmSuaKH()
        {
            InitializeComponent();
        }
        String strCon = @"Data Source=LAPTOP-J6SV1RGQ\SQLEXPRESS;Initial Catalog=QuanLyKhuDuLich;Integrated Security=True";
        SqlConnection sqlCon = null;

        internal void layTT(String maKH,String tenKh, String Qtich, String DiaChi, String Sdt, String GioiTinh )
        {
            txtMaKH.Text = maKH;
            txtTenKH.Text = tenKh;
            txtQuocTich.Text = Qtich;
            txtDiaChi.Text = DiaChi;
            txtSDT.Text = Sdt;
            txtGioiTinh.Text = GioiTinh;
        }
        private void btnSuaKH_Click(object sender, EventArgs e)
        {
           
        }
        //public String maKH;
        //public String tenKH;
        //public String QTich;
        //public String DiaChi;
        //public String SDT;
        //public String GioiTinh;

        private void frmSuaKH_Load(object sender, EventArgs e)
        {
            //frmSuaKH SuaKH = new frmSuaKH();
            //txtMaKH.Text = maKH;
            //txtTenKH.Text = tenKH;
            //txtQuocTich.Text = QTich;
            //txtDiaChi.Text = DiaChi;
            //txtSDT.Text = SDT;
            //txtGioiTinh.Text = GioiTinh;
            //hienthidanhsach();


        }
        /*private void hienthidanhsach()
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
        }*/

        

        

        private void vbButton3_Click(object sender, EventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("bạn chắc muốn sửa chứ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
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
                sqlCmd.CommandText = "UPDATE KHACHHANG SET MaKH = '" + txtMaKH.Text.Trim() + "', TenKH = N'" + txtTenKH.Text.Trim() + "',QuocTich = N'" + txtQuocTich.Text.Trim() + "',DiaChi = N'" + txtDiaChi.Text.Trim() + "',SDT = '" + txtSDT.Text.Trim() + "',GioiTinh = N'" + txtGioiTinh.Text.Trim() + "' WHERE MaKH = '" + txtMaKH.Text.Trim() + "';";
                //dòng trên lười gán gt từng cái nên vứt luôn vô :>

                sqlCmd.Connection = sqlCon;

                try
                {
                    int kq = sqlCmd.ExecuteNonQuery();//tại cái culoz này lắm ngoại lệ vcl nên phải thêm try ,catch
                    if (kq > 0)
                    {

                        DialogResult q = MessageBox.Show("Sửa khách hàng thành công","Thông Báo",MessageBoxButtons.OK);
                        //hienthidanhsach();
                        //this.Refresh();
                        if (q ==DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sửa khách hàng Thất bại ");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa khách hàng Thất bại, lý do:  " + ex.Message, "Thông báo");
                }
            }
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*internal void LayTT(String ma,String Ten,String QuocTich,String diachi,String SDT,String GT)
        {
            txtMaKH.Text = ma;
            txtTenKH.Text = Ten;
            txtQuocTich.Text= QuocTich;
            txtDiaChi.Text  = diachi;
            txtSDT.Text = SDT;
            txtGioiTinh.Text = GT;
        }*/
    }
}
