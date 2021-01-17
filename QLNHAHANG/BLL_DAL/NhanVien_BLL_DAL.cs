using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
 public class NhanVien_BLL_DAL
    {
        DataClasses1DataContext ff = new DataClasses1DataContext();
        public NhanVien_BLL_DAL()
         {

         }
        public IQueryable loadDataGridViewNhanVien()
        {
            return ff.NHANVIENs.Select(t => t);
        }
        public IQueryable<NHOMQUYEN> layNhomQuyen()
        {
            return ff.NHOMQUYENs.Select(t => t);
        }

        public void submitChange()
        {
            ff.SubmitChanges();
        }
        public List<NHANVIEN> loadListNhanVien()
        {
            return ff.NHANVIENs.Select(t => t).ToList<NHANVIEN>();
        }

        public IQueryable loadCboNhomNhanVien()
        {
            return ff.NHOMQUYENs.Select(t => t);
        }

        public void themNhanVien(string ma, string tennv, string sdt, string diachi,
            DateTime ngaysinnh,string manhom, bool tinhtrang, string matkhau)
        {
            NHANVIEN nv = new NHANVIEN();
            nv.MANV = ma;
            nv.TENNV = tennv;
            nv.SDT = sdt;
            nv.DIACHI = diachi;
            nv.NGAYSINH = Convert.ToDateTime(ngaysinnh);
            nv.MANQ = manhom;
            //nd.HoatDong = Convert.ToBoolean(hoatdong);
            nv.MATKHAU = matkhau;
            ff.NHANVIENs.InsertOnSubmit(nv);
            ff.SubmitChanges();
        }

        public void suaNhanVien(string ma, string tennv, string sdt, string diachi,
            DateTime ngaysinnh, string manhom, bool tinhtrang, string matkhau)
        {
            NHANVIEN nv = ff.NHANVIENs.Where(t => t.MANV == ma).FirstOrDefault();
            if (nv != null)
            {
                nv.MANV = ma;
                nv.TENNV = tennv;
                nv.SDT = sdt;
                nv.DIACHI = diachi;
                nv.NGAYSINH = Convert.ToDateTime(ngaysinnh);
                nv.MANQ = manhom;
                //nd.HoatDong = Convert.ToBoolean(hoatdong);
                nv.MATKHAU = matkhau;
            }
            ff.SubmitChanges();
        }
        public void xoaNhanVien(string ma)
        {
            NHANVIEN nd = ff.NHANVIENs.Where(t => t.MANV == ma).FirstOrDefault();
            if (nd != null)
            {
                ff.NHANVIENs.DeleteOnSubmit(nd);
            }
            ff.SubmitChanges();
        }
        public IQueryable<NHANVIEN> loadGridViewTimKiemNhanVien(string txtTimKiem)
        {
            var nhanvien = from nv in ff.NHANVIENs
                            where nv.MANV.Contains(txtTimKiem) ||
                            nv.TENNV.Contains(txtTimKiem) ||
                            nv.SDT.Contains(txtTimKiem) ||
                            nv.DIACHI.Contains(txtTimKiem)
                            select nv;
            return nhanvien;
        }
        public int demSoLuong()
        {
            return ff.NHANVIENs.Select(kh => kh).Count();
        }

        public int kiemTraKhoaChinh(string s)
        {
            return ff.NHANVIENs.Where(a => a.MANV == s).Select(nd => nd).Count();
        }

        public NHOMQUYEN layNhomtheoMa(string manhom)
        {
            return ff.NHOMQUYENs.SingleOrDefault(t => t.MANQ == manhom);
        }
        public NHANVIEN getNhanVienTheoMa(string maNV)
        {
            return ff.NHANVIENs.FirstOrDefault(n => n.MANV.Equals(maNV));
        }

        public bool UpdatePassWord(string userID, string password)
        {
            NHANVIEN nv = ff.NHANVIENs.FirstOrDefault(n => n.MANV.Equals(userID));
            if(nv != null)
            {
                nv.MATKHAU = password;
                submitChange();
                return true;
            }
            return false;
        }

        public IQueryable<NHOMQUYEN> layNhomNQ()
        {
            return ff.NHOMQUYENs.Select(t => t);
        }
        public bool themNhomNQ(NHOMQUYEN nnd, List<PHANQUYEN> lstPQ)
        {
            try
            {
                ff.NHOMQUYENs.InsertOnSubmit(nnd);
                foreach (PHANQUYEN item in lstPQ)
                {
                    ff.PHANQUYENs.InsertOnSubmit(item);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool suaNhomNQ(NHOMQUYEN nnd, List<PHANQUYEN> lstPQ)
        {
            try
            {
                NHOMQUYEN nhom = ff.NHOMQUYENs.SingleOrDefault(t => t.MANQ == nnd.MANQ);
                nhom = nnd;
                if (lstPQ.Count == 0)
                {
                    submitChange();
                    return true;
                }
                else
                {
                    foreach (PHANQUYEN item in ff.PHANQUYENs.Where(t => t.MANQ == nnd.MANQ))
                    {
                        ff.PHANQUYENs.DeleteOnSubmit(item);
                    }
                    foreach (PHANQUYEN pq in lstPQ)
                    {
                        ff.PHANQUYENs.InsertOnSubmit(pq);
                    }
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public IQueryable<MANHINH> layMH()
        {
            return ff.MANHINHs.Select(t => t);
        }
        public List<PHANQUYEN> layMH(string maNhom)
        {
            List<MANHINH> lst = layMH().ToList<MANHINH>();
            List<PHANQUYEN> lstPQ = ff.PHANQUYENs.Where(t => t.MANQ == maNhom).ToList<PHANQUYEN>();
            foreach (MANHINH item in lst)
            {
                PHANQUYEN pq = lstPQ.SingleOrDefault(t => t.MAMH == item.MAMH);
                if (pq == null)
                    continue;
                pq.TENMH = item.TENMH;
            }
            return lstPQ;
        }
        public bool xoaNhomNQ(string manhom)
        {
            NHOMQUYEN nnd = ff.NHOMQUYENs.SingleOrDefault(t => t.MANQ == manhom);

            if (ff.PHANQUYENs.Count(t => t.MANQ == nnd.MANQ) == 0)
            {
                foreach (NHANVIEN item in ff.NHANVIENs.Where(t => t.MANQ == nnd.MANQ))
                {
                    item.MANQ = null;
                }
                ff.NHOMQUYENs.DeleteOnSubmit(nnd);
            }

            else
            {
                foreach (PHANQUYEN item in ff.PHANQUYENs.Where(t => t.MANQ == nnd.MANQ))
                {
                    ff.PHANQUYENs.DeleteOnSubmit(item);
                }

                foreach (NHANVIEN item in ff.NHANVIENs.Where(t => t.MANQ == nnd.MANQ))
                {
                    item.MANQ = null;
                }
                ff.NHOMQUYENs.DeleteOnSubmit(nnd);
                submitChange();
            }
            return true;


        }
    }


}
