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
using Guna.UI.WinForms;

namespace QLNHAHANG
{
    public partial class TrangChu : Form
    {

        List<Control> lstControl;
        Login_BLL_DAL login = new Login_BLL_DAL();
        NHANVIEN tk; KHACHHANG t;
        private Form activieForm = null;
        GunaAdvenceButton btn, btnHoaDon, btnNhanVien, btnSanPham, btnDichVu,
            btnKhuyenMai, btnLoaiSP, btnLoaiNL,btnNhaCC, btnKH,
            btnNguyenLieu, btnDatHang, btnNhapKho, btnTK;

        private void btnKho_Click(object sender, EventArgs e)
        {
            pnTabHoz.Controls.Clear();
                btnNhapKho = addButton("Nhập kho");
            btnNhapKho.Click += BtnNhapKho_Click;
            pnTabHoz.Controls.Add(btnNhapKho);
            BtnNhapKho_Click(sender, e);


        }

        private void btnHidePnTaiKhoan_Click(object sender, EventArgs e)
        {
            if (pnSubTaiKhoan.Visible == false)
            {
                pnSubTaiKhoan.Visible = true;
            }
            else
            {
                pnSubTaiKhoan.Visible = false;
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Close();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            pnTabHoz.Controls.Clear();

            btnKH = addButton("Khách hàng");
            btnKH.Click += BtnKH_Click;
            pnTabHoz.Controls.Add(btnKH);
            BtnKH_Click(sender, e);
        }
        private void thietlapThongTin()
        {
            lbTenDN.Text = tk.TENNV;
        }
        private void TrangChu_Load(object sender, EventArgs e)
        {
            thietlapThongTin();
            thietlapPhanQuyen();
            if (this.tk.MANQ.Trim() == "NQ001")
            {
                btnSaoLuu.Visible = true;
                btnPhucHoi.Visible = true;
            }
            else
            {
                btnSaoLuu.Visible = false;
                btnPhucHoi.Visible = false;
            }
        }


        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            frmOrder frm = new frmOrder(true);
            frm.WindowState = FormWindowState.Maximized;
            frm.DangNhapNV(tk);
            frm.Show();
            this.Visible = false;
        }


        private void addFormInPanel(Form form)
        {
            if (activieForm != null)
            {
                activieForm.Close();
            }
            activieForm = form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnContainer.Controls.Add(form);
            this.pnContainer.Tag = form;
            form.BringToFront();
            form.Show();
        }
        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            pnTabHoz.Controls.Clear();

            btnHoaDon = addButton("Hóa đơn");
            btnHoaDon.Click += BtnHoaDon_Click;

            btnNhanVien = addButton("Nhân viên");
            btnNhanVien.Click += BtnNhanVien_Click;


            btnSanPham = addButton("Sản phẩm");
            btnSanPham.Click += BtnSanPham_Click;

            btnLoaiSP = addButton("Loại sản phẩm");
            btnLoaiSP.Click += BtnLoaiSP_Click;

            btnDichVu = addButton("Dịch vụ");
            btnDichVu.Click += BtnDichVu_Click;

            btnKhuyenMai = addButton("Khuyến mãi");
            btnKhuyenMai.Click += BtnKhuyenMai_Click;

            btnPhanQuyen = addButton("Phân Quyền");
            btnPhanQuyen.Click += BtnPhanQuyen_Click;

            btnNguyenLieu = addButton("Nguyên liệu");
            btnNguyenLieu.Click += BtnNguyenLieu_Click;


            btnLoaiNL = addButton("Loại nguyên liệu");
            btnLoaiNL.Click += BtnLoaiNL_Click;

            btnNhaCC = addButton("Nhà cung cấp");
            btnNhaCC.Click += BtnNhaCC_Click;

            pnTabHoz.Controls.Add(btnNguyenLieu);
            pnTabHoz.Controls.Add(btnLoaiNL);
            pnTabHoz.Controls.Add(btnNhaCC);
            pnTabHoz.Controls.Add(btnPhanQuyen);
            pnTabHoz.Controls.Add(btnHoaDon);
            pnTabHoz.Controls.Add(btnNhanVien);
            pnTabHoz.Controls.Add(btnSanPham);
            pnTabHoz.Controls.Add(btnLoaiSP);
            pnTabHoz.Controls.Add(btnDichVu);
            pnTabHoz.Controls.Add(btnKhuyenMai);


