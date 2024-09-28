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
    public partial class frmSuaNV : Form
    {
        public frmSuaNV()
        {
            InitializeComponent();
        }
        String strCon = @"Data Source=LAPTOP-J6SV1RGQ\SQLEXPRESS;Initial Catalog=QuanLyKhuDuLich;Integrated Security=True";
        SqlConnection sqlCon = null;

        internal void layTT(String maNV,String tenNV,String GioiTinh,String SDT,String CMon)
        {
            txtMaNV.Text = maNV;
            txtTenNV.Text = tenNV;
            txtGioiTinh.Text = GioiTinh;    
            txtSDT.Text = SDT;
            cboChuyenMon.Text = CMon;
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
            SqlCommand sqlCmdNV = new SqlCommand();
            sqlCmdNV.CommandType = CommandType.Text;
            sqlCmdNV.CommandText = "SELECT * FROM GiaThueNV";//lấy thông tin từ bảng

            sqlCmdNV.Connection = sqlCon;
            SqlDataReader readerNV = sqlCmdNV.ExecuteReader();
            cboChuyenMon.Items.Clear();
            while (readerNV.Read())
            {
                String Cmon = readerNV.GetString(0);
                cboChuyenMon.Items.Add(Cmon);
            }
            readerNV.Close();
        }

        private void frmSuaNV_Load(object sender, EventArgs e)
        {
            hienthidanhsach();
        }
        private void btnSuaKH_Click(object sender, EventArgs e)
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


                //Lấy dữ liệu từ các ô textbox
                String maNV = txtMaNV.Text.Trim();// cái Trim() sẽ loại bỏ khoảng trắng ở đầu và cuối
                String tenNV = txtTenNV.Text.Trim();
                String GTinh = txtGioiTinh.Text.Trim();
                String SDT = txtSDT.Text.Trim();
                String CMon = cboChuyenMon.Text.Trim();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "UPDATE NHANVIEN SET MaNV = '"+maNV+"',TenNV=N'"+tenNV+"',GioiTinh=N'"+GTinh+"',SDT='"+SDT+"',ChuyenMon=N'"+CMon+"' WHERE MaNV ='"+maNV+"'";
                sqlCmd.Connection = sqlCon;

                try
                {
                    int kq = sqlCmd.ExecuteNonQuery();//tại cái culoz này lắm ngoại lệ vcl nên phải thêm try ,catch
                    if (kq > 0)
                    {

                        
                        DialogResult q = MessageBox.Show("Sửa Nhân Viên thành công", "Thông Báo", MessageBoxButtons.OK);
                        //hienthidanhsach();
                        //this.Refresh();
                        if (q == DialogResult.OK)
                        {
                            this.Close();
                        }
                        //hienthidanhsach();
                        //this.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Sửa Nhân Viên Thất bại ");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa Nhân Viên Thất bại, lý do:  " + ex.Message, "Thông báo");
                }
            }
        }


        //thêm sự kiện nhấp vào dòng nào sẽ hiện thông tin bêneeoo text 
        /*private void lsvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0) return;

            //lấy phần tử được chọn trên list view
            ListViewItem lvi = lsvDanhSach.SelectedItems[0];

            //Hiển Thị thông tin vào ô txt trong form suaNV
            txtMaNV.Text = lvi.SubItems[0].Text;
            txtTenNV.Text = lvi.SubItems[1].Text;
            txtGioiTinh.Text = lvi.SubItems[2].Text;
            txtSDT.Text = lvi.SubItems[3].Text;
            txtChuyenMon.Text = lvi.SubItems[4].Text;
        }*/

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void vbButton2_Click(object sender, EventArgs e)
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


                //Lấy dữ liệu từ các ô textbox
                String maNV = txtMaNV.Text.Trim();// cái Trim() sẽ loại bỏ khoảng trắng ở đầu và cuối
                String tenNV = txtTenNV.Text.Trim();
                String GTinh = txtGioiTinh.Text.Trim();
                String SDT = txtSDT.Text.Trim();
                String CMon = cboChuyenMon.Text.Trim();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "UPDATE NHANVIEN SET MaNV = '" + maNV + "',TenNV=N'" + tenNV + "',GioiTinh=N'" + GTinh + "',SDT='" + SDT + "',ChuyenMon=N'" + CMon + "' WHERE MaNV ='" + maNV + "'";
                sqlCmd.Connection = sqlCon;

                try
                {
                    int kq = sqlCmd.ExecuteNonQuery();//tại cái culoz này lắm ngoại lệ vcl nên phải thêm try ,catch
                    if (kq > 0)
                    {
                        DialogResult q = MessageBox.Show("Sửa Nhân Viên thành công", "Thông Báo", MessageBoxButtons.OK);
                        //hienthidanhsach();
                        //this.Refresh();
                        if (q == DialogResult.OK)
                        {
                            this.Close();
                        }
                        //hienthidanhsach();
                        //this.Refresh();
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

        private void vbButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtChuyenMon_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
