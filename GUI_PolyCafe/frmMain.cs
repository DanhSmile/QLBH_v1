using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_PolyCafe
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau reset = new frmDoiMatKhau();
            reset.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void thẻLưuĐộngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTheLuuDong theLuuDong = new frmTheLuuDong();
            theLuuDong.ShowDialog();
        }

        private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDoanhThuNhanVien dtnv = new frmDoanhThuNhanVien();
            dtnv.ShowDialog();
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLySanPham sp = new frmQuanLySanPham();
            sp.ShowDialog();
        }

        private void loạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyLoaiSanPham lsp = new frmQuanLyLoaiSanPham();
            lsp.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanVien nv = new frmQuanLyNhanVien();
            nv.ShowDialog();
        }

        private void loạiHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTKDoanhThuLSP dtlsp = new frmTKDoanhThuLSP();
            dtlsp.ShowDialog();
        }

        private void phiếuBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuBanHang pbh = new frmPhieuBanHang();    
            pbh.ShowDialog();
        }
    }
}
