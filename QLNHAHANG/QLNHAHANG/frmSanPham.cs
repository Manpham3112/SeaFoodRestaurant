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
using System.IO;
namespace QLNHAHANG
{
    public partial class frmSanPham : Form
    {
        SanPham_BLL_DAL sp_bll = new SanPham_BLL_DAL();
        List<NGUYENLIEU> lstNL = new List<NGUYENLIEU>();
     
        List<NGUYENLIEU> lstNLHienTai;
        bool checkThem = false;
        bool checkSua = false;
        bool checkXoa = false;
        public frmSanPham()
        {
            InitializeComponent();
            loadCBLoai();
            lstNL = sp_bll.LayTatCaNguyenLieu();
            thietlapcontrol();


            gvNguyenLieu.MultiSelect = false;
            gvNguyenLieu.MultiSelect = false;
            gvSanPham.MultiSelect = false;


        }
        public void thietlapcontrol()
        {
            //foreach (Control item in pnControlSP.Controls)
            //{
            //    if (item.Name == groupMaLoai.Name)
            //        continue;
            //    item.Enabled = false;
            //}

            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnThemNL.Enabled = false;
            btnXoaNL.Enabled = false;
            btnThem.Enabled = true;
            gvSanPham.Enabled = true;
            btnSua.Enabled = true;

        }
        public void loadCBLoai()
        {
            cbMaLoai.DataSource = sp_bll.loadAllLoai();
            cbMaLoai.ValueMember = "MALSP";
            cbMaLoai.DisplayMember = "TENLSP";
        }
        public void loadGridViewSP(List<SANPHAM> sp)
        {
            gvSanPham.DataSource = sp;
            //gvSPDataBinding();

        }
        public void loadTatCaSP(string maloai)
        {
            List<SANPHAM> lstSP = sp_bll.getALLSanPhamByLoai(maloai).ToList();

           loadGridViewSP(lstSP);


        }
        //List nguyên liệu có trong sanpham
        public List<NGUYENLIEU> lstNLCuaSP()
        {
            List<NGUYENLIEU> lst = new List<NGUYENLIEU>();
            gvNL_SP.AllowUserToAddRows = false;
            if (gvNL_SP.Rows.Count == 0)
            {
                gvNL_SP.AllowUserToAddRows = true;
                return lst;
            }
            foreach (DataGridViewRow item in gvNL_SP.Rows)
            {
                NGUYENLIEU nl = lstNL.Single(t => t.MANL == item.Cells["MANL"].Value.ToString());
                lst.Add(nl);
            }
            return lst;
        }
        // List Nhung nguyen lieu trong thuoc san pham do
        public List<NGUYENLIEU> lstNL_KoThuocSP()
        {
            List<NGUYENLIEU> lstcuasp = lstNLCuaSP();
            List<NGUYENLIEU> lstkocuasp = new List<NGUYENLIEU>();

            foreach (NGUYENLIEU item in lstNL)
            {
                if (!lstcuasp.Contains(item))
                {
                    lstkocuasp.Add(item);
                }
            }
            return lstkocuasp;
        }
        public void LoadGVSP_NL(string maSP)
        {
            gvNL_SP.DataSource = sp_bll.laySP_NL(maSP);
            gvNguyenLieu.DataSource = lstNL_KoThuocSP();
        }
        private void gvSanPham_SelectionChanged(object sender, EventArgs e)
        {
            
            btnXoa.Enabled = true;
            try
            {
                string hinh = gvSanPham.CurrentRow.Cells["HINHANH"].Value.ToString();
                //pcSp.Image = Image.FromFile("../../img/img_sanpham/" + hinh);
                pcSp.LoadAsync(hinh);
                //pcSp.Image.Save("../../img/img_sanpham/" + hinh, System.Drawing.Imaging.ImageFormat.Jpeg);
                string masp = gvSanPham.CurrentRow.Cells[0].Value.ToString();

                LoadGVSP_NL(masp);

            }
            catch (Exception)
            {
                pcSp.Image = null;
                return;
                throw;
            }



        }

