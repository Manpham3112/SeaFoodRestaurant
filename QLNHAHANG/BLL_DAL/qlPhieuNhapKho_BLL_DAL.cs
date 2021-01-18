using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class qlPhieuNhapKho_BLL_DAL
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public IQueryable loadDataGridViewPhieuNhapKho()
        {
            //return db.PHIEUNHAPKHOs.Select(pnk => new { pnk.MAPNK, pnk.MANCC, pnk.MANV, pnk.NGAYNHAP, pnk.TONGTIEN });
            return db.PHIEUNHAPKHOs
               .Join(db.NHACUNGCAPs,
                  phieunhap => phieunhap.MANCC,
                  ncc => ncc.MANCC,
                  (phieunhap, ncc) => new { mapnk = phieunhap.MAPNK, TenNCC = ncc.TENNCC, manv = phieunhap.MANV, NgayLap = phieunhap.NGAYNHAP , tongtien = phieunhap.TONGTIEN });
        }
        public int kiemtrakhoachinh(string mapnk)
        {
            var phieunhapkho = (from pnk in db.PHIEUNHAPKHOs
                                where pnk.MAPNK.Equals(mapnk)
                                select pnk).FirstOrDefault();
            if (phieunhapkho != null)
            {
                return -1;
            }
            return 1;
        }

        public PHIEUNHAPKHO getPhieuNhapTheoMa(string maPN)
        {
            return db.PHIEUNHAPKHOs.FirstOrDefault(n => n.MAPNK.Equals(maPN));
        }

        public void themPhieuNhapKho(string mapnk, string manv, string mancc, DateTime ngaynhap, float tongtien)
        {
            PHIEUNHAPKHO insert = new PHIEUNHAPKHO();
            insert.MAPNK = mapnk;
            insert.MANCC = mancc;
            insert.MANV = manv; 
            insert.NGAYNHAP = ngaynhap;
            insert.TONGTIEN = tongtien;
            db.PHIEUNHAPKHOs.InsertOnSubmit(insert);
            db.SubmitChanges();
        }
        public void suaPhieuNhapKho(string manv, string mancc, string ngaynhap, float tongtien)
        {
            PHIEUNHAPKHO update = db.PHIEUNHAPKHOs.Where(t => t.MAPNK == mancc).FirstOrDefault();
            if (update != null)
            {
                update.MANCC = mancc;
                update.MANV = manv;
                update.NGAYNHAP = DateTime.Parse(ngaynhap);
                update.TONGTIEN = tongtien;
            }
            db.SubmitChanges();
        }
        public void xoaPhieuNhapKho(string mapnk)
        {
            PHIEUNHAPKHO delete = db.PHIEUNHAPKHOs.Where(t => t.MAPNK == mapnk).FirstOrDefault();
            if (delete != null)
            {
                db.PHIEUNHAPKHOs.DeleteOnSubmit(delete);
            }
            db.SubmitChanges();
        }
        public IQueryable<PHIEUNHAPKHO> loadTimKiemGridViewPhieuNhapKho(string txtTimKiem)
        {
            var phieunhapkho = from pnk in db.PHIEUNHAPKHOs
                               where pnk.MAPNK.Contains(txtTimKiem) ||
                               pnk.MANCC.Contains(txtTimKiem) ||
                               pnk.MANV.Contains(txtTimKiem)
                               select pnk;
            return phieunhapkho;
        }

        public int updateView_v_PHieuNhapKhoTheoMaNCC(string maNCC)
        {
            string cmd = "alter view v_phieuNhapTheoMaNCC as select * from PHIEUNHAPKHO where MANCC = '" + maNCC + "'";
            return db.ExecuteCommand(cmd);
        }
        public int updateView_v_PHieuNhapKhoTheoMaNV(string manv)
        {
            string cmd = "alter view v_phieuNhapTheoMaNV as select * from PHIEUNHAPKHO where MANV = '" + manv + "'";
            return db.ExecuteCommand(cmd);
        }
        //public void capNhatTong(string maPhieuNhan, int tong)
        //{
        //    PHIEUNHAPKHO p = db.PHIEUNHAPKHOs.Where(t => t.MAPNK == maPhieuNhan).SingleOrDefault();
        //    p.TONGTIEN = tong;
        //    db.SubmitChanges();
        //}
        public bool kT(string ma)
        {
            if (db.PHIEUNHAPKHOs.Where(t => t.MAPNK == ma).Count() != 0)
            {
                return false;
            }
            else
                return true;
        }
        public int demSoLuong()
        {
            return db.PHIEUNHAPKHOs.Select(kh => kh).Count();
        }

        public IQueryable loadAllNCC()
        {
            return db.NHACUNGCAPs.Select(t => t);
        }
        public NHACUNGCAP layTenNCC(string manhom)
        {
            return db.NHACUNGCAPs.SingleOrDefault(t => t.MANCC == manhom);
        }
    }
}
