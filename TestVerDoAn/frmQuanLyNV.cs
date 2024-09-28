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
    public partial class frmQuanLyNV : Form
    {
        public frmQuanLyNV()
        {
            InitializeComponent();
        }
        String strCon = @"Data Source=LAPTOP-J6SV1RGQ\SQLEXPRESS;Initial Catalog=QuanLyKhuDuLich;Integrated Security=True";
        SqlConnection sqlCon = null;
        private void btnThem_Click(object sender, EventArgs e)
        {
            
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
            sqlCmd.CommandText = "SELECT * FROM NHANVIEN";//lấy thông tin từ bảng

            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();  //tạo đầu đọc
            lsvDanhSach.Items.Clear();//dọn list view
            while (reader.Read())//thực hiện đọc
            {
                String maNV = reader.GetString(0);//lấy cột 0 tức mã 
                String tenNV = reader.GetString(1);// lấy cột 1 phần ten
                String SDT = reader.GetString(2);
                String GT = reader.GetString(3);
                String CMon = reader.GetString(4);

                ListViewItem lvi = new ListViewItem(maNV); //thêm phần đã lấy vô listview
                lvi.SubItems.Add(tenNV);
                lvi.SubItems.Add(SDT);
                lvi.SubItems.Add(GT);
                lvi.SubItems.Add(CMon);

                lsvDanhSach.Items.Add(lvi);
            }
            reader.Close();//đóng đầu đọc (không có lỗi luôn)
        }

        private void frmQuanLyNV_Load(object sender, EventArgs e)
        {
            hienthidanhsach();
        }

        private void btnLMoi_Click(object sender, EventArgs e)
        {
            
        }

        
        public void XoaNV(String maNV)
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
            sqlCmd.CommandText = "DELETE FROM NHANVIEN WHERE MaNV='" + maNV + "'";//lấy cái khoá chính để làm điều kiện xóa

            sqlCmd.Connection = sqlCon;

            try
            {
                int kq = sqlCmd.ExecuteNonQuery();//tại cái culoz này lắm ngoại lệ vcl nên phải thêm try ,catch
                if (kq > 0)
                {

                    MessageBox.Show("Xóa nhân viên thành công");
                    hienthidanhsach();
                    //this.Refresh();
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên Thất bại ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa nhân viên Thất bại, lý do:  " + ex.Message, "Thông báo");
            }
        }

        String maNV = "";
        String tenNV = "";
        String Gtinh = "";
        String SDT = "";
        String CMon = "";
        private void lsvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0) return;//nếu chưa chọn j thì không làm j cả

            //lấy phần tử được chọn trên list view
            ListViewItem lvi = lsvDanhSach.SelectedItems[0];

            //lấy mã nhân viên để thực hiện xóa
            maNV = lvi.SubItems[0].Text.Trim();
            tenNV = lvi.SubItems[1].Text.Trim();
            Gtinh = lvi.SubItems[2].Text.Trim();
            SDT = lvi.SubItems[3].Text.Trim();
            CMon = lvi.SubItems[4].Text.Trim();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLMoi1_Click(object sender, EventArgs e)
        {
            hienthidanhsach();
            this.Refresh();
        }

        private void btnThemKH1_Click(object sender, EventArgs e)
        {
            frmThemNV ThemNV = new frmThemNV();
            ThemNV.ShowDialog();
        }

        private void btnXoaKH1_Click(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0) //nếu không chọn gì thì sẽ hiện thông báo
            {
                MessageBox.Show("Hãy chọn 1 nhân viên để xóa ");
                return;
            }
            else
            {
                DialogResult kq = MessageBox.Show("Bạn có chắc muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (kq == DialogResult.Yes)
                {
                    XoaNV(maNV);
                }
            }
        }

        private void btnSuaKH1_Click(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 Nhân Viên để tiến hành Sửa!!!");
            }
            else
            {
                frmSuaNV SuaNV = new frmSuaNV();
                SuaNV.layTT(maNV, tenNV, Gtinh, SDT, CMon);
                SuaNV.ShowDialog();
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
            String TNV = "";
            String CMon = "";
            String SDT = "";

            TNV = txtTenNV.Text.Trim();
            CMon = txtCMon.Text.Trim();
            SDT = txtSDT.Text.Trim();

            sqlCmd.CommandText = "SELECT * FROM NHANVIEN WHERE TenNV LIKE N'%" + TNV + "%' AND ChuyenMon LIKE N'%" + CMon + "%' AND SDT LIKE '%" + SDT + "%' ;";//lấy thông tin từ bảng kh
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            lsvDanhSach.Items.Clear();//dọn list view
            while (reader.Read())//thực hiện đọc
            {
                String maNV = reader.GetString(0);//lấy cột 0 tức mã 
                String tenNV = reader.GetString(1);// lấy cột 1 phần ten
                String SDT1 = reader.GetString(2);
                String GT = reader.GetString(3);
                String CMo = reader.GetString(4);

                ListViewItem lvi = new ListViewItem(maNV); //thêm phần đã lấy vô listview
                lvi.SubItems.Add(tenNV);
                lvi.SubItems.Add(SDT1);
                lvi.SubItems.Add(GT);
                lvi.SubItems.Add(CMo);

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
