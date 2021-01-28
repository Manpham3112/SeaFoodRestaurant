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
    public partial class frmKhuyenMai : Form
    {
        qlKhuyenMai_BLL_DAL qlkm = new qlKhuyenMai_BLL_DAL();
        List<string> lstStringTextBox;
        List<Guna2TextBox> lstTextBox;
        public frmKhuyenMai()
        {
            InitializeComponent();
        }
        public void databingding(int rowindex)
        {
            string makm = dataGridViewKhuyenMai.Rows[rowindex].Cells["MAKM"].FormattedValue.ToString();
            string tenkm = dataGridViewKhuyenMai.Rows[rowindex].Cells["TENKM"].FormattedValue.ToString();
            string phantramkm = dataGridViewKhuyenMai.Rows[rowindex].Cells["PHANTRAMKM"].FormattedValue.ToString();
            string ngaybd = dataGridViewKhuyenMai.Rows[rowindex].Cells["NGAYBD"].FormattedValue.ToString();
            string ngaykt = dataGridViewKhuyenMai.Rows[rowindex].Cells["NGAYKT"].FormattedValue.ToString();
            txtMAKM.Text = makm;
            txtTENKM.Text = tenkm;
            txtPTKM.Text = phantramkm;
            dtpickNGAYBD.Value = Convert.ToDateTime(ngaybd);
            dtpickNGAYKT.Value = Convert.ToDateTime(ngaykt);
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
            lstStringTextBox.Add(txtMAKM.Text);
            lstStringTextBox.Add(txtTENKM.Text);
            lstStringTextBox.Add(txtPTKM.Text);
            lstStringTextBox.Add(dtpickNGAYBD.Text);
            lstStringTextBox.Add(dtpickNGAYKT.Text);
            return lstStringTextBox;
        }
        public List<Guna2TextBox> addListTextBox()
        {
            lstTextBox = new List<Guna2TextBox>();
            //lstTextBox.Add(txtMAKM);
            lstTextBox.Add(txtTENKM);
            lstTextBox.Add(txtPTKM);
            //lstTextBox.Add(dtpickNGAYBD);
            //lstTextBox.Add(dtpickNGAYKT);
            return lstTextBox;
        }
        public void setEnableTextBox(List<Guna2TextBox> lst, bool b)
        {
            foreach (Guna2TextBox s in lst)
                s.Enabled = b;
        }
        private void frmKhuyenMai_Load(object sender, EventArgs e)
        {
            dataGridViewKhuyenMai.DataSource = qlkm.loadDataGridViewKhuyenMai();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            lstTextBox = addListTextBox();
            setEnableTextBox(lstTextBox, false);
            databingding(0);
            txtMAKM.Enabled = false;
            dtpickNGAYBD.Enabled = false;
            dtpickNGAYKT.Enabled = false;
        }

        private void dataGridViewKhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            if (dataGridViewKhuyenMai.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridViewKhuyenMai.CurrentRow.Selected = true;
                databingding(e.RowIndex);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dtpickNGAYBD.Enabled = true;
            dtpickNGAYKT.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            Random r = new Random();
            int count = qlkm.demSoLuong() + 1;
            txtMAKM.Text = "KM00" + count + r.Next(0, 100);
            txtMAKM.ReadOnly = true;
            txtTENKM.Clear();
            txtPTKM.Clear();
            setEnableTextBox(lstTextBox, true);
            if (btnLuu.Enabled == true)
            {
                DialogResult result;
                result = MessageBox.Show("Bạn chưa lưu khuyến mãi " + txtMAKM.Text + ". Bạn có muốn lưu lại ?",
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
            btnThem.Enabled = false;
            dtpickNGAYBD.Enabled = true;
            dtpickNGAYKT.Enabled = true;
            btnXoa.Enabled = false;
            
            txtMAKM.Enabled = false;
            if (btnLuu.Enabled == true)
            {
                DialogResult result;
                result = MessageBox.Show("Bạn chưa lưu khuyến mãi " + txtMAKM.Text + ". Bạn có muốn lưu lại?",
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
                    if (qlkm.kiemtrakhoachinh(txtMAKM.Text) == 1)
                    {
                        try
                        {
                            DialogResult result;
                            result = MessageBox.Show("Bạn muốn lưu khuyến mãi " + txtMAKM.Text + " ?",
                                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                            if (result == DialogResult.Yes)
                            {
                                qlkm.themKhuyenMai(txtMAKM.Text, txtTENKM.Text, Convert.ToInt32(txtPTKM.Text), dtpickNGAYBD.Text, dtpickNGAYKT.Text);
                                MessageBox.Show("Lưu thông tin khuyến mãi " + txtMAKM.Text + " thành công");
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
                            result = MessageBox.Show("Bạn muốn lưu thay đổi khuyenmai " + txtMAKM.Text + " ?",
                                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                            if (result == DialogResult.Yes)
                            {
                                qlkm.suaKhuyenMai(txtMAKM.Text, txtTENKM.Text, Convert.ToInt32(txtPTKM.Text), dtpickNGAYBD.Text, dtpickNGAYKT.Text);
                                MessageBox.Show("Cập nhật thông tin khuyến mãi " + txtMAKM.Text + "thành công");
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
            txtMAKM.Clear();
            txtTENKM.Clear();
            txtPTKM.Clear();
            frmKhuyenMai_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result;
                result = MessageBox.Show("Bạn chắc chắn xóa khuyến mãi " + txtMAKM.Text + "?",
                    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    qlkm.xoaKhuyenMai(txtMAKM.Text);
                    frmKhuyenMai_Load(sender, e);
                }
                else
                    return;
            }
            catch
            {
                MessageBox.Show("Khuyến mãi " + txtMAKM.Text + " không đạt điều kiện để xóa");
            }
            frmKhuyenMai_Load(sender, e);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Length == 0)
            {
                qlkm.loadDataGridViewKhuyenMai();
            }
            else
            {
                dataGridViewKhuyenMai.DataSource = qlkm.loadTimKiemGridViewKhuyenMai(txtTimKiem.Text);
            }
        }

        private void txtPTKM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridViewKhuyenMai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRP_Click(object sender, EventArgs e)
        {
            frm_rpKhuyenMai rp = new frm_rpKhuyenMai();
            rp.Show();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
