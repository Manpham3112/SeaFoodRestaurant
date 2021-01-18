using Guna.UI.WinForms;
using System;
using System.Windows.Forms;
using BLL_DAL;
using System.Collections.Generic;
using System.Drawing;
using clb_QLNHAHANG;
using System.Globalization;
using System.Threading;

namespace QLNHAHANG
{
    public partial class frmOrder : Form
    {
        SanPham_BLL_DAL sp_bll = new SanPham_BLL_DAL();
        List<CT_HOADON> lstChiTiet;
        List<HOADON> lstHoaDon;
        HoaDon_BLL_DAL hd_bll = new HoaDon_BLL_DAL();
        qlKhuyenMai_BLL_DAL kmai = new qlKhuyenMai_BLL_DAL();
        qlDichVu_BLL_DAL dv_bll = new qlDichVu_BLL_DAL();
        NHANVIEN nv;
        string maHD;
        bool checkfrmHD = false;
        int tongtienHd;
        public frmOrder()
        {
            InitializeComponent();
        }
        public frmOrder(bool show)
        {
            InitializeComponent();
            btnBackToManager.Visible = show;
        }
        internal void DangNhapNV(NHANVIEN nv)
        {
            this.nv = nv;
            BtnND.Text = nv.TENNV;
        }
        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            List<SANPHAM> lst = sp_bll.getALLSP();
            hienthiSanPham(lst);
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {

            Guna.UI.Lib.ScrollBar.PanelScrollHelper flowpanel =
                new Guna.UI.Lib.ScrollBar.PanelScrollHelper(pnHienThiSanPham, gunaVScrollBar1, true);

            hienthiSanPham(sp_bll.getALLSP());
            resetPNThanhToan();

            //loadLoaiNguyenLieu();
            btnThanhToan.Enabled = false;
            tongtienHd = 0;

            //cboKhuyenMai.SelectedIndex = 0;
            //cboKhuyenMai.SelectedIndex = -1;
            load_cbo_KhuyenMai();
        }
        private void hienthiSanPham(List<SANPHAM> lstSP)
        {
            pnHienThiSanPham.Controls.Clear();
            foreach (SANPHAM item in lstSP)
            {
                string path = string.Empty;
                usSanPham itemsp = new usSanPham();

                //itemsp.btnchon.Visible = false;
                itemsp.pnLine.Visible = false;

                if (string.IsNullOrEmpty(item.HINHANH))
                {
                    path = "../../img/img_sanpham/" + "no-image.jpg";
                }
                else
                {
                    path = item.HINHANH;
                }

                itemsp.setValueSP((int)item.GIABAN, path, item.TENSP);
                itemsp.setEventForALL();
                itemsp.pictureBox1.Tag = item.MASP + "," + (int)item.GIABAN;
                itemsp.pictureBox1.Click += itemsp_picturebox;
                pnHienThiSanPham.Controls.Add(itemsp);
            }

        }

