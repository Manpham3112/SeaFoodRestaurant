using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNHAHANG
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new frmNhaCungCap());
            //Application.Run(new frmNguyenLieu());
            //Application.Run(new frmLoaiNguyenLieu());
            //Application.Run(new frmLoaiSP());
            //Application.Run(new Form1());
            //Application.Run(new frmKhachHang());
            //Application.Run(new frmOrder());
            //Application.Run(new frmHoaDon());
            //Application.Run(new frmNhapKho());
            //Application.Run(new frmKhuyenMai());
            Application.Run(new frmLogin());
            //Application.Run(new frmThongKe());
            //Application.Run(new frmNhanVien());

        }
    }
}
