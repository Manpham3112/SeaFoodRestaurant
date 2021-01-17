using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
   public class qlNhaCungCap_BLL_DAL
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public IQueryable<NHACUNGCAP> loadDataGridViewNhaCungCap()
        {
            return db.NHACUNGCAPs.Select(ncc => ncc);
        }
        public NHACUNGCAP getNhaCungCapTheoMa(string maNCC)
        {
            return db.NHACUNGCAPs.FirstOrDefault(n => n.MANCC.Equals(maNCC));
        }
        public int kiemtrakhoachinh(string mancc)
        {
            var nhacc = (from ncc in db.NHACUNGCAPs
                         where ncc.MANCC.Equals(mancc)
                         select ncc).FirstOrDefault();

            if (nhacc != null)
            {
                return -1;
            }
            return 1;
        }


        public void themNhaCungCap(string mancc, string tenncc, string diachi, string sdt)
        {
            NHACUNGCAP insert = new NHACUNGCAP();
            insert.MANCC = mancc;
            insert.TENNCC = tenncc;
            insert.DIACHI = diachi;
            insert.SDT = sdt;
            db.NHACUNGCAPs.InsertOnSubmit(insert);
            db.SubmitChanges();
        }


        public void suaNhaCungCap(string mancc, string tenncc, string diachi, string sdt)
        {
            NHACUNGCAP update = db.NHACUNGCAPs.Where(t => t.MANCC == mancc).FirstOrDefault();
            if (update != null)
            {
                update.TENNCC = tenncc;
                update.DIACHI = diachi;
                update.SDT = sdt;
            }
            db.SubmitChanges();
        }

        public void xoaNhaCungCap(string mancc)
        {
            NHACUNGCAP delete = db.NHACUNGCAPs.Where(t => t.MANCC == mancc).FirstOrDefault();
            if (delete != null)
            {
                db.NHACUNGCAPs.DeleteOnSubmit(delete);
            }
            db.SubmitChanges();

        }
        public IQueryable<NHACUNGCAP> loadTimKiemGridViewNhaCungCap(string txtTimKiem)
        {
            var nhacungcap = from ncc in db.NHACUNGCAPs
                             where ncc.MANCC.Contains(txtTimKiem) ||
                             ncc.TENNCC.Contains(txtTimKiem) ||
                             ncc.SDT.Contains(txtTimKiem) ||
                             ncc.DIACHI.Contains(txtTimKiem)
                             select ncc;
            return nhacungcap;


        }
    }

}