        private void frmSanPham_Resize(object sender, EventArgs e)
        {
            btnspace.Width = gvSanPham.Width;
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            gvSanPham.DataSource = sp_bll.getALLSPGV();
            cbMaLoai.DataSource = sp_bll.loadAllLoai();
            bindingSP(0);
            setHeaderSP();
            setHeaderNL_SP();
            setHeaderNL();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLamMoi.Enabled = true;
            btnChonHinh.Enabled = false;
            txtMa.Enabled = false;
            txtTen.Enabled = false;
            cbMaLoai.Enabled = false;
            cbTinhTrang.Enabled = false;
            txtGia.Enabled = false;

        }

        private void cbMaLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void gvNL_SP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private bool kiemtraControl()
        {
            if (txtGia.Text == string.Empty || txtMa.Text == string.Empty || txtGia.Text == string.Empty)
            {
                return false;
            }
            return true;
        }
        public void bindingSP(int rowindex)
        {
            txtMa.Text = gvSanPham.Rows[rowindex].Cells[0].FormattedValue.ToString();
            txtTen.Text = gvSanPham.Rows[rowindex].Cells[1].FormattedValue.ToString();
            txtGia.Text = gvSanPham.Rows[rowindex].Cells[3].FormattedValue.ToString();
            var a = gvSanPham.Rows[rowindex].Cells["MALSP"].FormattedValue.ToString();
            cbMaLoai.SelectedValue = gvSanPham.Rows[rowindex].Cells["MALSP"].FormattedValue.ToString();
            cbTinhTrang.SelectedIndex = gvSanPham.Rows[rowindex].Cells["TRANGTHAI"].FormattedValue.ToString() == "Bán" ? 0 : 1;
            //string pathImage = Application.StartupPath + "\\img\\img_sanpham\\"+ gvSanPham.CurrentRow.Cells["HINHANH"].Value.ToString()+".jpg";
            //pcSp.Image = new Bitmap(pathImage);
            //gvNL_SP.DataSource = sp_bll.laySP_NL(txtMa.Text);
            LoadGVSP_NL(txtMa.Text);

            foreach (DataGridViewRow item in gvSanPham.SelectedRows)
            {

                try
                {
                    pcSp.Image = Image.FromFile("../../img/img_sanpham/" + gvSanPham.CurrentRow.Cells["HINHANH"].Value.ToString());
                    pcSp.Tag = "../../img/img_sanpham/" + gvSanPham.CurrentRow.Cells["HINHANH"].Value.ToString();
                }
                catch (Exception)
                {
                    return;
                    throw;
                }
            }
        }

        private void gvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            try
            {
                if (gvSanPham.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    gvSanPham.CurrentRow.Selected = true;
                    bindingSP(e.RowIndex);
                }

            }
            catch
            {
                
                return;
            }
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMa.Enabled = false;
            cbMaLoai.Enabled = true;
            cbTinhTrang.SelectedValue = "Bán";
            txtGia.Enabled = true;
            btnChonHinh.Enabled = true;
            txtTen.Enabled = true;
            cbTinhTrang.Enabled = true;
            checkThem = true;
            checkSua = false;
            checkXoa = false;

