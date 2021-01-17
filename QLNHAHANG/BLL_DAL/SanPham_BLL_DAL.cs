using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
   public class SanPham_BLL_DAL
    {
        DataClasses1DataContext qlsp = new DataClasses1DataContext();
        // tim san pham

        public List<SANPHAM> searchSP(string tenSP)
        {
            return qlsp.SANPHAMs.Where(t => t.TENSP.Contains(tenSP)).ToList();
        }

        //lay tat ca san pham
        public List<SANPHAM> getALLSP()
        {
            return loaiSPhetNL(qlsp.SANPHAMs.Select(t => t).ToList());
        }

        // lay tat ca san pham cho grid view
        public IQueryable<SANPHAM> getALLSPGV()
        {
            return qlsp.SANPHAMs.Select(t => t);
        }

        public IQueryable<SANPHAM> getALLByLoai(string maloai)
        {
            return qlsp.SANPHAMs.Where(t => t.MALSP == maloai);
        }

        public List<SANPHAM> getALLByLoaiList(string maloai)
        {
            return loaiSPhetNL(qlsp.SANPHAMs.Where(t => t.MALSP == maloai).ToList());
        }

        public List<LOAINL> getALLCateNL()
        {
            return qlsp.LOAINLs.Select(t => t).ToList();
        }

        // Lay Nguyen Lieu Theo ma
        public IQueryable<NGUYENLIEU> getALLNguyenLieuByLoai(string maloaiNL)
        {
            return qlsp.NGUYENLIEUs.Where(t => t.MALNL == maloaiNL);
        }

        // Lay cac san pham co nguyen lieu do
        public IQueryable<SANPHAM> getALLSanPhamByNguyenLieu(string maNL)
        {
            return from sp in qlsp.SANPHAMs
                   from sp_nl in qlsp.CT_SANPHAM_NGUYENLIEUs
                   where sp.MASP == sp_nl.MASP && sp_nl.MANL == maNL
                   select sp;
        }

        // lay tat ca loai san pham
        public IQueryable<LOAISP> getAllLoaiSP(string maTenSP)
        {
            return qlsp.LOAISPs.Select(t => t);
        }

        // lay tat ca san pham theo loai
        public IQueryable<SANPHAM> getALLSanPhamByLoai(string maloaiSP)
        {
            return qlsp.SANPHAMs.Where(t => t.MALSP == maloaiSP);

        }



        // lay san pham theo loai nguyen lieu       

        public List<SANPHAM> laySPTheoLoaiNL(string maloaiNL)
        {
            List<SANPHAM> lstSP = new List<SANPHAM>();

            List<NGUYENLIEU> lstnl = getALLNguyenLieuByLoai(maloaiNL).ToList();

            foreach (NGUYENLIEU item in lstnl)
            {
                if (item.SOLUONG == 0)
                {
                    continue;
                }
                foreach (SANPHAM itemsp in getALLSanPhamByNguyenLieu(item.MANL))
                {
                    lstSP.Add(itemsp);
                }
            }

            return loaiSPhetNL(lstSP);

        }

        public SANPHAM laySP(string maSP)
        {
            return qlsp.SANPHAMs.SingleOrDefault(t => t.MASP == maSP);
        }


        public IQueryable loadAllLoai()
        {
            return qlsp.LOAISPs.Select(t => t);
        }

        // load loai san pham
        public IQueryable laySPAndLoai()
        {
            return (from sp in qlsp.SANPHAMs from loai in qlsp.LOAISPs where sp.MALSP == loai.MALSP select new { sp.MASP, sp.TENSP, sp.GIABAN, sp.TRANGTHAI, sp.HINHANH, loai.TENLSP }).Distinct();
        }

        public List<SANPHAM> laySPTheoLoai(string maLoai)
        {
            LOAISP loai = qlsp.LOAISPs.SingleOrDefault(t => t.MALSP == maLoai);
            List<SANPHAM> lst = getALLByLoaiList(maLoai);
            foreach (SANPHAM item in lst)
            {
                item.TENLSP = loai.TENLSP;
            }
            return lst;

        }

        public List<SANPHAM> laySPAndLoaiTheoLoai(string maloai)
        {
            return (from sp in qlsp.SANPHAMs from loai in qlsp.LOAISPs where sp.MALSP == loai.MALSP && sp.MALSP == maloai select new SANPHAM(sp, loai.TENLSP)).Distinct().ToList();
        }

        // Lay all SP_NguyenLieu
        
        public List<CT_SANPHAM_NGUYENLIEU> laySP_NL(string maSP)
        {
            return qlsp.CT_SANPHAM_NGUYENLIEUs.Where(t => t.MASP == maSP).ToList();
        }

        public List<NGUYENLIEU> layNL_SanPham(string tenNL)
        {
            return qlsp.NGUYENLIEUs.Where(t => t.TENNL.Contains(tenNL)).ToList();
        }

        public List<NGUYENLIEU> LayTatCaNguyenLieu()
        {
            return qlsp.NGUYENLIEUs.Select(t => t).ToList();
        }

        public bool themSanPham(SANPHAM sp, List<CT_SANPHAM_NGUYENLIEU> lstNLSP)
        {
            try
            {
                qlsp.SANPHAMs.InsertOnSubmit(sp);
                foreach (CT_SANPHAM_NGUYENLIEU item in lstNLSP)
                {
                    qlsp.CT_SANPHAM_NGUYENLIEUs.InsertOnSubmit(item);

                }
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool suaSanPham(SANPHAM sp, List<CT_SANPHAM_NGUYENLIEU> lstNLSP)
        {
            try
            {
                SANPHAM currentSP = qlsp.SANPHAMs.Single(t => t.MASP == sp.MASP);

                if (currentSP == null)
                {
                    return false;
                }

                currentSP.TENSP = sp.TENSP;
                currentSP.GIABAN = sp.GIABAN;
                currentSP.HINHANH = sp.HINHANH;
                currentSP.TRANGTHAI = sp.TRANGTHAI;
                currentSP.MALSP = sp.MALSP;

                qlsp.SubmitChanges();
                if (lstNLSP.Count == 0)
                {
                    return true;
                }

                // xoa het nguyen lieu cap nhap lai
                xoaHetNLcuaSP(currentSP.MASP);
                foreach (CT_SANPHAM_NGUYENLIEU item in lstNLSP)
                {

                    qlsp.CT_SANPHAM_NGUYENLIEUs.InsertOnSubmit(item);

                }
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        private void xoaHetNLcuaSP(string MaSP)
        {
            if (qlsp.CT_SANPHAM_NGUYENLIEUs.Count(t => t.MASP == MaSP) == 0)
            {
                return;
            }
            foreach (CT_SANPHAM_NGUYENLIEU item in qlsp.CT_SANPHAM_NGUYENLIEUs.Where(t => t.MASP == MaSP))
            {
                qlsp.CT_SANPHAM_NGUYENLIEUs.DeleteOnSubmit(item);
            }
        }

        public bool xoaSP(string maSP)
        {
            SANPHAM sp = qlsp.SANPHAMs.SingleOrDefault(t => t.MASP == maSP);
            try
            {
                if (qlsp.SANPHAMs.Count(t => t.MASP == sp.MASP) != 0)
                {
                    xoaHetNLcuaSP(sp.MASP);
                }
                qlsp.SANPHAMs.DeleteOnSubmit(sp);
                submitChange();
                return true;
            }
            catch (Exception)
            {
                return false;

            }

        }

        public void submitChange()
        {
            qlsp.SubmitChanges();
        }
        public List<SANPHAM> loaiSPhetNL(List<SANPHAM> lstsp)
        {
            List<SANPHAM> lst = new List<SANPHAM>();

            foreach (SANPHAM sp in lstsp)
            {
                if (ktSLNL(sp) == false)
                {
                    continue;
                }
                lst.Add(sp);
            }

            return lst;

        }
        private bool ktSLNL(SANPHAM sp)
        {
            foreach (CT_SANPHAM_NGUYENLIEU item in qlsp.CT_SANPHAM_NGUYENLIEUs.Where(t => t.MASP == sp.MASP))
            {
                NGUYENLIEU nl = qlsp.NGUYENLIEUs.SingleOrDefault(t => t.MANL == item.MANL);
                if (nl.SOLUONG == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public IQueryable<SANPHAM> loadGridViewTimKiemSanPham(string txtTimKiem)
        {
            var sanpham = from nv in qlsp.SANPHAMs
                           where nv.MASP.Contains(txtTimKiem) ||
                           nv.TENSP.Contains(txtTimKiem)
                           select nv;
            return sanpham;
        }
        public IQueryable<NGUYENLIEU> loadGridViewTimKiemNguyenLieu(string txtTimKiem)
        {
            var nguyenlieu = from nv in qlsp.NGUYENLIEUs
                          where nv.MANL.Contains(txtTimKiem) ||
                          nv.TENNL.Contains(txtTimKiem)
                          select nv;
            return nguyenlieu;
        }
    }
}
