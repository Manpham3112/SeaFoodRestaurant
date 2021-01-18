using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
   public class LoaiSP_BLL_DALL
    {
        DataClasses1DataContext ff = new DataClasses1DataContext();
        public LoaiSP_BLL_DALL()
        {

        }
        public int demSoLuong()
        {
            return ff.LOAISPs.Select(kh => kh).Count();
        }
        public IQueryable loadLoaiSP()
        {
            return ff.LOAISPs.Select(t => t);
        }
        public int kiemtrakhoachinh(string malsp)
        {
            var loaisp = (from lsp in ff.LOAISPs
                          where lsp.MALSP.Equals(malsp)
                          select lsp).FirstOrDefault();

            if (loaisp != null)
            {
                return -1;
            }
            return 1;
        }
        public void themLoaiSP(string malsp, string tenlsp)
        {
            LOAISP insert = new LOAISP();
            insert.MALSP = malsp;
            insert.TENLSP = tenlsp;
            ff.LOAISPs.InsertOnSubmit(insert);
            ff.SubmitChanges();
        }
        public void suaLoaiSP(string malsp, string tenlsp)
        {
            LOAISP update = ff.LOAISPs.Where(t => t.MALSP == malsp).FirstOrDefault();
            if (update != null)
            {
                update.TENLSP = tenlsp;
            }
            ff.SubmitChanges();
        }
        public void xoaLSP(string malsp)
        {
            LOAISP delete = ff.LOAISPs.Where(t => t.MALSP == malsp).FirstOrDefault();
            if (delete != null)
            {
                ff.LOAISPs.DeleteOnSubmit(delete);
            }
            ff.SubmitChanges();

        }
        public IQueryable<LOAISP> loadTimKiemGridViewLoaiSP(string txtTimKiem)
        {
            var loaisp = from lsp in ff.LOAISPs
                         where lsp.MALSP.Contains(txtTimKiem) ||
                         lsp.TENLSP.Contains(txtTimKiem)
                         select lsp;
            return loaisp;
        }
        public String taoMaLoaiSP()
        {
            int so = ff.LOAINLs.Select(t => t.MALNL).Count() + 1;

            if (so < 10)
            {
                return "LSP00" + so;
            }
            else
                return "LSP0" + so;
        }
    }
}
