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
    public partial class frmNhanVien : Form
    {
        NhanVien_BLL_DAL qlnv = new NhanVien_BLL_DAL();
        List<NHANVIEN> lstNhanVien;
        public frmNhanVien()
        {
            InitializeComponent();
            lstNhanVien = qlnv.loadListNhanVien();
        }

        private void txtMaNhaCungCap_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            reset();
            loadListNhanVien();
            loadCboNguoiDung();
            setHeaderNV();
            databingding(0);
            txtSoDienThoai.KeyPress += txtSoDienThoai_KeyPress;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMa.Enabled = false;
            txtHoTen.Enabled = false;
            txtDiaChi.Enabled = false;
            txtMatKhau.Enabled = false;
            txtSoDienThoai.Enabled = false;
            cboLoaiNhanVien.Enabled = false;
            dateTimePickerNgaySinh.Enabled = false;
        }
        private void loadDataGridViewNhanVien()
        {
            dataGridViewNhanVien.DataSource = qlnv.loadDataGridViewNhanVien();
        }

        private void loadListNhanVien()
        {
            dataGridViewNhanVien.DataSource = lstNhanVien;
        }

        private void loadCboNguoiDung()
        {
            cboLoaiNhanVien.DataSource = qlnv.loadCboNhomNhanVien();
            cboLoaiNhanVien.DisplayMember = "TENNQ";
            cboLoaiNhanVien.ValueMember = "MANQ";
        }
        public void reset()
        {
            txtMa.Clear();
            txtHoTen.Clear();
            txtSoDienThoai.Clear();
            txtDiaChi.Clear();
            txtMatKhau.Clear();

        }
        public void databingding(int rowindex)
        {
            txtMa.Text = dataGridViewNhanVien.Rows[rowindex].Cells["MANV"].FormattedValue.ToString();
            txtHoTen.Text = dataGridViewNhanVien.Rows[rowindex].Cells["TENNV"].FormattedValue.ToString();
            txtSoDienThoai.Text = dataGridViewNhanVien.Rows[rowindex].Cells["SDT"].FormattedValue.ToString();
            txtDiaChi.Text = dataGridViewNhanVien.Rows[rowindex].Cells["DIACHI"].FormattedValue.ToString();
            dateTimePickerNgaySinh.Value = Convert.ToDateTime(dataGridViewNhanVien.Rows[rowindex].Cells["NGAYSINH"].FormattedValue.ToString());
            cboLoaiNhanVien.SelectedValue = dataGridViewNhanVien.Rows[rowindex].Cells["MANQ"].FormattedValue.ToString();
            ckHoatDong.Checked = Convert.ToBoolean(dataGridViewNhanVien.Rows[rowindex].Cells["TINHTRANG"].FormattedValue.ToString());
            txtMatKhau.Text = dataGridViewNhanVien.Rows[rowindex].Cells["MATKHAU"].FormattedValue.ToString();
        }
        public Boolean checkHoatDong()
        {
            if (ckHoatDong.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridViewNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            try
            {
                if (dataGridViewNhanVien.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridViewNhanVien.CurrentRow.Selected = true;
                    databingding(e.RowIndex);
                }

            }
            catch
            {
                return;
            }
        }
        public void setHeaderNV()
        {
            dataGridViewNhanVien.Columns["MANV"].HeaderText = "Mã nhân viên";
            dataGridViewNhanVien.Columns["TENNV"].HeaderText = "Họ và tên";
            dataGridViewNhanVien.Columns["DIACHI"].HeaderText = "Địa chỉ";
            dataGridViewNhanVien.Columns["SDT"].HeaderText = "Số điện thoại";
            dataGridViewNhanVien.Columns["MANV"].HeaderText = "Mã nhân viên";
            dataGridViewNhanVien.Columns["TINHTRANG"].Visible = false;
            dataGridViewNhanVien.Columns["NHOMQUYEN"].Visible = false;

        }
        public bool kiemtraMa()
        {
            string input = txtMa.Text;
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Mã nhân viên không được bỏ trống");
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool kiemtraTenNhanVien()
        {
            string input = txtHoTen.Text;
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Tên nhân viên không được bỏ trống");
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool kiemtraSoDienThoai()
        {
            string input = txtSoDienThoai.Text;
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Số điện thoại không được bỏ trống");
                return false;
            }
            else if (input.Length != 10)
            {
                MessageBox.Show("Số điện thoại bao gồm 10 số.");
                return false;
            }
            else
            {
                return true;
            }

        }
        public bool kiemtraDiaChi()
        {
            string input = txtDiaChi.Text;
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Địa chỉ không được bỏ trống");
                return false;
            }
            else
            {
                return true;
            }

        }
        TimeSpan getDateDifference(DateTime date1, DateTime date2)
        {
            TimeSpan ts = date1 - date2;
            int differenceInDays = ts.Days;
            string differenceAsString = differenceInDays.ToString();
            return ts;

        }
        public bool kiemtraNgaySinh()
        {
            string input = dateTimePickerNgaySinh.Value.ToString();
            TimeSpan difference = getDateDifference(DateTime.Now, dateTimePickerNgaySinh.Value);
            int differenceInDay = difference.Days;
            if (differenceInDay < 18)
            {
                MessageBox.Show("Nhân viên chưa đủ 18 tuổi.");
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool kiemtraMatKhau()
        {
            string input = txtMatKhau.Text;
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Mật khẩu không được bỏ trống");
                return false;
            }
            else
            {
                return true;
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            reset();
            int count = qlnv.demSoLuong() + 1;
            txtMa.Text = "NV00" + count + r.Next(0, 1000);
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            txtHoTen.Enabled = true;
            txtDiaChi.Enabled = true;
            txtMatKhau.Enabled = true;
            txtSoDienThoai.Enabled = true;
            cboLoaiNhanVien.Enabled = true;
            dateTimePickerNgaySinh.Enabled = true;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            txtHoTen.Enabled = true;
            txtDiaChi.Enabled = true;
            txtMatKhau.Enabled = false;
            txtSoDienThoai.Enabled = true;
            cboLoaiNhanVien.Enabled = true;
            dateTimePickerNgaySinh.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (!kiemtraMa() || !kiemtraTenNhanVien() || !kiemtraSoDienThoai() || !kiemtraDiaChi()
                || !kiemtraNgaySinh() || !kiemtraMatKhau())
            {
                frmNhanVien_Load(sender, e);
                return;
            }
            else
            {
                if (qlnv.kiemTraKhoaChinh(txtMa.Text) != 0)
                {
                    qlnv.suaNhanVien(txtMa.Text, txtHoTen.Text, txtSoDienThoai.Text, txtDiaChi.Text,
                      dateTimePickerNgaySinh.Value, cboLoaiNhanVien.SelectedValue.ToString(),
                        checkHoatDong(), txtMatKhau.Text);
                    //MessageBox.Show(checkHoatDong() + "");
                    MessageBox.Show("Sửa thành công");
                    loadDataGridViewNhanVien();
                    btnThem.Enabled = true;
                    btnLuu.Enabled = false;
                    frmNhanVien_Load(sender, e);
                }
                else
                {
                    string hashPW = Utils.Encrypt(txtMatKhau.Text);
                    qlnv.themNhanVien(txtMa.Text, txtHoTen.Text, txtSoDienThoai.Text, txtDiaChi.Text,
                         dateTimePickerNgaySinh.Value,  cboLoaiNhanVien.SelectedValue.ToString(),
                        true, hashPW);
                    MessageBox.Show("Thêm thành công");
                    loadDataGridViewNhanVien();
                    btnSua.Enabled = false;
                    btnLuu.Enabled = false;
                    btnThem.Enabled = false;
                    frmNhanVien_Load(sender, e);
                }
            }
            frmNhanVien_Load(sender, e);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                qlnv.xoaNhanVien(txtMa.Text);
                MessageBox.Show("Xóa thành công");
                loadDataGridViewNhanVien();
                btnXoa.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Nhân viên" + txtMa.Text + " không thể xóa");
            }
            frmNhanVien_Load(sender, e);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length == 0)
            {
                loadDataGridViewNhanVien();
            }
            else
            {
                dataGridViewNhanVien.DataSource = qlnv.loadGridViewTimKiemNhanVien(txtSearch.Text);
            }
        }

        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRP_Click(object sender, EventArgs e)
        {
            frm_rpNhanVien rp = new frm_rpNhanVien();
            rp.Show();
        }
    }
}
