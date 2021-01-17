using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;
using Guna.UI2.WinForms;

namespace QLNHAHANG
{
    public partial class frmDichVu : Form
    {
        qlDichVu_BLL_DAL qldv = new qlDichVu_BLL_DAL();
        List<string> lstStringTextBox;
        List<Guna2TextBox> lstTextBox;
        public frmDichVu()
        {
            InitializeComponent();
        }

        private void frmDichVu_Load(object sender, EventArgs e)
        {
            dataGridViewDichVu.DataSource = qldv.loadDataGridViewDichVu();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            txtMaDV.Enabled = false;
            lstTextBox = addListTextBox();
            setEnableTextBox(lstTextBox, false);
            databingding(0);
            setHeaderDV();
            
        }
        public void databingding(int rowindex)
        {
            string madv = dataGridViewDichVu.Rows[rowindex].Cells["MADV"].FormattedValue.ToString();
            string tendv = dataGridViewDichVu.Rows[rowindex].Cells["TENDV"].FormattedValue.ToString();
            string giadv = dataGridViewDichVu.Rows[rowindex].Cells["GIADV"].FormattedValue.ToString();
            string mota = dataGridViewDichVu.Rows[rowindex].Cells["MOTA"].FormattedValue.ToString();
            txtMaDV.Text = madv;
            txtTenDV.Text = tendv;
            txtMoTa.Text = mota;
            txtGiaDV.Text = giadv;
            foreach (DataGridViewRow item in dataGridViewDichVu.SelectedRows)
            {

                try
                {
                    pcSp.Image = Image.FromFile("../../img/img_sanpham/" + dataGridViewDichVu.CurrentRow.Cells["ANH"].Value.ToString());
                }
                catch (Exception)
                {
                    return;
                    throw;
                }
            }
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
            lstStringTextBox.Add(txtMaDV.Text);
            lstStringTextBox.Add(txtTenDV.Text);
            lstStringTextBox.Add(txtMoTa.Text);
            lstStringTextBox.Add(txtGiaDV.Text);
            return lstStringTextBox;
        }
        public List<Guna2TextBox> addListTextBox()
        {
            lstTextBox = new List<Guna2TextBox>();
            //lstTextBox.Add(txtMaDV);
            lstTextBox.Add(txtTenDV);
            lstTextBox.Add(txtGiaDV);
            lstTextBox.Add(txtMoTa);
            return lstTextBox;
        }
        public void setEnableTextBox(List<Guna2TextBox> lst, bool b)
        {
            foreach (Guna2TextBox s in lst)
                s.Enabled = b;
        }

        private void dataGridViewDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            if (dataGridViewDichVu.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridViewDichVu.CurrentRow.Selected = true;
                databingding(e.RowIndex);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int count = qldv.demSoLuong() + 1;
            txtMaDV.Text = "DV00" + count + r.Next(0, 99);
            txtMaDV.ReadOnly = true;
            txtTenDV.Clear();
            txtGiaDV.Clear();
            txtMoTa.Clear();
            pcSp.Image = null;
            setEnableTextBox(lstTextBox, true);
            if (btnLuu.Enabled == true)
            {
                DialogResult result;
                result = MessageBox.Show("Bạn chưa lưu dịch vụ " + txtMaDV.Text + ". Bạn có muốn lưu lại ?",
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
            txtMaDV.Enabled = false;
            if (btnLuu.Enabled == true)
            {
                DialogResult result;
                result = MessageBox.Show("Bạn chưa lưu dịch vụ " + txtMaDV.Text + ". Bạn có muốn lưu lại?",
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result;
                result = MessageBox.Show("Bạn chắc chắn xóa dịch vụ " + txtMaDV.Text + "?",
                    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    qldv.xoaDichVu(txtMaDV.Text);
                    frmDichVu_Load(sender, e);
                }
                else
                    return;
            }
            catch
            {
                MessageBox.Show("Dịch vụ " + txtMaDV.Text + " không đạt điều kiện để xóa");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            lstStringTextBox = addListString();
            DICHVU dv = new DICHVU();
            dv.MADV = txtMaDV.Text;
            dv.TENDV = txtTenDV.Text;
            dv.MOTA = txtMoTa.Text;
            dv.GIADV = Convert.ToInt32(txtGiaDV.Text);
            try
            {
                dv.ANH = Path.GetFileName(pcSp.Tag.ToString());
                MessageBox.Show(dv.ANH);
                System.IO.File.Copy(pcSp.Tag.ToString(), "../../img/img_sanpham/" + dv.ANH, true);
            }
            catch (Exception)
            {
                dv.ANH = "no-image.jpg";
            }
            try
            {
                if (!isEmpty(lstStringTextBox))
                {
                    if (txtGiaDV.Text.Equals(0) == true)
                    {
                        MessageBox.Show("Số tiền bạn nhập không hợp lệ");
                        return;
                    }
                    else
                    {
                        if (qldv.kiemtrakhoachinh(txtMaDV.Text) == 1)
                        {
                            try
                            {
                                DialogResult result;
                                result = MessageBox.Show("Bạn muốn lưu dịch vụ " + txtMaDV.Text + " ?",
                                    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                                if (result == DialogResult.Yes)
                                {

                                    qldv.themDV(dv);
                                    MessageBox.Show("Lưu thông tin dịch vụ " + txtMaDV.Text + " thành công");
                                }
                                else
                                    return;
                            }
                            catch
                            {
                                MessageBox.Show("Lỗi hệ thống!");
                            }
                        }
                        else
                        {
                            try
                            {
                                DialogResult result;
                                result = MessageBox.Show("Bạn muốn lưu thay đổi dịch vụ " + txtMaDV.Text + " ?",
                                    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                                if (result == DialogResult.Yes)
                                {
                                    qldv.suaDV(dv);
                                    MessageBox.Show("Cập nhật thông tin dịch vụ " + txtMaDV.Text + "thành công");
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
            qldv.submitChange();
            txtMaDV.Clear();
            txtTenDV.Clear();
            txtMoTa.Clear();
            txtGiaDV.Clear();
            frmDichVu_Load(sender, e);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Length == 0)
            {
                qldv.loadDataGridViewDichVu();
            }
            else
            {
                dataGridViewDichVu.DataSource = qldv.loadTimKiemGridViewDichVu(txtTimKiem.Text);
            }
        }
        public void setHeaderDV()
        {
            dataGridViewDichVu.Columns["TRANGTHAI"].Visible = false;

        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pcSp.Image = new Bitmap(open.FileName);
                // image file path  
                pcSp.Tag = open.FileName;
            }
        }

        private void txtGiaDV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGiaDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
