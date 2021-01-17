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
    public partial class Form1 : Form
    {
        Login_BLL_DAL login = new Login_BLL_DAL();
        public Form1()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '\u2022';
            CenterToScreen();
            btnHidePass.Image = Image.FromFile("../../img/icon/hidden.png");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtUsername.TextLength <= 0)
            {
                MessageBox.Show(grbTenDangNhap.Text + " không được bỏ trống!");
                txtUsername.Focus();
            }
            else if (txtPassword.TextLength <= 0)
            {
                MessageBox.Show(grbMatKhau.Text + " không được bỏ trống!");
                txtPassword.Focus();
            }

            else
            {
               string user = txtUsername.Text.Trim();
                string pass = txtPassword.Text.Trim();

                int kt = login.ktKH(user, pass);
                if (kt == -1)
                {
                    MessageBox.Show("Tài khoản không tồn tại");
                    return;
                }
                else if (kt == 0)
                {
                    MessageBox.Show("Mật khẩu không chính xác");
                    return;
                }
                else
                {
                    DialogResult result;
                    result = MessageBox.Show("Đăng nhập thành công", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    if (result == DialogResult.OK)
                    {
                        KHACHHANG nd = login.layKH(user);
                        this.Visible = false;

                    }
                }


            }
        }
    }
    
}
