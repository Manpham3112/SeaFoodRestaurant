using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class qlKhuyenMai_BLL_DAL
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public IQueryable<KHUYENMAI> loadDataGridViewKhuyenMai()
        {
            return db.KHUYENMAIs.Select(km => km);
        }

        public KHUYENMAI getKhuyenMaiTheoMa(string makm)
        {
            return db.KHUYENMAIs.FirstOrDefault(n => n.MAKM.Equals(makm));
        }

        public int kiemtrakhoachinh(string makm)
        {
            var kmai = (from km in db.KHUYENMAIs
                        where km.MAKM.Equals(makm)
                        select km).FirstOrDefault();

            if (kmai != null)
            {
                return -1;
            }
            return 1;
        }
        public void themKhuyenMai(string makm, string tenkm, int phantramkm, string ngaybd, string ngaykt)
        {
            KHUYENMAI insert = new KHUYENMAI();
            insert.MAKM = makm;
            insert.TENKM = tenkm;
            insert.PHANTRAMKM = phantramkm;
            insert.NGAYBD = DateTime.Parse(ngaybd);
            insert.NGAYKT = DateTime.Parse(ngaykt);
            db.KHUYENMAIs.InsertOnSubmit(insert);
            db.SubmitChanges();
        }
        public void suaKhuyenMai(string makm, string tenkm, int phantramkm, string ngaybd, string ngaykt)
        {
            KHUYENMAI update = db.KHUYENMAIs.Where(t => t.MAKM == makm).FirstOrDefault();
            if (update != null)
            {
                update.TENKM = tenkm;
                update.PHANTRAMKM = phantramkm;
                update.NGAYBD = DateTime.Parse(ngaybd);
                update.NGAYKT = DateTime.Parse(ngaykt);
            }
            db.SubmitChanges();
        }
        public void xoaKhuyenMai(string makm)
        {
            KHUYENMAI delete = db.KHUYENMAIs.Where(t => t.MAKM == makm).FirstOrDefault();
            if (delete != null)
            {
                db.KHUYENMAIs.DeleteOnSubmit(delete);
            }
            db.SubmitChanges();
        }
        public IQueryable<KHUYENMAI> loadTimKiemGridViewKhuyenMai(string txtTimKiem)
        {
            var khuyenmai = from km in db.KHUYENMAIs
                            where km.MAKM.Contains(txtTimKiem) ||
                            km.TENKM.Contains(txtTimKiem)
                            select km;
            return khuyenmai;
        }
        public int demSoLuong()
        {
            return db.KHUYENMAIs.Select(kh => kh).Count();
        }
        public IQueryable loadKhuyenMai()
        {
            return db.KHUYENMAIs.Where(t => t.NGAYBD <= DateTime.Now && t.NGAYKT >= DateTime.Now );
        }
        public KHUYENMAI getPhanTramKMByMa(string maKM)
        {
           var khuyenmai = db.KHUYENMAIs
                .Where(m => m.MAKM == maKM 
                     ).FirstOrDefault();
            return khuyenmai;

        }
    }
}
