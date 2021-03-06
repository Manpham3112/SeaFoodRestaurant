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
namespace QLNHAHANG
{
    public partial class frmLoaiNguyenLieu : Form
    {
        LoaiNguyenLieu_BLL_DAL lnl = new LoaiNguyenLieu_BLL_DAL();
        public frmLoaiNguyenLieu()
        {
            InitializeComponent();
        }
        public void databingding(int rowindex)
        {
            string malnl = dgrv_HienThiLoaiNguyenLieu.Rows[rowindex].Cells["MALNL"].FormattedValue.ToString();
            string tenlnl = dgrv_HienThiLoaiNguyenLieu.Rows[rowindex].Cells["TENLNL"].FormattedValue.ToString();
            txt_MaLNL.Text = malnl;
            txt_TenLNL.Text = tenlnl;
        }

        private void frmLoaiNguyenLieu_Load(object sender, EventArgs e)
        {
            load_AllGrid();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            txt_TenLNL.Enabled = false;
            txt_MaLNL.Enabled = false;
            txt_MaLNL.ReadOnly = true;
        }
        void load_AllGrid()
        {
            // load loại nguyên liệu
            dgrv_HienThiLoaiNguyenLieu.DataSource = lnl.loadLoaiNguyenLieu();

        }
        Boolean kiemTraNull()
        {
            if (txt_MaLNL.Text != "")
            {
                if (txt_TenLNL.Text != "")
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Không được để trống tên loại nguyên liệu");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Không được để trống Mã loại nguyên liệu");
                return false;
            }

        }

        private void dgrv_HienThiLoaiNguyenLieu_SelectionChanged(object sender, EventArgs e)
        {
            //if (dgrv_HienThiLoaiNguyenLieu.SelectedCells.Count > 0)
            //{
            //    btnSua.Enabled = true;
            //    btnXoa.Enabled = true;
            //    int vitri = dgrv_HienThiLoaiNguyenLieu.SelectedCells[0].RowIndex;

            //    string MaLNL = dgrv_HienThiLoaiNguyenLieu.Rows[vitri].Cells[0].Value.ToString().Trim();
            //    string TenLNL = dgrv_HienThiLoaiNguyenLieu.Rows[vitri].Cells[1].Value.ToString().Trim();

            //    txt_MaLNL.Text = MaLNL;
            //    txt_TenLNL.Text = TenLNL;
            //}
        }
        void textboxVeNull()
        {
            txt_TenLNL.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            load_AllGrid();
            txt_TenLNL.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            txt_TenLNL.Text = "";
            txt_MaLNL.Text = lnl.taoMaLoaiNguyenLieu();
            txt_TenLNL.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txt_MaLNL.Enabled = false;
            txt_TenLNL.Enabled = true;
            txt_TenLNL.Focus();
            btnThem.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result;

                result = MessageBox.Show("Bạn chắc chắn xóa loại nguyên liệu " + txt_MaLNL.Text + " ?",
                    "Thông báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    lnl.xoaLNL(txt_MaLNL.Text);
                    load_AllGrid();
                }
                else
                {
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Loại nguyên liệu " + txt_MaLNL.Text + " không đạt điều kiện để xóa");
            }
            frmLoaiNguyenLieu_Load(sender,e);

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (kiemTraNull() == true)
            {
                if (lnl.kiemtrakhoachinh(txt_MaLNL.Text) == 1)
                {
                    lnl.themLoaiNL(txt_MaLNL.Text, txt_TenLNL.Text);
                    load_AllGrid();
                    textboxVeNull();
                    MessageBox.Show("Lưu thành công");
                }
                else
                {
                    lnl.suaLoaiNL(txt_MaLNL.Text.Trim(), txt_TenLNL.Text);
                    load_AllGrid();
                    textboxVeNull();
                    MessageBox.Show("Lưu thành công");
                }
            }
            frmLoaiNguyenLieu_Load(sender, e);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Length > 0)
            {
                dgrv_HienThiLoaiNguyenLieu.DataSource = lnl.loadTimKiemGridViewLoaiNL(txtTimKiem.Text);
            }
            else
            {
                dgrv_HienThiLoaiNguyenLieu.DataSource = lnl.loadLoaiNguyenLieu();
            }
        }

        private void btnRP_Click(object sender, EventArgs e)
        {
            frm_rpLoaiNguyenLieu rp = new frm_rpLoaiNguyenLieu();
            rp.Show();
        }

        private void dgrv_HienThiLoaiNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            txt_MaLNL.Enabled = false;
            txt_TenLNL.Enabled = false;
            if (dgrv_HienThiLoaiNguyenLieu.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgrv_HienThiLoaiNguyenLieu.CurrentRow.Selected = true;
                databingding(e.RowIndex);
            }
        }
    }
}