            BtnSanPham_Click(sender, e);
        }
        private void BtnNhanVien_Click(object sender, EventArgs e)
        {
            addFormInPanel(new frmNhanVien());
            btnHoaDon.LineColor = Color.FromArgb(227, 227, 227);
            btnNhanVien.LineColor = Color.MediumTurquoise;
            btnSanPham.LineColor = Color.FromArgb(227, 227, 227);
            btnDichVu.LineColor = Color.FromArgb(227, 227, 227);
            btnNhaCC.LineColor = Color.FromArgb(227, 227, 227);
            btnLoaiNL.LineColor = Color.FromArgb(227, 227, 227);
            btnLoaiSP.LineColor = Color.FromArgb(227, 227, 227);
            btnKhuyenMai.LineColor = Color.FromArgb(227, 227, 227);
            btnNguyenLieu.LineColor = Color.FromArgb(227, 227, 227);
            btnPhanQuyen.LineColor = Color.FromArgb(227, 227, 227);


        }
        private void BtnPhanQuyen_Click(object sender, EventArgs e)
        {
            addFormInPanel(new frmPhanQuyen());
            btnHoaDon.LineColor = Color.FromArgb(227, 227, 227);
            btnPhanQuyen.LineColor = Color.MediumTurquoise;
            btnSanPham.LineColor = Color.FromArgb(227, 227, 227);
            btnDichVu.LineColor = Color.FromArgb(227, 227, 227);
            btnNhaCC.LineColor = Color.FromArgb(227, 227, 227);
            btnLoaiNL.LineColor = Color.FromArgb(227, 227, 227);
            btnLoaiSP.LineColor = Color.FromArgb(227, 227, 227);
            btnKhuyenMai.LineColor = Color.FromArgb(227, 227, 227);
            btnNguyenLieu.LineColor = Color.FromArgb(227, 227, 227);
            btnNhanVien.LineColor = Color.FromArgb(227, 227, 227);
        }
        private void BtnSanPham_Click(object sender, EventArgs e)
        {
            addFormInPanel(new frmSanPham());
            btnHoaDon.LineColor = Color.FromArgb(227, 227, 227);
            btnSanPham.LineColor = Color.MediumTurquoise;
            btnNhanVien.LineColor = Color.FromArgb(227, 227, 227);
            btnDichVu.LineColor = Color.FromArgb(227, 227, 227);
            btnNhaCC.LineColor = Color.FromArgb(227, 227, 227);
            btnLoaiNL.LineColor = Color.FromArgb(227, 227, 227);
            btnLoaiSP.LineColor = Color.FromArgb(227, 227, 227);
            btnKhuyenMai.LineColor = Color.FromArgb(227, 227, 227);
            btnNguyenLieu.LineColor = Color.FromArgb(227, 227, 227);
            btnPhanQuyen.LineColor = Color.FromArgb(227, 227, 227);
        }
        private void BtnHoaDon_Click(object sender, EventArgs e)
        {
            addFormInPanel(new frmHoaDon());
            btnNhanVien.LineColor = Color.FromArgb(227, 227, 227);
            btnHoaDon.LineColor = Color.MediumTurquoise;
            btnSanPham.LineColor = Color.FromArgb(227, 227, 227);
            btnDichVu.LineColor = Color.FromArgb(227, 227, 227);
            btnNhaCC.LineColor = Color.FromArgb(227, 227, 227);
            btnLoaiNL.LineColor = Color.FromArgb(227, 227, 227);
            btnLoaiSP.LineColor = Color.FromArgb(227, 227, 227);
            btnKhuyenMai.LineColor = Color.FromArgb(227, 227, 227);
            btnNguyenLieu.LineColor = Color.FromArgb(227, 227, 227);
            btnPhanQuyen.LineColor = Color.FromArgb(227, 227, 227);
        }
        private void BtnDichVu_Click(object sender, EventArgs e)
        {
            addFormInPanel(new frmDichVu());
            btnHoaDon.LineColor = Color.FromArgb(227, 227, 227);
            btnDichVu.LineColor = Color.MediumTurquoise;
            btnSanPham.LineColor = Color.FromArgb(227, 227, 227);
            btnNhanVien.LineColor = Color.FromArgb(227, 227, 227);
            btnNhaCC.LineColor = Color.FromArgb(227, 227, 227);
            btnLoaiNL.LineColor = Color.FromArgb(227, 227, 227);
            btnLoaiSP.LineColor = Color.FromArgb(227, 227, 227);
            btnKhuyenMai.LineColor = Color.FromArgb(227, 227, 227);
            btnNguyenLieu.LineColor = Color.FromArgb(227, 227, 227);
            btnPhanQuyen.LineColor = Color.FromArgb(227, 227, 227);
        }
        private void BtnKhuyenMai_Click(object sender, EventArgs e)
        {
            addFormInPanel(new frmKhuyenMai());
            btnHoaDon.LineColor = Color.FromArgb(227, 227, 227);
            btnKhuyenMai.LineColor = Color.MediumTurquoise;
            btnSanPham.LineColor = Color.FromArgb(227, 227, 227);
            btnDichVu.LineColor = Color.FromArgb(227, 227, 227);
            btnNhaCC.LineColor = Color.FromArgb(227, 227, 227);
            btnLoaiNL.LineColor = Color.FromArgb(227, 227, 227);
            btnLoaiSP.LineColor = Color.FromArgb(227, 227, 227);
            btnNhanVien.LineColor = Color.FromArgb(227, 227, 227);
            btnNguyenLieu.LineColor = Color.FromArgb(227, 227, 227);
            btnPhanQuyen.LineColor = Color.FromArgb(227, 227, 227);
        }
        private void BtnLoaiSP_Click(object sender, EventArgs e)
        {
            addFormInPanel(new frmLoaiSP());
            btnHoaDon.LineColor = Color.FromArgb(227, 227, 227);
            btnLoaiSP.LineColor = Color.MediumTurquoise;
            btnSanPham.LineColor = Color.FromArgb(227, 227, 227);
            btnDichVu.LineColor = Color.FromArgb(227, 227, 227);
            btnNhaCC.LineColor = Color.FromArgb(227, 227, 227);
            btnLoaiNL.LineColor = Color.FromArgb(227, 227, 227);
            btnNhanVien.LineColor = Color.FromArgb(227, 227, 227);
            btnKhuyenMai.LineColor = Color.FromArgb(227, 227, 227);
            btnNguyenLieu.LineColor = Color.FromArgb(227, 227, 227);
            btnPhanQuyen.LineColor = Color.FromArgb(227, 227, 227);
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            pnTabHoz.Controls.Clear();

            btnTK = addButton("Thống kê");
            btnTK.Click += BtnTK_Click;
            pnTabHoz.Controls.Add(btnKH);
            BtnTK_Click(sender, e);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            frmThongTinNhanVien frm = new frmThongTinNhanVien(true);
            frm.DangNhapNV(tk);
            frm.Show();
            this.Visible = false;
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

            frmThongTinNhanVien frm = new frmThongTinNhanVien(true);
            frm.DangNhapNV(tk);
            frm.Show();
            //this.Visible = false;
        }

