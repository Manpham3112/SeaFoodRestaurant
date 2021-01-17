using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class Login_BLL_DAL
    {
        DataClasses1DataContext ql = new DataClasses1DataContext();
        public Login_BLL_DAL()
        {

        }
        public NHANVIEN layND(string matk)
        {
            return ql.NHANVIENs.SingleOrDefault(t => t.MANV == matk);
        }

        public int ktTaiKhoan(string user, string password)
        {
            NHANVIEN tk = ql.NHANVIENs.SingleOrDefault(t => t.MANV == user);

            if (tk != null)
            {
                string pass = Utils.Decrypt(tk.MATKHAU.Trim());
                if (pass == password.Trim())
                {
                    return 1;
                }
                return 0;
            }
            else
            {
                return -1;
            }
        }
        public List<PHANQUYEN> lstPQ(string manhom)
        {
            return ql.PHANQUYENs.Where(t => t.MANQ == manhom).ToList();
        }

        public KHACHHANG layKH(string matk)
        {
            return ql.KHACHHANGs.SingleOrDefault(t => t.TAIKHOAN == matk);
        }
        public int ktKH(string user, string password)
        {
            KHACHHANG tk = ql.KHACHHANGs.SingleOrDefault(t => t.TAIKHOAN == user);

            if (tk != null)
            {
                string pass = Utils.Decrypt(tk.MATKHAU.Trim());
                if (pass == password.Trim())
                {
                    return 1;
                }
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
