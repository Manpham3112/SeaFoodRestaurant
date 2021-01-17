using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class LoaiNguyenLieu_BLL_DAL
    {
        DataClasses1DataContext ff = new DataClasses1DataContext();
        public LoaiNguyenLieu_BLL_DAL()
        {

        }
        public IQueryable loadLoaiNguyenLieu()
        {
            return ff.LOAINLs.Select(t => t);
        }
        public int kiemtrakhoachinh(string malnl)
        {
            var loainl = (from lnl in ff.LOAINLs
                         where lnl.MALNL.Equals(malnl)
                         select lnl).FirstOrDefault();

            if (loainl != null)
            {
                return -1;
            }
            return 1;
        }
        public void themLoaiNL(string malnl, string tenlnl)
        {
            LOAINL insert = new LOAINL();
            insert.MALNL = malnl;
            insert.TENLNL = tenlnl;
            ff.LOAINLs.InsertOnSubmit(insert);
            ff.SubmitChanges();
        }
        public void suaLoaiNL(string malnl, string tenlnl)
        {
            LOAINL update = ff.LOAINLs.Where(t => t.MALNL == malnl).FirstOrDefault();
            if (update != null)
            {
                update.TENLNL = tenlnl;
            }
            ff.SubmitChanges();
        }
        public void xoaLNL(string malnl)
        {
            LOAINL delete = ff.LOAINLs.Where(t => t.MALNL == malnl).FirstOrDefault();
            if (delete != null)
            {
                ff.LOAINLs.DeleteOnSubmit(delete);
            }
            ff.SubmitChanges();

        }
        public IQueryable<LOAINL> loadTimKiemGridViewLoaiNL(string txtTimKiem)
        {
            var loainl = from lnl in ff.LOAINLs
                             where lnl.MALNL.Contains(txtTimKiem) ||
                             lnl.TENLNL.Contains(txtTimKiem)
                             select lnl;
            return loainl;
        }
        public String taoMaLoaiNguyenLieu()
        {
            int so = ff.LOAINLs.Select(t => t.MALNL).Count() + 1;

            if (so < 10)
            {
                return "LNL00" + so;
            }
            else
                return "LNL0" + so;
        }
    }

}
