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
    public partial class frmLoaiSP : Form
    {
        LoaiSP_BLL_DALL lsp = new LoaiSP_BLL_DALL();
        public frmLoaiSP()
        {
            InitializeComponent();
        }

        private void frmLoaiSP_Load(object sender, EventArgs e)
        {
            load_AllGrid();
        }
        void load_AllGrid()
        {
            // load loại nguyên liệu
            dgrv_HienThiLoaiSP.DataSource = lsp.loadLoaiSP();

        }
        Boolean kiemTraNull()
        {
            if (txt_MaLSP.Text != "")
            {
                if (txt_TenLSP.Text != "")
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Không được để trống tên loại sản phẩm");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Không được để trống Mã loại sản phẩm");
                return false;
            }

        }
        void textboxVeNull()
        {
            txt_TenLSP.Text = "";
        }

        private void dgrv_HienThiLoaiSP_SelectionChanged(object sender, EventArgs e)
        {
            if (dgrv_HienThiLoaiSP.SelectedCells.Count > 0)
            {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                int vitri = dgrv_HienThiLoaiSP.SelectedCells[0].RowIndex;

                string MaLNL = dgrv_HienThiLoaiSP.Rows[vitri].Cells[0].Value.ToString().Trim();
                string TenLNL = dgrv_HienThiLoaiSP.Rows[vitri].Cells[1].Value.ToString().Trim();

                txt_MaLSP.Text = MaLNL;
                txt_TenLSP.Text = TenLNL;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            load_AllGrid();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            txt_TenLSP.Text = "";
            txt_MaLSP.Text = lsp.taoMaLoaiSP();
            txt_TenLSP.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txt_MaLSP.Enabled = false;
            txt_TenLSP.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result;

                result = MessageBox.Show("Bạn chắc chắn xóa loại sản phẩm " + txt_MaLSP.Text + " ?",
                    "Thông báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    lsp.xoaLSP(txt_MaLSP.Text);
                    load_AllGrid();
                }
                else
                {
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Loại sản phẩm " + txt_MaLSP.Text + " không đạt điều kiện để xóa");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (kiemTraNull() == true)
            {
                if (lsp.kiemtrakhoachinh(txt_MaLSP.Text) == 1)
                {
                    lsp.themLoaiSP(txt_MaLSP.Text, txt_TenLSP.Text);
                    load_AllGrid();
                    textboxVeNull();
                    MessageBox.Show("Lưu thành công");
                }
                else
                {
                    lsp.suaLoaiSP(txt_MaLSP.Text.Trim(), txt_TenLSP.Text);
                    load_AllGrid();
                    textboxVeNull();
                    MessageBox.Show("Lưu thành công");
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

            if (txtTimKiem.Text.Length > 0)
            {
                dgrv_HienThiLoaiSP.DataSource = lsp.loadTimKiemGridViewLoaiSP(txtTimKiem.Text);
            }
            else
            {
                dgrv_HienThiLoaiSP.DataSource = lsp.loadLoaiSP();
            }
        }

        private void btnRP_Click(object sender, EventArgs e)
        {
            frmLoaiSP rp = new frmLoaiSP();
            rp.Show();
        }
    }
}
