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
    public partial class frmDoiMatKhau : Form
    {
        NHANVIEN nv;
        NhanVien_BLL_DAL bll = new NhanVien_BLL_DAL();
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        internal void DangNhapNV(NHANVIEN nv)
        {
            this.nv = nv;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NHANVIEN cuurrentUser = bll.getNhanVienTheoMa(nv.MANV);
            string pass = Utils.Decrypt(cuurrentUser.MATKHAU.Trim());
            if (txtPassword.Text == pass)
            {
                string hashPW = Utils.Encrypt(txtMatKhauMoi.Text);
                if (bll.UpdatePassWord(nv.MANV, hashPW))
                {
                    MessageBox.Show("Đổi mật khẩu thành công");
                    this.Close();
                }
            }
        }

    }
}
