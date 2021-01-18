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
    public partial class frmNguyenLieu : Form
    {
        NguyenLieu_BLL_DAL nl = new NguyenLieu_BLL_DAL();
        public frmNguyenLieu()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            load_AllGrid();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            textboxVeNull();
            txt_MaNguyenLieu.Text = nl.taoMaNguyenLieu();
            txt_TenNguyenLieu.Focus();
            cbo_TenLoai.SelectedIndex = 0;
            txt_TenNguyenLieu.Enabled = true;
            cbo_TenLoai.Enabled = true;
            txt_HSD.Enabled = true;
            txt_DonVi.Enabled = true;
            txt_SoLuong.Enabled = true;
        }
        void textboxVeNull()
        {
            txt_TenNguyenLieu.Text = "";
            txt_DonVi.Text = "";
            txt_SoLuong.Text = "";
            cbo_TenLoai.SelectedIndex = -1;
        }

        private void frmNguyenLieu_Load(object sender, EventArgs e)
        {
            cboLoc.SelectedIndex = 0;
            load_AllGrid();
            load_cbo_Loai();
            setHeaderNL();
            txt_MaNguyenLieu.Enabled = false;
            txt_TenNguyenLieu.Enabled = false;
            cbo_TenLoai.Enabled = false;
            txt_HSD.Enabled = false;
            txt_DonVi.Enabled = false;
            txt_SoLuong.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
        }
        Boolean kiemTraNull()
        {
            if (txt_MaNguyenLieu.Text != "")
            {
                if (txt_TenNguyenLieu.Text != "")
                {
                    if (txt_DonVi.Text != "")
                    {
                        if (txt_SoLuong.Text != "")
                        {
                                 if (cbo_TenLoai.Text != "")
                                {
                                    return true;
                                }
                                else
                                {
                                    MessageBox.Show("Không được để trống Loại nguyên liệu");
                                    return false;
                                }
   
                        }
                        else
                        {
                            MessageBox.Show("Không được để trống số lượng");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không được để trống đơn vị");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Không được để trống tên nguyên liệu");
                    return false;
                }

            }
            else
            {
                MessageBox.Show("Không được để trống mã nguyên liệu");
                return false;
            }
        }
        void load_AllGrid()
        {
            // load nguyên liệu
            dgrv_HienThiNguyenLieu.DataSource = nl.loadNguyenLieuFormKho();

        }
        // hàm load cbo MaLoai
        void load_cbo_Loai()
        {
            cbo_TenLoai.DataSource = nl.load_cboMaLoai();
            cbo_TenLoai.DisplayMember = "TENLNL";
            cbo_TenLoai.ValueMember = "MALNL";
        }

        private void dgrv_HienThiNguyenLieu_SelectionChanged(object sender, EventArgs e)
        {

            if (dgrv_HienThiNguyenLieu.SelectedCells.Count > 0)
            {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                int vitri = dgrv_HienThiNguyenLieu.SelectedCells[0].RowIndex;

                string MaNL = dgrv_HienThiNguyenLieu.Rows[vitri].Cells["MANL"].Value.ToString().Trim();
                string TenNL = dgrv_HienThiNguyenLieu.Rows[vitri].Cells["TENNL"].Value.ToString().Trim();
                string DonVi = dgrv_HienThiNguyenLieu.Rows[vitri].Cells["DVT"].Value.ToString().Trim();
                string SoLuong = dgrv_HienThiNguyenLieu.Rows[vitri].Cells["SOLUONG"].Value.ToString().Trim();
                string HSD = dgrv_HienThiNguyenLieu.Rows[vitri].Cells["HSD"].Value.ToString().Trim();
                string TenLoai = dgrv_HienThiNguyenLieu.Rows[vitri].Cells["TENLNL"].Value.ToString().Trim();

                txt_MaNguyenLieu.Text = MaNL;
                txt_TenNguyenLieu.Text = TenNL;
                txt_DonVi.Text = DonVi;
                txt_SoLuong.Text = SoLuong;
                txt_HSD.Value = Convert.ToDateTime(HSD);
                cbo_TenLoai.Text = TenLoai;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txt_MaNguyenLieu.Enabled = false;
            txt_TenNguyenLieu.Focus();
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            txt_TenNguyenLieu.Enabled = true;
            cbo_TenLoai.Enabled = true;
            txt_HSD.Enabled = true;
            txt_DonVi.Enabled = true;
            txt_SoLuong.Enabled = true;

            //if (btnLuu.Enabled == true)
            //{
            //    DialogResult result;

            //    result = MessageBox.Show("Bạn chưa lưu nguyên liệu " + txt_MaNguyenLieu.Text + ". Bạn có muốn lưu lại ?",
            //        "Thông báo", MessageBoxButtons.YesNo,
            //        MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            //    if (result == DialogResult.Yes)
            //    {
            //        btnLuu_Click(sender, e);
            //    }
            //    else
            //    {
            //        return;
            //    }
            //}
            //else
            //{
            //    btnLuu.Enabled = true;
            //}
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result;

                result = MessageBox.Show("Bạn chắc chắn xóa nguyên liệu " + txt_MaNguyenLieu.Text + " ?",
                    "Thông báo", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    nl.xoaNguyenLieu(txt_MaNguyenLieu.Text);
                    load_AllGrid();
                    frmNguyenLieu_Load(sender, e);
                }
                else
                {
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Nguyên liệu " + txt_MaNguyenLieu.Text + " không đạt điều kiện để xóa");
            }
            frmNguyenLieu_Load(sender, e);


        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (kiemTraNull() == true)
            {
                if (nl.kiemtrakhoachinh(txt_MaNguyenLieu.Text) == 1)
                {
                    nl.themNguyenLieu(txt_MaNguyenLieu.Text, txt_TenNguyenLieu.Text, txt_DonVi.Text, Convert.ToInt32(txt_SoLuong.Text), txt_HSD.Value, cbo_TenLoai.SelectedValue.ToString());
                    load_AllGrid();
                    textboxVeNull();
                    MessageBox.Show("Lưu thành công");
                }
                else
                {
                    nl.suaNguyenLieu(txt_MaNguyenLieu.Text.Trim(), txt_TenNguyenLieu.Text, txt_DonVi.Text, Convert.ToInt32(txt_SoLuong.Text), txt_HSD.Value, cbo_TenLoai.SelectedValue.ToString());
                    load_AllGrid();
                    textboxVeNull();
                    MessageBox.Show("Lưu thành công");
                }
            }
            frmNguyenLieu_Load(sender, e);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Length > 0)
            {
                dgrv_HienThiNguyenLieu.DataSource = nl.loadGridViewNguyenLieuTimKiem(txtTimKiem.Text);
            }
            else
            {
                dgrv_HienThiNguyenLieu.DataSource = nl.loadNguyenLieuFormKho();
            }
        }

        private void txt_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cboLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoc.SelectedIndex == 0)
            {
                dgrv_HienThiNguyenLieu.DataSource = nl.loadNguyenLieuFormKho();

            }
            else if (cboLoc.SelectedIndex == 1)
            {
                string now = DateTime.Now.ToShortDateString();
                dgrv_HienThiNguyenLieu.DataSource = nl.loadGridViewTheoHangHetDate(Convert.ToDateTime(now));
            }
            else
            {
                dgrv_HienThiNguyenLieu.DataSource = nl.loadGridViewTheoHangHetTrongKho();
            }
        }
        public void setHeaderNL()
        {
            dgrv_HienThiNguyenLieu.Columns["MANL"].HeaderText = "Mã nguyên liệu";
            dgrv_HienThiNguyenLieu.Columns["TENNL"].HeaderText = "Tên nguyên liệu";
            dgrv_HienThiNguyenLieu.Columns["DVT"].HeaderText = "Đơn vị tính";
            dgrv_HienThiNguyenLieu.Columns["HSD"].HeaderText = "Hạn sử dụng";
            dgrv_HienThiNguyenLieu.Columns["SOLUONG"].HeaderText = "Số lượng";
            dgrv_HienThiNguyenLieu.Columns["TENLNL"].HeaderText = "Tên loại";

        }
        //public void databingding(int rowindex)
        //{
        //    string manl = dgrv_HienThiNguyenLieu.Rows[rowindex].Cells["MANL"].FormattedValue.ToString();
        //    string tennl = dgrv_HienThiNguyenLieu.Rows[rowindex].Cells["TENNL"].FormattedValue.ToString();
        //    string dvt = dgrv_HienThiNguyenLieu.Rows[rowindex].Cells["DVT"].FormattedValue.ToString();
        //    string sl = dgrv_HienThiNguyenLieu.Rows[rowindex].Cells["SOLUONG"].FormattedValue.ToString();
        //    string hsd = dgrv_HienThiNguyenLieu.Rows[rowindex].Cells["HSD"].FormattedValue.ToString();
        //    txt_HSD.Value = Convert.ToDateTime(dgrv_HienThiNguyenLieu.Rows[rowindex].Cells["NGAYSINH"].FormattedValue.ToString());
        //    txt_MaNguyenLieu.Text = manl;
        //    txt_TenNguyenLieu.Text = tennl;
        //    txt_DonVi.Text = dvt;
        //    txt_SoLuong.Text = sl;            
        //    //cbo_TenLoai.Text = tenloai;
        //}
        private void btnRP_Click(object sender, EventArgs e)
        {
            frm_rpNguyenLieu rp = new frm_rpNguyenLieu();
            rp.Show();
        }

        private void dgrv_HienThiNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //btnSua.Enabled = true;
            //btnXoa.Enabled = true;
            //if (dgrv_HienThiNguyenLieu.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            //{
            //    dgrv_HienThiNguyenLieu.CurrentRow.Selected = true;
            //    databingding(e.RowIndex);
            //}
        }
    }
}
