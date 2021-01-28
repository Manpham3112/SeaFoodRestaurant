using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;
namespace QLNHAHANG
{
    public partial class frmThongTinNhanVien : Form
    {
        NHANVIEN nv;
        NhanVien_BLL_DAL bll = new NhanVien_BLL_DAL();
        public frmThongTinNhanVien()
        {
            InitializeComponent();
        }
        public frmThongTinNhanVien(bool show)
        {
            InitializeComponent();
            btnBackToManager.Visible = show;
        }

        internal void DangNhapNV(NHANVIEN nv)
        {
            this.nv = nv;
            txtMaNV.Text = nv.MANV;
           
        }

        private void btnBackToManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu frm = new TrangChu();
            frm.DangNhapNV(nv);
            frm.WindowState = FormWindowState.Maximized;
            //frm.Show();
            this.Close();
        }

        private void frmThongTinNhanVien_Load(object sender, EventArgs e)
        {
            NHANVIEN currentUser = bll.getNhanVienTheoMa(nv.MANV);
            txtHoTen.Text = currentUser.TENNV;
            txtDiaChi.Text = currentUser.DIACHI;
            txtSDT.Text = currentUser.SDT;
            txtNhomQuyen.Text = bll.layNhomtheoMa(nv.MANQ).TENNQ;
            txtNgaySinh.Text = currentUser.NGAYSINH?.ToString();
         
            txtMaNV.Enabled = false;
            txtHoTen.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSDT.Enabled = false;
            txtNgaySinh.Enabled = false;
            txtNhomQuyen.Enabled = false;

        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.DangNhapNV(nv);
            frm.ShowDialog();
        }
    }
}
