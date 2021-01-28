using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
   public class NguyenLieu_BLL_DAL
    {
        DataClasses1DataContext ff = new DataClasses1DataContext();
        public NguyenLieu_BLL_DAL()
        {

        }
        public NGUYENLIEU getNguyenLieuTheoMa(string manl)
        {
            return ff.NGUYENLIEUs.FirstOrDefault(n => n.MANL.Equals(manl));
        }
        public IQueryable loadNguyenLieu()
        {
            return ff.NGUYENLIEUs.Select(t => new { t.MANL, t.TENNL, t.SOLUONG,t.DVT });
        }

        // lấy tất cả thông tin nguyên liệu cho form kho
        public IQueryable loadNguyenLieuFormKho()
        {
            IQueryable c = from nl in ff.NGUYENLIEUs
                           from l in ff.LOAINLs
                           where l.MALNL == nl.MALNL
                           select new
                           {
                               nl.MANL,
                               nl.TENNL,
                               nl.DVT,
                               nl.SOLUONG,
                               nl.HSD,
                               l.TENLNL
                           };
            return c;
        }
        // Thêm Nguyên liệu
        public void themNguyenLieu(string maNL, string tenNL, string donVi, int soLuong, DateTime hanSD, string maLoaiNL)
        {
            NGUYENLIEU nl = new NGUYENLIEU();
            nl.MANL = maNL;
            nl.TENNL = tenNL;
            nl.DVT = donVi;
            nl.SOLUONG = soLuong;
            nl.HSD = hanSD;
            nl.MALNL = maLoaiNL;
            ff.NGUYENLIEUs.InsertOnSubmit(nl);
            ff.SubmitChanges();
        }
        // Xóa Nguyên liệu
        public void xoaNguyenLieu(string maNL)
        {
            NGUYENLIEU xoaNL = ff.NGUYENLIEUs.Where(n => n.MANL == maNL).FirstOrDefault();
            if (xoaNL != null)
            {
                ff.NGUYENLIEUs.DeleteOnSubmit(xoaNL);
                ff.SubmitChanges();
            }
            
        }
        // Sửa nguyên liệu
        public void suaNguyenLieu(string maNL, string tenNL, string donVi, int soLuong, DateTime hanSD, string maLoaiNL)
        {
            NGUYENLIEU suaNL = ff.NGUYENLIEUs.Where(n => n.MANL == maNL).FirstOrDefault();
            if (suaNL != null)
            {
                suaNL.TENNL = tenNL;
                suaNL.DVT = donVi;
                suaNL.SOLUONG = soLuong;
                suaNL.HSD = hanSD;
                suaNL.MALNL = maLoaiNL;
                ff.SubmitChanges();
            }
        }
        // load combobox MaLoaiNL
        public IQueryable load_cboMaLoai()
        {
            return ff.LOAINLs.Select(t => t);
        }

        // Tự sinh mã nguyên liệu mới 
        public String taoMaNguyenLieu()
        {
            int so = ff.NGUYENLIEUs.Select(t => t.MANL).Count() + 1;

            if (so < 100)
            {
                return "NL00" + so;
            }
            else
                return "NL" + so;
        }
        //Loc dữ liệu
        public IQueryable loadGridViewTheoHangHetDate(DateTime ngayht)
        {
            IQueryable nguyenlieu = from nl in ff.NGUYENLIEUs
                                    from l in ff.LOAINLs
                                    where l.MALNL == nl.MALNL
                                    && (nl.HSD < ngayht && nl.SOLUONG > 0)
                                    select new
                                    {
                                        nl.MANL,
                                        nl.TENNL,
                                        nl.DVT,
                                        nl.SOLUONG,
                                        nl.HSD,
                                        l.TENLNL
                                    };
            return nguyenlieu;
        }
        public IQueryable loadGridViewTheoHangHetTrongKho()
        {
            IQueryable nguyenlieu = from nl in ff.NGUYENLIEUs
                                    from l in ff.LOAINLs
                                    where l.MALNL == nl.MALNL
                                    && (nl.SOLUONG == 0)
                                    select new
                                    {
                                        nl.MANL,
                                        nl.TENNL,
                                        nl.DVT,
                                        nl.SOLUONG,
                                        nl.HSD,
                                        l.TENLNL
                                    };
            return nguyenlieu;
            //return ff.QL_NguyenLieus.Where(f => f.SoLuong == 0).Select(f => f);
        }

        public IQueryable<NGUYENLIEU> loadGridViewTatCa()
        {
            return ff.NGUYENLIEUs.Select(f => f);
        }

        public int kiemtrakhoachinh(string manl)
        {
            var nguyenlieu = (from nl in ff.NGUYENLIEUs
                              where nl.MANL.Equals(manl)
                              select nl).FirstOrDefault();

            if (nguyenlieu != null)
            {
                return -1;
            }
            return 1;

        }


        public IQueryable loadGridViewNguyenLieuTimKiem(string txtTimKiem)
        {
            IQueryable nguyenlieu = from nl in ff.NGUYENLIEUs
                                    from l in ff.LOAINLs
                                    where l.MALNL == nl.MALNL
                                    && (nl.MANL.Contains(txtTimKiem) ||
                                   nl.MALNL.Contains(txtTimKiem) ||
                                   nl.TENNL.Contains(txtTimKiem))
                                    select new
                                    {
                                        nl.MANL,
                                        nl.TENNL,
                                        nl.DVT,
                                        nl.SOLUONG,
                                        nl.HSD,
                                        l.TENLNL
                                    };
            return nguyenlieu;

        }
    }
}
