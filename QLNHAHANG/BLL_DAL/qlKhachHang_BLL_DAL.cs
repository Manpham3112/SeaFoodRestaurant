using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class qlKhachHang_BLL_DAL
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public IQueryable<KHACHHANG> loadDataGridViewKhachHang()
        {
            return db.KHACHHANGs.Select(kh => kh);
        }

        public KHACHHANG getKhachHangTheoMa(string makh)
        {
            return db.KHACHHANGs.FirstOrDefault(n => n.MAKH.Equals(makh));
        }

        public int kiemtrakhoachinh(string makh)
        {
            var khachhang = (from kh in db.KHACHHANGs
                             where kh.MAKH.Equals(makh)
                             select kh).FirstOrDefault();

            if (khachhang != null)
            {
                return -1;
            }
            return 1;
        }
        public int demSoLuong()
        {
            return db.KHACHHANGs.Select(kh => kh).Count();
        }
        public void themKhachHang(string makh, string tenkh, string sdt, string diachi, string taikhoan, string matkhau)
        {
            KHACHHANG insert = new KHACHHANG();
            insert.MAKH = makh;
            insert.TENKH = tenkh;
            insert.DIACHI = diachi;
            insert.SDT = sdt;
            insert.TAIKHOAN = taikhoan;
            insert.MATKHAU = matkhau;
            db.KHACHHANGs.InsertOnSubmit(insert);
            db.SubmitChanges();
        }
        public void suaKhachHang(string makh, string tenkh, string sdt, string diachi, string taikhoan, string matkhau)
        {
            KHACHHANG update = db.KHACHHANGs.Where(t => t.MAKH == makh).FirstOrDefault();
            if (update != null)
            {
                update.TENKH = tenkh;
                update.DIACHI = diachi;
                update.SDT = sdt;
                update.MATKHAU = matkhau;
                update.TAIKHOAN = taikhoan;
            }
            db.SubmitChanges();
        }
        public void xoaKhachHang(string makh)
        {
            KHACHHANG delete = db.KHACHHANGs.Where(t => t.MAKH == makh).FirstOrDefault();
            if (delete != null)
            {
                db.KHACHHANGs.DeleteOnSubmit(delete);
            }
            db.SubmitChanges();
        }
        public IQueryable<KHACHHANG> loadTimKiemGridViewKhachHang(string txtTimKiem)
        {
            var khachhang = from kh in db.KHACHHANGs
                            where kh.MAKH.Contains(txtTimKiem) ||
                             kh.TENKH.Contains(txtTimKiem) ||
                             kh.SDT.Contains(txtTimKiem) ||
                             kh.DIACHI.Contains(txtTimKiem) ||
                             kh.TAIKHOAN.Contains(txtTimKiem) ||
                             kh.MATKHAU.Contains(txtTimKiem)
                            select kh;
            return khachhang;
        }
    }
}
