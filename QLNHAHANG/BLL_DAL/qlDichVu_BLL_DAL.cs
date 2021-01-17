using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class qlDichVu_BLL_DAL
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public DICHVU layDV(string maSP)
        {
            return db.DICHVUs.SingleOrDefault(t => t.MADV == maSP);
        }
        public List<DICHVU> getALLDV()
        {
            return db.DICHVUs.Select(t => t).ToList();
        }
        public IQueryable<DICHVU> loadDataGridViewDichVu()
        {
            return db.DICHVUs.Select(dv => dv);
        }

        public int kiemtrakhoachinh(string madv)
        {
            var dichvu = (from dv in db.DICHVUs
                          where dv.MADV.Equals(madv)
                          select dv).FirstOrDefault();

            if (dichvu != null)
            {
                return -1;
            }
            return 1;
        }
        public bool themDV(DICHVU dv)
        {
            try
            {
                db.DICHVUs.InsertOnSubmit(dv);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool suaDV(DICHVU sp)
        {
            try
            {
                DICHVU currentSP = db.DICHVUs.Single(t => t.MADV == sp.MADV);

                if (currentSP == null)
                {
                    return false;
                }

                currentSP.TENDV = sp.TENDV;
                currentSP.GIADV = sp.GIADV;
                currentSP.ANH = sp.ANH;
                currentSP.MOTA = sp.MOTA;

                db.SubmitChanges();
               
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public void submitChange()
        {
            db.SubmitChanges();
        }
        public void themDichVu(string madv, string tendv, string mota, float giadv)
        {
            DICHVU insert = new DICHVU();
            insert.MADV = madv;
            insert.TENDV = tendv;
            insert.MOTA = mota;
            insert.GIADV = giadv;
            db.DICHVUs.InsertOnSubmit(insert);
            db.SubmitChanges();
        }
        public void suaDichVu(string madv, string tendv, string mota, float giadv)
        {
            DICHVU update = db.DICHVUs.Where(t => t.MADV == madv).FirstOrDefault();
            if (update != null)
            {
                update.TENDV = tendv;
                update.MOTA = mota;
                update.GIADV = giadv;
            }
            db.SubmitChanges();
        }
        public void xoaDichVu(string madv)
        {
            DICHVU delete = db.DICHVUs.Where(t => t.MADV == madv).FirstOrDefault();
            if (delete != null)
            {
                db.DICHVUs.DeleteOnSubmit(delete);
            }
            db.SubmitChanges();
        }
        public IQueryable<DICHVU> loadTimKiemGridViewDichVu(string txtTimKiem)
        {
            var dichvu = from dv in db.DICHVUs
                         where dv.MADV.Contains(txtTimKiem) ||
                         dv.TENDV.Contains(txtTimKiem) ||
                         dv.MOTA.Contains(txtTimKiem)
                         select dv;
            return dichvu;
        }
        public int demSoLuong()
        {
            return db.DICHVUs.Select(kh => kh).Count();
        }
    }
}
