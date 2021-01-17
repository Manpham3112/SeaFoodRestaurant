﻿using System;
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
    public partial class frmNhaCungCap : Form
    {
        qlNhaCungCap_BLL_DAL qlncc = new qlNhaCungCap_BLL_DAL();
        List<string> lstStringTextBox;
        List<Guna2TextBox> lstTextBox;
        public frmNhaCungCap()
        {
            InitializeComponent();
        }
        public void databingding(int rowindex)
        {
            string mancc = dataGridViewNhaCungCap.Rows[rowindex].Cells["MANCC"].FormattedValue.ToString();
            string tenncc = dataGridViewNhaCungCap.Rows[rowindex].Cells["TENNCC"].FormattedValue.ToString();
            string diachi = dataGridViewNhaCungCap.Rows[rowindex].Cells["DIACHI"].FormattedValue.ToString();
            string sdt = dataGridViewNhaCungCap.Rows[rowindex].Cells["SDT"].FormattedValue.ToString();
            txtMaNhaCungCap.Text = mancc;
            txtTenNhaCungCap.Text = tenncc;
            txtDiaChi.Text = diachi;
            txtSoDienThoai.Text = sdt;

        }
        public void reset()
        {
            txtMaNhaCungCap.Clear();
            txtTenNhaCungCap.Clear();
            txtDiaChi.Clear();
            txtSoDienThoai.Clear();
        }
        public bool isEmpty(List<string> lst)
        {
            int count = 0;
            foreach (string s in lst)
            {
                if (s.Length == 0)
                {
                    count++;
                }
            }
            return count != 0;
        }

        public List<string> addListString()
        {
            lstStringTextBox = new List<string>();
            lstStringTextBox.Add(txtMaNhaCungCap.Text);
            lstStringTextBox.Add(txtTenNhaCungCap.Text);
            lstStringTextBox.Add(txtSoDienThoai.Text);
            lstStringTextBox.Add(txtDiaChi.Text);
            return lstStringTextBox;
        }
        public List<Guna2TextBox> addListTextBox()
        {
            lstTextBox = new List<Guna2TextBox>();
            lstTextBox.Add(txtMaNhaCungCap);
            lstTextBox.Add(txtTenNhaCungCap);
            lstTextBox.Add(txtSoDienThoai);
            lstTextBox.Add(txtDiaChi);
            return lstTextBox;
        }
        public void setEnableTextBox(List<Guna2TextBox> lst, bool b)
        {
            foreach (Guna2TextBox s in lst)
            {
                s.Enabled = b;
            }
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            dataGridViewNhaCungCap.DataSource = qlncc.loadDataGridViewNhaCungCap();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            lstTextBox = addListTextBox();
            setEnableTextBox(lstTextBox, false);

            databingding(0);
        }

        private void dataGridViewNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            if (dataGridViewNhaCungCap.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridViewNhaCungCap.CurrentRow.Selected = true;
                databingding(e.RowIndex);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            reset();
            setEnableTextBox(lstTextBox, true);
            //txtMaNhaCungCap.Enabled = false;
            //int count = 0;
            //count = dataGridViewNhaCungCap.Rows.Count + 1;
            //txtMaNhaCungCap.Text = "NCC00" + count;

            if (btnLuu.Enabled == true)
            {
                DialogResult result;

                result = MessageBox.Show("Bạn chưa lưu nhà cung cấp " + txtMaNhaCungCap.Text + ". Bạn có muốn lưu lại ?",
                    "Thông báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    btnLuu_Click(sender, e);
                }
                else
                {
                    return;
                }

            }
            else
            {
                btnLuu.Enabled = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            lstStringTextBox = addListString();
            try
            {
                if (!isEmpty(lstStringTextBox))
                {
                    if (txtSoDienThoai.Text.Length != 10)
                    {
                        MessageBox.Show("Số điện thoại bạn nhập không hợp lệ");
                        return;
                    }

                    else
                    {
                        if (qlncc.kiemtrakhoachinh(txtMaNhaCungCap.Text) == 1)
                        {
                            try
                            {
                                DialogResult result;

                                result = MessageBox.Show("Bạn muốn lưu nhà cung cấp " + txtMaNhaCungCap.Text + " ?",
                                    "Thông báo", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                                if (result == DialogResult.Yes)
                                {
                                    qlncc.themNhaCungCap(txtMaNhaCungCap.Text, txtTenNhaCungCap.Text, txtDiaChi.Text, txtSoDienThoai.Text);
                                    MessageBox.Show("Lưu thông tin nhà cung cấp " + txtMaNhaCungCap.Text + " thành công");
                                }
                                else
                                {
                                    return;
                                }
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

                                result = MessageBox.Show("Bạn muốn lưu thay đổi nhà cung cấp " + txtMaNhaCungCap.Text + " ?",
                                    "Thông báo", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                                if (result == DialogResult.Yes)
                                {
                                    qlncc.suaNhaCungCap(txtMaNhaCungCap.Text, txtTenNhaCungCap.Text, txtDiaChi.Text, txtSoDienThoai.Text);
                                    MessageBox.Show("Cập nhật thông tin nhà cung cấp " + txtMaNhaCungCap.Text + "thành công");
                                }
                                else
                                {
                                    return;
                                }
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
            reset();
            frmNhaCungCap_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            setEnableTextBox(lstTextBox, true);
            txtMaNhaCungCap.Enabled = false;
            if (btnLuu.Enabled == true)
            {
                DialogResult result;

                result = MessageBox.Show("Bạn chưa lưu Nhà cung cấp " + txtMaNhaCungCap.Text + ". Bạn có muốn lưu lại ?",
                    "Thông báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    btnLuu_Click(sender, e);
                }
                else
                {
                    return;
                }
            }
            else
            {
                btnLuu.Enabled = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result;

                result = MessageBox.Show("Bạn chắc chắn xóa nhà cung cấp " + txtMaNhaCungCap.Text + " ?",
                    "Thông báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    qlncc.xoaNhaCungCap(txtMaNhaCungCap.Text);
                    frmNhaCungCap_Load(sender, e);
                }
                else
                {
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Nhà cung cấp " + txtMaNhaCungCap.Text + " không đạt điều kiện để xóa");
            }
        }

        private void btnRP_Click(object sender, EventArgs e)
        {
            frm_rpNhaCungCap rp = new frm_rpNhaCungCap();
            rp.Show();
        }
    }
}