            foreach (Control item in pnControlSP.Controls)
            {
                // khong cho nha maSP
                if (item.Name == "gbMSP")
                {
                    continue;
                }
                else
                    item.Enabled = true;
            }
            resetControlKhiThem();
        }
        private string taoMaSPMoi()
        {
            return "SP00" + gvSanPham.Rows.Count.ToString();
        }
        private List<CT_SANPHAM_NGUYENLIEU> loadNL_SP()
        {
            List<CT_SANPHAM_NGUYENLIEU> lst_nlsp = new List<CT_SANPHAM_NGUYENLIEU>();
            foreach (NGUYENLIEU item in lstNLHienTai)
            {
                CT_SANPHAM_NGUYENLIEU nlsp = new CT_SANPHAM_NGUYENLIEU();
                nlsp.MANL = item.MANL;
                nlsp.MASP = txtMa.Text;
                nlsp.SOLUONG = 1;
                lst_nlsp.Add(nlsp);
            }
            return lst_nlsp;
        }
        private void resetControlKhiThem()
        {
            txtMa.Text = taoMaSPMoi();
            txtGia.Text = "";
            txtTen.Text = "";

            btnThemNL.Enabled = true;
            btnXoaNL.Enabled = true;
            btnLuu.Enabled = true;
            gvSanPham.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            lstNLHienTai = new List<NGUYENLIEU>();
            gvNL_SP.DataSource = loadNL_SP();
            gvNguyenLieu.DataSource = lstNL;
            pcSp.Image = null;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            checkXoa = true;
            checkThem = false;
            checkSua = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            if (gvSanPham.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chưa chọn sản phẩm để sửa");
                return;
            }
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm (" + txtTen.Text + ")", "Xác nhận", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                bool check = sp_bll.xoaSP(txtMa.Text);
                if (check)
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
                gvSanPham.DataSource = sp_bll.getALLSP();
                thietlapcontrol();
            }
            frmSanPham_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtTen.Enabled = true;
            cbTinhTrang.Enabled = true;
            txtGia.Enabled = true;
            cbMaLoai.Enabled = true;
            btnChonHinh.Enabled = true;
            if (gvSanPham.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chưa chọn sản phẩm để sửa");
                return;
            }
            gvSanPham.Enabled = false;
            checkSua = true;
            checkThem = false;
            checkXoa = true;

