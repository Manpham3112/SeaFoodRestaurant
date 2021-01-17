using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public partial class SANPHAM
    {
        private string _TENLSP;

        public string TENLSP
        {
            get { return _TENLSP; }
            set { _TENLSP = value; }
        }
        public SANPHAM(SANPHAM sp, string tenloai)
        {

            this.MASP = sp.MASP;
            this.TENSP = sp.TENSP;
            this.TRANGTHAI = sp.TRANGTHAI;
            this.TENLSP = tenloai;
            this.HINHANH = sp.HINHANH;
            this.GIABAN = sp.GIABAN;
            this.MALSP = sp.MALSP;
        }
    }
}
