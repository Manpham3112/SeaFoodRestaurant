using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
   public class HoaDon_BLL_DAL
    {
        DataClasses1DataContext hd = new DataClasses1DataContext();
        public HoaDon_BLL_DAL()
        {

        }

        public int demHD()
        {
            return hd.HOADONs.Select(t => t).Count();
        }

        public bool ktKhoaChinhHD(string maHD)
        {
            return hd.HOADONs.SingleOrDefault(t => t.MAHD == maHD) == null ? true : false;

        }
        public string taoMaHD()
        {
            int so = hd.HOADONs.Select(t => t.MAHD).Count() + 1;

            if (so < 10)
            {
                return "HD00" + so;
            }
            else
                return "HD0" + so;
        }

        public bool themHoaDon(List<CT_HOADON> lstCT, string maHD, string maNV, double TongCong)
        {
            try
            {

                HOADON newHD = new HOADON();
                newHD.MAHD = maHD;
                newHD.MANV = maNV;
                newHD.NGAYLAP = DateTime.Now.Date;
                newHD.TONGTIEN = TongCong;
                hd.HOADONs.InsertOnSubmit(newHD);
                hd.SubmitChanges();
                foreach (CT_HOADON item in lstCT)
                {
                    item.MAHD = maHD;
                    
                    hd.CT_HOADONs.InsertOnSubmit(item);
                    hd.SubmitChanges();
                }
               
                return true;
            }
            catch (Exception e)
            {
                string a = e.ToString();
                
                return false;
                throw;
            }


        }
        public IQueryable<HOADON> layHoaDon()
        {
            return hd.HOADONs.Select(t => t);
        }








        public HOADON layHD(string hdon)
        {
            return hd.HOADONs.SingleOrDefault(t => t.MAHD == hdon);
        }

        public IQueryable<HOADON> loadHoaDonTheoNgay(DateTime fr, DateTime to)
        {
            var hoadon = from hd in hd.HOADONs
                         where hd.NGAYLAP >= fr && hd.NGAYLAP <= to
                         select hd;
            return hoadon;
        }

        public List<HOADON> layDSHDTheoNgay(DateTime fr, DateTime to)
        {
            var hoadon = from hd in hd.HOADONs
                         where hd.NGAYLAP >= fr && hd.NGAYLAP <= to
                         select hd;
            return hoadon.ToList();
        }
        public IQueryable<HOADON> loadGridViewTimKiemHoaDon(string txtTimKiem)
        {
            var hoadon = from hd in hd.HOADONs
                         where hd.MAHD.Contains(txtTimKiem) ||
                         hd.MANV.Contains(txtTimKiem)
                         select hd;
            return hoadon;

            //return qlkh.QL_KHACHHANGs.Where(kh => kh.HoTen.Contains(tenkh)).Select(kh => kh);
        }
        public IQueryable<CT_HOADON> layChiTietHoaDon(string maHD)
        {
            return hd.CT_HOADONs.Where(t => t.MAHD == maHD);
        }
        public void xuatKho(DateTime from, DateTime to)
        {
            // so luong sp
            int slsp = 0;
            // so luong nguyen lieu de lam ra sp
            int slnl = 0;
            List<HOADON> lstHD = layDSHDTheoNgay(from, to);

            foreach (HOADON sp in lstHD)
            {
                    // lay tung san pham cua hoa don
                    foreach (CT_HOADON chitietHD in hd.CT_HOADONs.Where(t => t.MAHD == sp.MAHD))
                    {

                        slsp = (int)chitietHD.SOLUONG;

                        // lay tung nguyen lieu cua san pham do
                        foreach (CT_SANPHAM_NGUYENLIEU nlsp in hd.CT_SANPHAM_NGUYENLIEUs.Where(t => t.MASP == chitietHD.MASP))
                        {
                            slnl = (int)nlsp.SOLUONG;

                            NGUYENLIEU nl = hd.NGUYENLIEUs.SingleOrDefault(t => t.MANL == nlsp.MANL);
                            nl.SOLUONG -= slnl * slsp;
                            if (nl.SOLUONG <= 0)
                            {
                                nl.SOLUONG = 0;
                            }
                        }
                    }
                }
                hd.SubmitChanges();
            }
        public List<SANPHAM> laySPhetNL()
        {
            List<SANPHAM> sptk = new List<SANPHAM>();
            foreach (SANPHAM sp in hd.SANPHAMs)
            {
                foreach (CT_SANPHAM_NGUYENLIEU nlsp in hd.CT_SANPHAM_NGUYENLIEUs.Where(t => t.MASP == sp.MASP))
                {
                    int soluong = (int)hd.NGUYENLIEUs.SingleOrDefault(t => t.MANL == nlsp.MANL).SOLUONG;
                    if (soluong == 0)
                    {
                        sptk.Add(sp);
                    }
                }
            }
            return sptk;
        }
        // lay danh sach san pham theo ngay thang nam
        public List<SanPham_ThongKe> layDSSPTheo(DateTime fromday, DateTime today)
        {
            var dsChitiet = from hdon in hd.HOADONs
                            from chitiet in hd.CT_HOADONs
                            where hdon.MAHD == chitiet.MAHD
                            && hdon.NGAYLAP >= fromday && hdon.NGAYLAP <= today
                            select chitiet;

            List<SanPham_ThongKe> lstSP = new List<SanPham_ThongKe>();
            List<CT_HOADON> lstChiTiet = dsChitiet.ToList();

            foreach (CT_HOADON chitiet in lstChiTiet)
            {
                // kiem tra sp trung
                if (lstSP.Count(t => t.MASP == chitiet.MASP) == 0)
                {
                    SanPham_ThongKe sptk = new SanPham_ThongKe();
                    sptk.MASP = chitiet.MASP;
                    sptk.SOLUONG += (int)chitiet.SOLUONG;
                    sptk.DONGIA = (int)chitiet.THANHTIEN;
                    lstSP.Add(sptk);
                }
                else
                {
                    SanPham_ThongKe sptk = lstSP.SingleOrDefault(t => t.MASP == chitiet.MASP);
                    sptk.SOLUONG += (int)chitiet.SOLUONG;
                }
            }

            return lstSP;
        }

    }

    

}