            foreach (Control item in pnControlSP.Controls)
            {
                // khong cho nha maSP
                if (item.Name == "gbMSP")
                {
                    continue;
                }
                else
                    item.Enabled = true;
            }
            lstNLHienTai = lstNLCuaSP();
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnThemNL.Enabled = true;
            btnXoaNL.Enabled = true;
            btnLuu.Enabled = true;

        }

        private void btnThemNL_Click(object sender, EventArgs e)
        {
            if (gvNguyenLieu.SelectedRows == null)
            {
                MessageBox.Show("Chưa chọn nguyện liệu");
            }
            foreach (DataGridViewRow item in gvNguyenLieu.SelectedRows)
            {
                NGUYENLIEU nl = lstNL.Single(t => t.MANL == item.Cells["MANL"].Value.ToString());
                lstNLHienTai.Add(nl);

                gvNL_SP.DataSource = loadNL_SP();
                gvNguyenLieu.DataSource = lstNL_KoThuocSP();
            }
        }

        private void btnXoaNL_Click(object sender, EventArgs e)
        {
            lstNLHienTai.Remove(lstNLHienTai.SingleOrDefault(t => t.MANL == gvNL_SP.CurrentRow.Cells["MANL"].Value.ToString()));
            gvNL_SP.DataSource = loadNL_SP();
            gvNguyenLieu.DataSource = lstNL_KoThuocSP();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (kiemtraControl() == false)
            {
                MessageBox.Show("Nhập chưa đầy đủ");
                return;
            }

            SANPHAM sp = new SANPHAM();
            sp.MASP = txtMa.Text;
            sp.TENSP = txtTen.Text;
            sp.TRANGTHAI = cbTinhTrang.Text;
            sp.MALSP = cbMaLoai.SelectedValue.ToString();
            sp.GIABAN = Convert.ToInt64(txtGia.Text);

            try
            {
                sp.HINHANH = pcSp.Tag.ToString();
            }
            catch (Exception)
            {
                sp.HINHANH = "no-image.jpg";
            }

            List<CT_SANPHAM_NGUYENLIEU> lstNLSP = loadNL_SP();

            if (checkThem == true)
            {
                bool check = sp_bll.themSanPham(sp, lstNLSP);

                if (check)
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
                gvSanPham.Enabled = true;
                checkThem = false;
            }
            else if (checkSua == true)
            {
                bool check = sp_bll.suaSanPham(sp, lstNLSP);
                if (check)
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
                gvSanPham.Enabled = true;
                checkSua = false;
            }
            else
            {
                checkXoa = false;
            }
            sp_bll.submitChange();
            btnLuu.Enabled = false;
            thietlapcontrol();
            frmSanPham_Load(sender, e);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            thietlapcontrol();
            frmSanPham_Load(sender, e);
        }
        public void setHeaderSP()
        {
            //gvSanPham.Columns["MASP"].HeaderText = "Mã sản phẩm";
            //gvSanPham.Columns["TENSP"].HeaderText = "Tên sản phẩm";
            //gvSanPham.Columns["GIABAN"].HeaderText = "Giá";
            //gvSanPham.Columns["TRANGTHAI"].HeaderText = "Tình trạng";
            gvSanPham.Columns["MALSP"].HeaderText = "Loại";
            gvSanPham.Columns["MALSP"].Visible = true;
            gvSanPham.Columns["TENLSP"].Visible = false;
            gvSanPham.Columns["LOAISP"].Visible = false;
            gvSanPham.Columns["HINHANH"].Visible = false;
        }
        public void setHeaderNL_SP()
        {
            //    gvNL_SP.Columns["MASP"].HeaderText = "Mã sản phẩm";
            //    gvNL_SP.Columns["MALSP"].Visible = true;
            //    gvSanPham.Columns["TENLSP"].Visible = false;
            gvNL_SP.Columns["NGUYENLIEU"].Visible = false;
            gvNL_SP.Columns["SANPHAM"].Visible = false;

        }
        public void setHeaderNL()
        {
            gvNguyenLieu.Columns["MANL"].HeaderText = "Mã nguyên liệu";
            gvNguyenLieu.Columns["TENNL"].HeaderText = "Tên nguyên liệu";
            //gvNguyenLieu.Columns["SOLUONG"].HeaderText = "Số lượng";
            gvNguyenLieu.Columns["MALNL"].Visible = false;
            gvNguyenLieu.Columns["LOAINL"].Visible = false;
            gvNguyenLieu.Columns["HSD"].Visible = false;

        }

        private void gvSanPham_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string RowNumber = (e.RowIndex + 1).ToString();
            SizeF size = e.Graphics.MeasureString(RowNumber, this.Font);
            if (gvSanPham.RowHeadersWidth < (int)(size.Width + 20))
                gvSanPham.RowHeadersWidth = (int)(size.Width + 20);
            Brush b = SystemBrushes.ControlText;
            e.Graphics.DrawString(RowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text.Length == 0)
            {
                gvSanPham.DataSource = sp_bll.getALLSPGV();
            }
            else
            {
                gvSanPham.DataSource = sp_bll.loadGridViewTimKiemSanPham(guna2TextBox1.Text);
            }
        }

        private void txtTimNL_TextChanged(object sender, EventArgs e)
        {
            if (txtTimNL.Text.Length == 0)
            {
                gvNguyenLieu.DataSource = lstNL_KoThuocSP();
            }
            else
            {
                gvNguyenLieu.DataSource = sp_bll.loadGridViewTimKiemNguyenLieu(txtTimNL.Text);
            }
        }

        private void gvNL_SP_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string RowNumber = (e.RowIndex + 1).ToString();
            SizeF size = e.Graphics.MeasureString(RowNumber, this.Font);
            if (gvSanPham.RowHeadersWidth < (int)(size.Width + 20))
                gvSanPham.RowHeadersWidth = (int)(size.Width + 20);
            Brush b = SystemBrushes.ControlText;
            e.Graphics.DrawString(RowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
        }

        private void gvNguyenLieu_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string RowNumber = (e.RowIndex + 1).ToString();
            SizeF size = e.Graphics.MeasureString(RowNumber, this.Font);
            if (gvSanPham.RowHeadersWidth < (int)(size.Width + 20))
                gvSanPham.RowHeadersWidth = (int)(size.Width + 20);
            Brush b = SystemBrushes.ControlText;
            e.Graphics.DrawString(RowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            pickAsync();
        }

        private async void pickAsync()
        {
            string path = String.Empty;
            string imageURL = String.Empty;
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                path = open.FileName;
                // display image in picture box  
                pcSp.Image = new Bitmap(open.FileName);
                // image file path  

                if (!string.IsNullOrEmpty(path))
                {
                    imageURL = await Utils.addProductImage(path);
                    pcSp.Load(imageURL);
                    pcSp.Tag = imageURL;

                }
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frm_rpSanPham rp = new frm_rpSanPham();
            rp.Show();
        }
    }
}
