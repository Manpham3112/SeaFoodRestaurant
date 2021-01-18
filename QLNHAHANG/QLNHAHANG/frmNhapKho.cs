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

    public partial class frmNhapKho : Form
    {
        qlPhieuNhapKho_BLL_DAL qlnk = new qlPhieuNhapKho_BLL_DAL();
        NguyenLieu_BLL_DAL nl = new NguyenLieu_BLL_DAL();
        qlCTPhieuNhapKho_BLL_DAL ctpnk = new qlCTPhieuNhapKho_BLL_DAL();
        NhanVien_BLL_DAL nVienBLL_DALL = new NhanVien_BLL_DAL();
        qlNhaCungCap_BLL_DAL nCC_BLL_DAL = new qlNhaCungCap_BLL_DAL();
        NHANVIEN nv;
        List<string> lstStringTextBox;
        List<Guna2TextBox> lstTextBox;
        string maPhieuDangChon;
        string tenNLDangChon;
        double tong;
        string maNLDangChon;
        internal void DangNhapNV(NHANVIEN nv)
        {
            this.nv = nv;
            BtnND.Text = nv.TENNV;
        }
        public frmNhapKho()
        {
            InitializeComponent();
        }
        public frmNhapKho(bool show)
        {
            InitializeComponent();
        }
        public void loadCBLoai()
        {
            cboNCC.DataSource = qlnk.loadAllNCC();
            cboNCC.ValueMember = "MANCC";
            cboNCC.DisplayMember = "TENNCC";
        }
        public void databingding(int rowindex)
        {
            string mapnk = dataGridViewPhieuNhanHang.Rows[rowindex].Cells["MAPNK"].FormattedValue.ToString();
            string manv = dataGridViewPhieuNhanHang.Rows[rowindex].Cells["MANV"].FormattedValue.ToString();
            cboNCC.SelectedValue = dataGridViewPhieuNhanHang.Rows[rowindex].Cells["MANCC"].FormattedValue.ToString();
            string ngaylap = dataGridViewPhieuNhanHang.Rows[rowindex].Cells["NGAYLAP"].FormattedValue.ToString();
            string tongtien = dataGridViewPhieuNhanHang.Rows[rowindex].Cells["TONGTIEN"].FormattedValue.ToString();
            txtMaPNK.Text = mapnk;
            txtMaNV.Text = manv;
            //txtMaNCC.Text = mancc;
            txt_NgayNhan.Text = ngaylap;
            txtTongTien.Text = tongtien;
        }
        public void databingding1(int rowindex)
        {
            string mapnk = dataGridViewChiTiet.Rows[rowindex].Cells["MAPNK12"].FormattedValue.ToString();
            string manl = dataGridViewChiTiet.Rows[rowindex].Cells["MANL"].FormattedValue.ToString();
            string soluong = dataGridViewChiTiet.Rows[rowindex].Cells["SOLUONG"].FormattedValue.ToString();
            string gianhap = dataGridViewChiTiet.Rows[rowindex].Cells["GIANHAP"].FormattedValue.ToString();
            txtMaPNK.Text = mapnk;
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
            lstStringTextBox.Add(txtMaPNK.Text);
            lstStringTextBox.Add(txtMaNV.Text);
            //lstStringTextBox.Add(txtMaNCC.Text);
            lstStringTextBox.Add(txt_NgayNhan.Text);
            lstStringTextBox.Add(txtTongTien.Text);
            lstStringTextBox.Add(txt_SoLuongNhap.Text);
            lstStringTextBox.Add(txt_DonGiaNhap.Text);

            return lstStringTextBox;
        }
        public List<Guna2TextBox> addListTextBox()
        {
            lstTextBox = new List<Guna2TextBox>();
            lstTextBox.Add(txtMaPNK);
            lstTextBox.Add(txtMaNV);
            //lstTextBox.Add(txtMaNCC);
            lstTextBox.Add(txtTongTien);
            lstTextBox.Add(txt_SoLuongNhap);
            lstTextBox.Add(txt_DonGiaNhap);
            return lstTextBox;
        }
        public void setEnableTextBox(List<Guna2TextBox> lst, bool b)
        {
            foreach (Guna2TextBox s in lst)
                s.Enabled = b;
        }
        private void frmNhapKho_Load(object sender, EventArgs e)
        {
            dataGridViewPhieuNhanHang.DataSource = qlnk.loadDataGridViewPhieuNhapKho();
            //dataGridViewNguyenLieu.DataSource = nl.loadNguyenLieu();
            //dataGridViewChiTiet.DataSource = ctpnk.loadDataGridViewCTPhieuNhapKho();
            btnThemNL.Enabled = false;
            btnThemPNK.Enabled = true;
            btnLuuPNK.Enabled = false;
            //btnXoaCTPNK.Enabled = false;
            lstTextBox = addListTextBox();
            setEnableTextBox(lstTextBox, false);
            databingding(0);
            databingding1(0);
            loadCBLoai();
        }

        private void btnThemPNK_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int count = qlnk.demSoLuong() + 1;
            txtMaPNK.Text = "PNK0" + count + r.Next(0, 99);
            txtMaPNK.ReadOnly = true;
            txtMaNV.ReadOnly = true ;
            txtMaNV.Text = nv.MANV;
            txtTongTien.Text = "0";
            setEnableTextBox(lstTextBox, true);
            txtTongTien.ReadOnly = true;
            if (btnLuuPNK.Enabled == true)
            {
                DialogResult result;
                result = MessageBox.Show("Bạn chưa lưu phiếu nhập kho " + txtMaPNK.Text + ". Bạn có muốn lưu lại ?",
                    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                    btnLuuPNK_Click(sender, e);
                else
                    return;
            }
            else
                btnLuuPNK.Enabled = true;
        }

        private void btnLuuPNK_Click(object sender, EventArgs e)
        {
                if (qlnk.kT(txtMaPNK.Text) == true)
                {
                    qlnk.themPhieuNhapKho(txtMaPNK.Text,nv.MANV, cboNCC.SelectedValue.ToString(), txt_NgayNhan.Value, Convert.ToInt32(txtTongTien.Text));
                    MessageBox.Show("Thêm thành công");
                frmNhapKho_Load(sender, e);
            }
                else
                {
                    MessageBox.Show("Lỗi hệ thống");
                }
            
        }

        private void dataGridViewPhieuNhanHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPhieuNhanHang.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridViewPhieuNhanHang.CurrentRow.Selected = true;
                databingding(e.RowIndex);
            }
        }

        private void dataGridViewChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewChiTiet.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridViewChiTiet.CurrentRow.Selected = true;
                databingding1(e.RowIndex);
                //btnXoaCTPNK.Enabled = true;
            }
        }

        private void dataGridViewNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dataGridViewNguyenLieu.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            //{
            //    dataGridViewNguyenLieu.CurrentRow.Selected = true;
            //    databingding2(e.RowIndex);
            //    btnThemNL.Enabled = true;
            //    txt_SoLuongNhap.Enabled = true;
            //    txt_DonGiaNhap.Enabled = true;
            //}
        }
        void load_DataGridView()
        {
            // dgv Nguyen Lieu
            dataGridViewNguyenLieu.DataSource = nl.loadNguyenLieu();

            // load dgv phiếu nhận
            //dataGridViewPhieuNhanHang.DataSource = qlnk.loadDataGridViewPhieuNhapKho();

            // load dgv chi tiết
            dataGridViewChiTiet.DataSource = ctpnk.chiTietPhieuNhap(maPhieuDangChon);

        }
        

        private void btnThemNL_Click(object sender, EventArgs e)
        {
            if (ctpnk.ktTrung(maNLDangChon, maPhieuDangChon) == true)
            {
                if (kiemTraNhapChiTiet() == true)
                {
                    ctpnk.themCTPhieuNhapKho(maPhieuDangChon, maNLDangChon, Convert.ToInt32(txt_SoLuongNhap.Text), Convert.ToInt32(txt_DonGiaNhap.Text));
                    dataGridViewChiTiet.DataSource = ctpnk.chiTietPhieuNhap(maPhieuDangChon);
                    tinhTong();
                    //qlnk.capNhatTong(maPhieuDangChon, (int)tong);
                    MessageBox.Show("Thêm thành công");
                    load_DataGridView();
                }
            }
            else
                MessageBox.Show("Nguyên liệu này đã đặt, bạn cần chọn nguyên liệu khác");
        }
        void tinhTong()
        {
            tong = 0;
            for (int i = 0; i <= dataGridViewChiTiet.Rows.Count - 1; i++)
            {
                tong = Convert.ToDouble(dataGridViewChiTiet.Rows[i].Cells["SOLUONG"].Value.ToString().Trim()) * Convert.ToDouble(dataGridViewChiTiet.Rows[i].Cells["GIANHAP"].Value.ToString().Trim()) + tong;
            }
            txtTongTien.Text = tong.ToString();
        }

        // Kiểm tra các textbox vs combobox
        private bool kiemTraNhapChiTiet()
        {
            if (txt_SoLuongNhap.Text != "")
            {
                if (txt_DonGiaNhap.Text != "")
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Không được để trống đơn giá");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Không được để trống số lượng");
                return false;
            }
        }
        private void btnXoaCTPNK_Click(object sender, EventArgs e)
        {
            ctpnk.xoaCTPhieuNhapKho(maPhieuDangChon, maNLDangChon);
            dataGridViewChiTiet.DataSource = ctpnk.chiTietPhieuNhap(maPhieuDangChon);
            tinhTong();
            // qlnk.capNhatTong(maPhieuDangChon, (int)tong);
            MessageBox.Show("Xóa thành công");
            frmNhapKho_Load(sender, e);
        }

        private void RP_PNK_Click(object sender, EventArgs e)
        {
           // RP_PNK pnk = new RP_PNK();
            this.Hide();
            //pnk.Show();
        }

        private void dataGridViewPhieuNhanHang_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPhieuNhanHang.SelectedCells.Count > 0)
            {
                int vt = dataGridViewPhieuNhanHang.SelectedCells[0].RowIndex;
                maPhieuDangChon = dataGridViewPhieuNhanHang.Rows[vt].Cells["MAPNK"].Value.ToString().Trim();
                txtMaPNK.Text = maPhieuDangChon;
                //txt_NgayNhan.Value = Convert.ToDateTime(dataGridViewPhieuNhanHang.Rows[vt].Cells["NGAYNHAP"].Value.ToString().Trim());
                txtTongTien.Text = dataGridViewPhieuNhanHang.Rows[vt].Cells["TONGTIEN"].Value.ToString().Trim();
                dataGridViewChiTiet.DataSource = ctpnk.chiTietPhieuNhap(txtMaPNK.Text);
            }
        }

        private void btnNhapChiTietPhieu_Click(object sender, EventArgs e)
        {
            dataGridViewNguyenLieu.DataSource = nl.loadNguyenLieu();
            btnThemNL.Enabled = true;
        }

        private void dataGridViewChiTiet_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewChiTiet.SelectedCells.Count > 0)
            {
                int vt = dataGridViewChiTiet.SelectedCells[0].RowIndex;
                //maPhieuDangChon = dataGridViewChiTiet.Rows[vt].Cells["MAPNK"].Value.ToString().Trim();
                maNLDangChon = dataGridViewChiTiet.Rows[vt].Cells["MANL"].Value.ToString().Trim();
                txt_SoLuongNhap.Text = dataGridViewChiTiet.Rows[vt].Cells["SOLUONG"].Value.ToString().Trim();
                txt_DonGiaNhap.Text = dataGridViewChiTiet.Rows[vt].Cells["GIANHAP"].Value.ToString().Trim();
            }
        }

        private void dataGridViewNguyenLieu_SelectionChanged(object sender, EventArgs e)
        {
            txt_DonGiaNhap.Enabled = true;
            txt_SoLuongNhap.Enabled = true;
            txt_DonViTinh.Enabled = false;
            if (dataGridViewNguyenLieu.SelectedCells.Count > 0)
            {
                txt_SoLuongNhap.Text = "";
                txt_DonGiaNhap.Text = "";
                int vitri = dataGridViewNguyenLieu.SelectedCells[0].RowIndex;
                maNLDangChon = dataGridViewNguyenLieu.Rows[vitri].Cells["MANL1"].Value.ToString().Trim();
                tenNLDangChon = dataGridViewNguyenLieu.Rows[vitri].Cells[1].Value.ToString().Trim();
                txt_DonViTinh.Text = dataGridViewNguyenLieu.Rows[vitri].Cells["DVT"].Value.ToString().Trim();
            }
        }
        //private void xoaToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    // xóa chi tiết phiếu nhập kho
        //    ctpnk.xoaCTPhieuNhapKho(txtMaPNK.Text, txtMaNL.Text);
        //    qlnk.xoaPhieuNhapKho(txtMaPNK.Text);
        //    frmNhapKho_Load(sender, e);
        //    MessageBox.Show("xóa thành công");
        //    // xóa phiếu nhập kho
        //}
    }
}