        private void hienthiDV(List<DICHVU> lstDV)
        {
            pnHienThiSanPham.Controls.Clear();
            foreach (DICHVU item in lstDV)
            {
                string path = string.Empty;
                usSanPham itemsp = new usSanPham();

                //itemsp.btnchon.Visible = false;
                itemsp.pnLine.Visible = false;

                if (string.IsNullOrEmpty(item.ANH))
                {
                    path = "../../img/img_sanpham/" + "no-image.jpg";
                }
                else
                {
                    path = "../../img/img_sanpham/" + item.ANH;
                }

                itemsp.setValueDV((int)item.GIADV, path, item.TENDV);
                itemsp.setEventForALL();
                itemsp.pictureBox1.Tag = item.MADV + "," + (int)item.GIADV;
                itemsp.pictureBox1.Click += itemdv_picturebox;
                pnHienThiSanPham.Controls.Add(itemsp);
            }

        }
        void itemsp_picturebox(object sender, EventArgs e)
        {
            PictureBox pc = (PictureBox)sender;
            if (lstChiTiet == null)
            {
                MessageBox.Show("Chưa tạo hóa đơn");
                return;
            }
            string[] mavagia = pc.Tag.ToString().Split(',');

            CT_HOADON cthd = new CT_HOADON();
            cthd.MAHD = " ";

            cthd.MASP = mavagia[0];
            cthd.SOLUONG = 1;
            cthd.THANHTIEN = Convert.ToInt32(mavagia[1]);

            if (!checkHD(mavagia[0]))
            {
                MessageBox.Show("Đã chọn sản phẩm này !");
                return;
            }

            lstChiTiet.Add(cthd);

            usChiTietHD usChiTiet = new usChiTietHD();
            usChiTiet.setValue(mavagia[0]);
            usChiTiet.Tag = mavagia[0];
            usChiTiet.btnTangGiam.Tag = mavagia[0];
            usChiTiet.btnHuy.Tag = mavagia[0];

            pnChiTietHD.Controls.Add(usChiTiet);
            usChiTiet.btnTangGiam.Click += BtnTangGiam_Click; ;
            usChiTiet.btnHuy.Click += BtnHuy_Click; ;
            capnhapTongTien();
        }
        void itemdv_picturebox(object sender, EventArgs e)
        {
            PictureBox pc = (PictureBox)sender;
            if (lstChiTiet == null)
            {
                MessageBox.Show("Chưa tạo hóa đơn");
                return;
            }
            string[] mavagia = pc.Tag.ToString().Split(',');

            lbGiaDV.Text = mavagia[1];
            lbTenDV.Text = mavagia[0];
            capnhapTongTien();
        }
        void load_cbo_KhuyenMai()
        {
            cboKhuyenMai.DataSource = kmai.loadKhuyenMai();
            cboKhuyenMai.DisplayMember = "TENKM";
            cboKhuyenMai.ValueMember = "MAKM";
            
        }
     
        private void capnhapTongTien()
        {
            double dv = double.Parse(lbGiaDV.Text);
            double pt = double.Parse(lbPhanTramGiam.Text);
            if (lstChiTiet.Count == 0 || lstChiTiet == null)
            {
                return;
            }
            int tong = 0;
            foreach (usChiTietHD item in pnChiTietHD.Controls)
            {
                tong += item.TongTien;
            }
            double stg = tong * (pt/100);
            lbTongTien.Text = tong + " ";
            lbSoTienGiam.Text = stg + " ";
            lbThanhTien.Text = (tong-stg) + dv +" " ;

        }
        private bool checkHD(string maSP)
        {
            if (lstChiTiet.Count == 0)
            {
                return true;
            }
            foreach (Control control in pnChiTietHD.Controls)
            {

                if (control.Tag.ToString() == maSP)
                {
                    return false;
                }
            }
            return true;
        }
        private void BtnTangGiam_Click(object sender, EventArgs e)
        {
            GunaNumeric nb = (GunaNumeric)sender;
            if (nb.Value > 30)
            {
                MessageBox.Show("Một sản phẩm được mua nhiều nhất là 30");
                nb.Value = 30;
                return;
            }
            foreach (Control item in pnChiTietHD.Controls)
            {
                if (item.Tag != null && item.Tag.ToString() == nb.Tag.ToString())
                {
                    usChiTietHD usChiTiet = (usChiTietHD)item;
                    usChiTiet.capnhapTongTien((int)nb.Value);
                    // Cap nhap so luong don hang                    
                    capnhapSLCT(nb.Tag.ToString(), (int)nb.Value);
                }
                else
                {
                    continue;
                }
            }
            capnhapTongTien();
        }

        // cap nhap so luong cho chi tiet
        private void capnhapSLCT(string p1, int p2)
        {
            foreach (CT_HOADON item in lstChiTiet)
            {
                if (item.MASP == p1)
                {
                    item.SOLUONG = p2;
                    break;
                }
            }
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            GunaAdvenceTileButton nb = (GunaAdvenceTileButton)sender;
            for (int i = 0; i < pnChiTietHD.Controls.Count; i++)
            {
                if (pnChiTietHD.Controls[i].Tag != null && pnChiTietHD.Controls[i].Tag.ToString() == nb.Tag.ToString())
                {
                    pnChiTietHD.Controls.Remove(pnChiTietHD.Controls[i]);
                    lstChiTiet.RemoveAt(i);
                    capnhapTongTien();
                }
                else
                {
                    continue;
                }
            }

        }
        public void resetPNThanhToan()
        {
            lbTongTien.Text = "0";
            lbThanhTien.Text = "0";
            lbSoTienGiam.Text = "0";
            lbPhanTramGiam.Text = "0";


        }

