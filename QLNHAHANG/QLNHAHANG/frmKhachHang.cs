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
using Guna.UI2.WinForms;
namespace QLNHAHANG
{
    public partial class frmKhachHang : Form
    {
        qlKhachHang_BLL_DAL qlkh = new qlKhachHang_BLL_DAL();
        List<string> lstStringTextBox;
        List<Guna2TextBox> lstTextBox;
        public frmKhachHang()
        {
            InitializeComponent();
        }
        public void databingding(int rowindex)
        {
            string makh = dataGridViewKhachHang.Rows[rowindex].Cells["MAKH"].FormattedValue.ToString();
            string tenkh = dataGridViewKhachHang.Rows[rowindex].Cells["TENKH"].FormattedValue.ToString();
            string sdt = dataGridViewKhachHang.Rows[rowindex].Cells["SDT"].FormattedValue.ToString();
            string diachi = dataGridViewKhachHang.Rows[rowindex].Cells["DIACHI"].FormattedValue.ToString();
            string taikhoan = dataGridViewKhachHang.Rows[rowindex].Cells["TAIKHOAN"].FormattedValue.ToString();
            string matkhau = dataGridViewKhachHang.Rows[rowindex].Cells["MATKHAU"].FormattedValue.ToString();
            txtMaKhachHang.Text = makh;
            txtTenKH.Text = tenkh;
            txtSDT.Text = sdt;
            txtDiaChi.Text = diachi;
            txtTaiKhoan.Text = taikhoan;
            txtMatKhau.Text = matkhau;
        }
        public bool isEmpty(List<string> lst)
        {
            int count = 0;
            foreach (string s in lst)
            {
                if (s.Length == 0)
                    count++;
            }
            return count != 0;
        }
        public List<string> addListString()
        {
            lstStringTextBox = new List<string>();
           lstStringTextBox.Add(txtMaKhachHang.Text);
            lstStringTextBox.Add(txtTenKH.Text);
            lstStringTextBox.Add(txtSDT.Text);
            lstStringTextBox.Add(txtDiaChi.Text);
            lstStringTextBox.Add(txtTaiKhoan.Text);
            lstStringTextBox.Add(txtMatKhau.Text);
            return lstStringTextBox;
        }
        public List<Guna2TextBox> addListTextBox()
        {
            lstTextBox = new List<Guna2TextBox>();
            //lstTextBox.Add(txtMaKhachHang);
            lstTextBox.Add(txtTenKH);
            lstTextBox.Add(txtDiaChi);
            lstTextBox.Add(txtSDT);
            lstTextBox.Add(txtTaiKhoan);
            lstTextBox.Add(txtMatKhau);
            return lstTextBox;
        }
        public void setEnableTextBox(List<Guna2TextBox> lst, bool b)
        {
            foreach (Guna2TextBox s in lst)
                s.Enabled = b;
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            dataGridViewKhachHang.DataSource = qlkh.loadDataGridViewKhachHang();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            lstTextBox = addListTextBox();
            setEnableTextBox(lstTextBox, false);
            databingding(0);
            txtMaKhachHang.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int count = qlkh.demSoLuong() + 1;
            txtMaKhachHang.Text = "KH00" + count + r.Next(0, 1000);
            txtMaKhachHang.ReadOnly= true;
            txtTenKH.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
            setEnableTextBox(lstTextBox, true);
            if (btnLuu.Enabled == true)
            {
                DialogResult result;
                result = MessageBox.Show("Bạn chưa lưu khách hàng " + txtMaKhachHang.Text + ". Bạn có muốn lưu lại ?",
                    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                    btnLuu_Click(sender, e);
                else
                    return;
            }
            else
                btnLuu.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            setEnableTextBox(lstTextBox, true);
            txtMaKhachHang.Enabled = false;
            if (btnLuu.Enabled == true)
            {
                DialogResult result;
                result = MessageBox.Show("Bạn chưa lưu khách hàng " + txtMaKhachHang.Text + ". Bạn có muốn lưu lại?",
                    "Thông báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                    btnLuu_Click(sender, e);
                else
                    return;
            }
            else
                btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            lstStringTextBox = addListString();
            try
            {
                if (!isEmpty(lstStringTextBox))
                {
                    if (txtSDT.Text.Length != 10)
                    {
                        MessageBox.Show("Số điện thoại bạn nhập không hợp lệ");
                        return;
                    }
                    else
                    {
                        if (qlkh.kiemtrakhoachinh(txtMaKhachHang.Text) == 1)
                        {
                            try
                            {
                                DialogResult result;
                                result = MessageBox.Show("Bạn muốn lưu khách hàng " + txtMaKhachHang.Text + " ?",
                                    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                                if (result == DialogResult.Yes)
                                {
                                    string hashPW = Utils.Encrypt(txtMatKhau.Text);
                                    qlkh.themKhachHang(txtMaKhachHang.Text, txtTenKH.Text, txtSDT.Text, txtDiaChi.Text, txtTaiKhoan.Text, hashPW);
                                    MessageBox.Show("Lưu thông tin khách hàng " + txtMaKhachHang.Text + " thành công");
                                }
                                else
                                    return;
                            }
                            catch(Exception ex)
                            {
                                ex.Message.ToString();
                                MessageBox.Show("Lỗi hệ thống!");
                            }
                        }
                        else
                        {
                            try
                            {
                                DialogResult result;
                                result = MessageBox.Show("Bạn muốn lưu thay đổi khách hàng " + txtMaKhachHang.Text + " ?",
                                    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                                if (result == DialogResult.Yes)
                                {
                                    qlkh.suaKhachHang(txtMaKhachHang.Text, txtTenKH.Text, txtSDT.Text, txtDiaChi.Text,  txtTaiKhoan.Text, txtMatKhau.Text);
                                    MessageBox.Show("Cập nhật thông tin khách hàng " + txtMaKhachHang.Text + "thành công");
                                }
                                else
                                    return;
                            }
                            catch
                            {
                                MessageBox.Show("Lỗi hệ thống!");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin !");
                    return;
                }

            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống!");
            }
            txtMaKhachHang.Clear();
            txtTenKH.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
            frmKhachHang_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result;
                result = MessageBox.Show("Bạn chắc chắn xóa khách hàng " + txtMaKhachHang.Text + "?",
                    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    qlkh.xoaKhachHang(txtMaKhachHang.Text);
                    frmKhachHang_Load(sender, e);
                }
                else
                    return;
            }
            catch
            {
                MessageBox.Show("Khách hàng " + txtMaKhachHang.Text + " không đạt điều kiện để xóa");
            }
        }

        private void dataGridViewKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            if (dataGridViewKhachHang.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridViewKhachHang.CurrentRow.Selected = true;
                databingding(e.RowIndex);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Length == 0)
            {
                qlkh.loadDataGridViewKhachHang();
            }
            else
            {
                dataGridViewKhachHang.DataSource = qlkh.loadTimKiemGridViewKhachHang(txtTimKiem.Text);
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
