using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestVerDoAn
{
    public partial class frmMenuChinh : Form
    {
        public frmMenuChinh()
        {
            InitializeComponent();
        }

        public bool isthoat = true;

        //tạo event đăng nhập 
        public event EventHandler dangxuat;
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //gọi event
            dangxuat(this,new EventArgs());
        }

        private void frmMenuChinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isthoat)//nếu isthoat = true thì thoát chương trình
            {
                Application.Exit(); 
            }
        }

        private void quảnLýTourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyTour QuanLyTour = new frmQuanLyTour();
            QuanLyTour.ShowDialog();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyKH QuanLyKH = new frmQuanLyKH();
            QuanLyKH.ShowDialog();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyNV QuanLyNV = new frmQuanLyNV();
            QuanLyNV.ShowDialog();
        }

        private void quảnLýThanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThanhToan ThanhToan = new frmThanhToan();
            ThanhToan.ShowDialog();
        }

        private void cóSẵnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDKTourCoSan DKTourCoSan = new frmDKTourCoSan();
            DKTourCoSan.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDKTouTheoNhuCau DKTouTheoNhuCau = new frmDKTouTheoNhuCau();
            DKTouTheoNhuCau.ShowDialog();
        }

        private void quảnLýHợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyHopDong QuanLyHopDong = new frmQuanLyHopDong();
            QuanLyHopDong.ShowDialog();
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            frmQuanLyKH QuanLyKH = new frmQuanLyKH();
            QuanLyKH.ShowDialog();
        }

        private void btnQLTour_Click(object sender, EventArgs e)
        {
            frmQuanLyTour QuanLyTour = new frmQuanLyTour();
            QuanLyTour.ShowDialog();
        }

        private void btnQLThanhT_Click(object sender, EventArgs e)
        {
            frmThanhToan ThanhToan = new frmThanhToan();
            ThanhToan.ShowDialog();
        }

        private void btnQLHopDong_Click(object sender, EventArgs e)
        {
            frmQuanLyHopDong QuanLyHopDong = new frmQuanLyHopDong();
            QuanLyHopDong.ShowDialog();
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            frmQuanLyNV QuanLyNV = new frmQuanLyNV();
            QuanLyNV.ShowDialog();
        }

        private void btnDK_Tour_CS_Click(object sender, EventArgs e)
        {
            frmDKTourCoSan DKTourCoSan = new frmDKTourCoSan();
            DKTourCoSan.ShowDialog();
        }

        private void btn_DK_TTNC_Click(object sender, EventArgs e)
        {
            frmDKTouTheoNhuCau DKTouTheoNhuCau = new frmDKTouTheoNhuCau();
            DKTouTheoNhuCau.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            dangxuat(this, new EventArgs());
        }
    }
}