        private void btnBackToManager_Click(object sender, EventArgs e)
        {
            TrangChu frm = new TrangChu();
            frm.DangNhapNV(nv);
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            this.Close();
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            cboKhuyenMai.Enabled = true;
            if (btnThanhToan.Enabled == false)
            {
                btnThanhToan.Enabled = true;
                btnThemHD.FillColor = Color.Yellow;
                btnThemHD.FillColor2 = Color.Red;
                resetPNThanhToan();
                btnThemHD.Text = "+";

                lstChiTiet = new List<CT_HOADON>();


            }
            else
            {
                btnThanhToan.Enabled = false;
                btnThemHD.FillColor = Color.Violet;
                btnThemHD.FillColor2 = Color.DarkOrange;
                resetPNThanhToan();
                pnChiTietHD.Controls.Clear();
                lstChiTiet = null;
                btnThemHD.Text = "-";
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (lstChiTiet == null || lstChiTiet.Count == 0)
            {
                MessageBox.Show("Chưa có sản phẩm nào");
                return;
            }
                //DialogResult rs = MessageBox.Show("Lưu ý", "Xác nhận thanh toán", MessageBoxButtons.YesNo);
                //if (rs == DialogResult.No)
                //{
                //    return;
                //}

                int tongtien = Convert.ToInt32(lbThanhTien.Text);
                //double TongTien = ckDiem.Checked ? tongtien : tongtien;

                maHD = hd_bll.taoMaHD();

                bool check = hd_bll.themHoaDon(lstChiTiet, maHD, nv.MANV, Convert.ToInt32(tongtien));

                if (check)
                {
                    //MessageBox.Show("In hoá đơn thành công !");
                    xuatFileExcel();
                    veTrangThaiBD();


                }
                else
                {
                    MessageBox.Show("In hoá đơn thất bại !");
                }
            frmOrder_Load(sender, e);

            
        }
        public void xuatFileExcel()
        {
            frm_rpOrder rp = new frm_rpOrder(maHD);
            rp.Show();
        }
        private void veTrangThaiBD()
        {
            hienthiSanPham(sp_bll.getALLSP());
            resetPNThanhToan();
            //loadLoaiNguyenLieu();
            btnThanhToan.Enabled = false;
            tongtienHd = 0;
            lstChiTiet = null;
            pnChiTietHD.Controls.Clear();
            maHD = "";

        }

        private void btnThucAn_Click(object sender, EventArgs e)
        {
            List<SANPHAM> lst = sp_bll.getALLByLoaiList(ds.DOAN);
            hienthiSanPham(lst);
        }

        private void btnThucUong_Click(object sender, EventArgs e)
        {
            List<SANPHAM> lst = sp_bll.getALLByLoaiList(ds.DOUONG);
            hienthiSanPham(lst);
        }

        private void BtnND_Click(object sender, EventArgs e)
        {

        }
        TimeSpan getDateDifference(DateTime date1, DateTime date2)
        {
            TimeSpan ts = date1 - date2;
            int differenceInDays = ts.Days;
            string differenceAsString = differenceInDays.ToString();
            return ts;

        }
        private void cboKhuyenMai_SelectedIndexChanged(object sender, EventArgs e)
        {
            KHUYENMAI km = new KHUYENMAI();
            String makm = cboKhuyenMai.SelectedValue.ToString();
            
            km = kmai.getPhanTramKMByMa(cboKhuyenMai.SelectedValue.ToString());
            
            if (km == null)
            {
                lbPhanTramGiam.Text = "0";
            }
            else
            {
                TimeSpan difference_NGAYBD = getDateDifference(DateTime.Now, km.NGAYBD.Value);
                TimeSpan difference_NGAYKT = getDateDifference(km.NGAYKT.Value, DateTime.Now);
                int ngaybd_ht = difference_NGAYBD.Days;
                int ngaykt_ht = difference_NGAYKT.Days;
                if (ngaybd_ht >= 0)
                {
                    lbPhanTramGiam.Text = km.PHANTRAMKM.ToString();
                }
                else lbPhanTramGiam.Text = "0";
            }
        }

        private void btnHaiSan_Click(object sender, EventArgs e)
        {
            List<SANPHAM> lst = sp_bll.getALLByLoaiList(ds.HAISAN);
            hienthiSanPham(lst);
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            hienthiDV(dv_bll.getALLDV());
        }
    }
}
