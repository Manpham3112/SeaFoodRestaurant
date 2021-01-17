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
namespace clb_QLNHAHANG
{
    public partial class usChiTietHD : UserControl
    {
        public int TongTien;
        public int soluong;
        private int dongia;
        public usChiTietHD()
        {
            InitializeComponent();
            TongTien = 0;
            soluong = 1;
        }
        public void setValue(string masp)
        {
            SanPham_BLL_DAL qlsp = new SanPham_BLL_DAL();
            SANPHAM sp = qlsp.laySP(masp);
            lbTen.Text = sp.TENSP;
            lbGia.Text = sp.GIABAN.ToString();
            lbTongTien.Text = sp.GIABAN.ToString() ;
            soluong = (int)btnTangGiam.Value;
            dongia = (int)sp.GIABAN;
            TongTien = dongia * soluong;
        }
        public void setValueDV(string masp)
        {
            qlDichVu_BLL_DAL qlsp = new qlDichVu_BLL_DAL();
            DICHVU sp = qlsp.layDV(masp);
            lbTen.Text = sp.TENDV;
            lbGia.Text = sp.GIADV.ToString();
            lbTongTien.Text = sp.GIADV.ToString();
            soluong = (int)btnTangGiam.Value;
            dongia = (int)sp.GIADV;
            TongTien = dongia * soluong;
        }

        public void capnhapTongTien(int soluong)
        {
            TongTien = dongia * soluong;
            this.lbTongTien.Text = TongTien.ToString();
        }
    }
}
