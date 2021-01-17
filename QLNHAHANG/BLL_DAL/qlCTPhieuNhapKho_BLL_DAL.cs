using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class qlCTPhieuNhapKho_BLL_DAL
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public IQueryable<CT_PHIEUNHAPKHO> loadDataGridViewCTPhieuNhapKho()
        {
            return db.CT_PHIEUNHAPKHOs.Select(ctpnk => ctpnk);
        }

        public int kiemtrakhoachinh(string mapnk, string manl)
        {
            var ctphieunhapkho = (from ctpnk in db.CT_PHIEUNHAPKHOs
                                  where (ctpnk.MAPNK.Equals(mapnk) && ctpnk.MANL.Equals(manl))
                                  select ctpnk).FirstOrDefault();
            if (ctphieunhapkho != null)
            {
                return -1;
            }
            return 1;
        }
        public IQueryable chiTietPhieuNhap(string maPN)
        {
            IQueryable ct = from c in db.CT_PHIEUNHAPKHOs
                            where c.MAPNK == maPN
                            select new { c.MAPNK, c.MANL, c.SOLUONG, c.GIANHAP};
            return ct;
        }
        public void themCTPhieuNhapKho(string mapnk, string manl, int soluong, int donGia)
        {
            CT_PHIEUNHAPKHO ct = new CT_PHIEUNHAPKHO();
            ct.MAPNK = mapnk;
            ct.MANL = manl;
            ct.SOLUONG = soluong;
            ct.GIANHAP = donGia;
            db.CT_PHIEUNHAPKHOs.InsertOnSubmit(ct);
            db.SubmitChanges();
        }
        //public void suaCTPhieuNhapKho(string mapnk, string manl, string soluong, string thanhtien)
        //{
        //    CT_PHIEUNHAPKHO update = db.CT_PHIEUNHAPKHOs.Where(t => t.MANL == manl && t.MAPNK == mapnk).FirstOrDefault();
        //    if (update != null)
        //    {
        //        update.SOLUONG = Convert.ToInt32(soluong);
        //        update.THANHTIEN = Convert.ToInt32(thanhtien);
        //    }
        //    db.SubmitChanges();
        //}
        public void xoaCTPhieuNhapKho(string mapn, string manl)
        {
            CT_PHIEUNHAPKHO ct = db.CT_PHIEUNHAPKHOs.Where(t => t.MAPNK == mapn & t.MANL == manl).FirstOrDefault();
            db.CT_PHIEUNHAPKHOs.DeleteOnSubmit(ct);
            db.SubmitChanges();
        }
        public IQueryable<CT_PHIEUNHAPKHO> loadTimKiemGridViewCTPhieuNhapKho(string txtTimKiem)
        {
            var ctphieunhapkho = from ctpnk in db.CT_PHIEUNHAPKHOs
                                 where ctpnk.MAPNK.Contains(txtTimKiem) ||
                                 ctpnk.MANL.Contains(txtTimKiem)
                                 select ctpnk;
            return ctphieunhapkho;
        }
        public Boolean ktTrung(string maNL, string maPN)
        {
            if (db.CT_PHIEUNHAPKHOs.Where(t => t.MANL == maNL && t.MAPNK == maPN).Count() != 0)
                return false;
            else
                return true;
        }
        public void updateSLNL (string maNL)
        {
           NGUYENLIEU nl = db.NGUYENLIEUs.Where(t => t.MANL == maNL).FirstOrDefault();
            
        }
            

    }
}