        private void btnSaoLuu_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                bool isSuccess = HelperDB.BackupDatabase(dlg.SelectedPath);
                if (isSuccess)
                {
                    MessageBox.Show("Backup thanh cong");
                }
                else
                {
                    MessageBox.Show("Backup that bai");
                }

            }
        }

        private void btnPhucHoi_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database backup files|*.bak";
            dlg.Title = "Database restore";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                bool isSuccess = HelperDB.RostoreDatabase(dlg.FileName);
                if (isSuccess)
                {
                    MessageBox.Show("Restore thanh cong");
                }
                else
                {
                    MessageBox.Show("Restore that bai");
                }
            }
        }

        private void BtnTK_Click(object sender, EventArgs e)
        {
            addFormInPanel(new frmThongKeSanPham());
            btnTK.LineColor = Color.MediumTurquoise;


        }

        private void BtnNguyenLieu_Click(object sender, EventArgs e)
        {
            addFormInPanel(new frmNguyenLieu());
            btnHoaDon.LineColor = Color.FromArgb(227, 227, 227);
            btnNguyenLieu.LineColor = Color.MediumTurquoise;
            btnSanPham.LineColor = Color.FromArgb(227, 227, 227);
            btnDichVu.LineColor = Color.FromArgb(227, 227, 227);
            btnNhaCC.LineColor = Color.FromArgb(227, 227, 227);
            btnLoaiNL.LineColor = Color.FromArgb(227, 227, 227);
            btnLoaiSP.LineColor = Color.FromArgb(227, 227, 227);
            btnKhuyenMai.LineColor = Color.FromArgb(227, 227, 227);
            btnNhanVien.LineColor = Color.FromArgb(227, 227, 227);
            btnPhanQuyen.LineColor = Color.FromArgb(227, 227, 227);

        }
        private void BtnLoaiNL_Click(object sender, EventArgs e)
        {
            addFormInPanel(new frmLoaiNguyenLieu());
            btnHoaDon.LineColor = Color.FromArgb(227, 227, 227);
            btnLoaiNL.LineColor = Color.MediumTurquoise;
            btnSanPham.LineColor = Color.FromArgb(227, 227, 227);
            btnDichVu.LineColor = Color.FromArgb(227, 227, 227);
            btnNhaCC.LineColor = Color.FromArgb(227, 227, 227);
            btnNhanVien.LineColor = Color.FromArgb(227, 227, 227);
            btnLoaiSP.LineColor = Color.FromArgb(227, 227, 227);
            btnKhuyenMai.LineColor = Color.FromArgb(227, 227, 227);
            btnNguyenLieu.LineColor = Color.FromArgb(227, 227, 227);
            btnPhanQuyen.LineColor = Color.FromArgb(227, 227, 227);

        }
        private void BtnKH_Click(object sender, EventArgs e)
        {
            addFormInPanel(new frmKhachHang());
            btnKH.LineColor = Color.MediumTurquoise;

        }
        private void BtnNhaCC_Click(object sender, EventArgs e)
        {
            addFormInPanel(new frmNhaCungCap());
            btnHoaDon.LineColor = Color.FromArgb(227, 227, 227);
            btnNhaCC.LineColor = Color.MediumTurquoise;
            btnSanPham.LineColor = Color.FromArgb(227, 227, 227);
            btnDichVu.LineColor = Color.FromArgb(227, 227, 227);
            btnLoaiNL.LineColor = Color.FromArgb(227, 227, 227);
            btnNhanVien.LineColor = Color.FromArgb(227, 227, 227);
            btnLoaiSP.LineColor = Color.FromArgb(227, 227, 227);
            btnKhuyenMai.LineColor = Color.FromArgb(227, 227, 227);
            btnNguyenLieu.LineColor = Color.FromArgb(227, 227, 227);
            btnPhanQuyen.LineColor = Color.FromArgb(227, 227, 227);


        }
        private void BtnNhapKho_Click(object sender, EventArgs e)
        {
            frmNhapKho frm = new frmNhapKho(true);
            frm.DangNhapNV(tk);
            addFormInPanel(frm);
            btnNhapKho.LineColor = Color.MediumTurquoise;



        }
        private void btnCollapseMenu_Click(object sender, EventArgs e)
        {
            pnLeft.Width = 45;
            btnFullMenu.Visible = true;
            btnCollapseMenu.Visible = false;
            //btnLogo.Visible = false;
            btnHidePnTaiKhoan.Visible = false;
        }


        private void btnFullMenu_Click(object sender, EventArgs e)
        {
            pnLeft.Width = 250;
            btnCollapseMenu.Visible = true;
            btnFullMenu.Visible = false;
            // btnLogo.Visible = true;
            btnHidePnTaiKhoan.Visible = true;
        }


        public TrangChu()
        {
            InitializeComponent();
            btnFullMenu.Visible = false;
        }
        internal void DangNhapNV(BLL_DAL.NHANVIEN tk)
        {
            this.tk = tk;
        }
        public GunaAdvenceButton addButton(string text)
        {
            btn = new GunaAdvenceButton()
            {
                Animated = true,
                AnimationHoverSpeed = 0.07F,
                AnimationSpeed = 0.04F,
                BackColor = Color.Empty,
                BaseColor = Color.Empty,
                BorderColor = Color.Empty,
                CheckedBaseColor = Color.White,
                CheckedBorderColor = Color.White,
                CheckedForeColor = Color.White,
                CheckedImage = null,
                CheckedLineColor = Color.FromArgb(249, 130, 68),
                DialogResult = DialogResult.None,
                FocusedColor = Color.Empty,
                Font = new Font("Segoe UI", 11F),
                ForeColor = Color.FromArgb(64, 64, 64),
                Image = null,
                ImageSize = new Size(20, 20),
                LineBottom = 3,
                LineColor = Color.FromArgb(227, 227, 227),
                Location = new Point(428, 50),
                OnHoverBaseColor = Color.Empty,
                OnHoverBorderColor = Color.Empty,
                OnHoverForeColor = Color.FromArgb(64, 64, 64),
                OnHoverImage = null,
                OnHoverLineColor = Color.MediumTurquoise,
                OnPressedColor = Color.Black,
                Size = new Size(110, 40),
                TabIndex = 11,
                Text = text,
                TextAlign = HorizontalAlignment.Center,
                Dock = DockStyle.Left

            };
            return btn;

        }
        private void thietlapPhanQuyen()
        {
            if (tk == null)
                return;
            List<PHANQUYEN> lstPQ = login.lstPQ(tk.MANQ);
            foreach (GunaGradientButton item in pnControlPQ.Controls)
            {
                if (lstPQ.SingleOrDefault(t => t.MAMH == item.Tag.ToString()).COQUYEN == false)
                {
                    item.Enabled = false;
                }
                else
                {
                    item.Enabled = true;
                }
            }
        }
        public GunaAdvenceButton btnPhanQuyen { get; set; }
    }
}
