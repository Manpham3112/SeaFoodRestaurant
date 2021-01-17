using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;
namespace QLNHAHANG
{
    public partial class frmThongKeSanPham : Form
    {
        HoaDon_BLL_DAL hd = new HoaDon_BLL_DAL();
        public frmThongKeSanPham()
        {
            InitializeComponent();
        }

        private void frmThongKeSanPham_Load(object sender, EventArgs e)
        {
            dateTimePickerFrom.Value = DateTime.Now;
            dateTimePickerTo.Value = DateTime.Now;
            gvBanCham.DataSource = hd.laySPhetNL();
        }
        public void loadGvSanPham()
        {
            gvThongKeSP.DataSource = hd.layDSSPTheo(dateTimePickerFrom.Value, dateTimePickerTo.Value);
        }

        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            List<SanPham_ThongKe> lstSP = hd.layDSSPTheo(dateTimePickerFrom.Value, dateTimePickerTo.Value);
            if (lstSP.Count == 0)
            {
                return;
            }
            gvThongKeSP.DataSource = lstSP;

            int max = lstSP.Select(t => t).Max(t => t.SOLUONG);
            int min = lstSP.Select(t => t).Min(t => t.SOLUONG);

            SanPham_Kmean spk = new SanPham_Kmean(lstSP, max, min);
            spk.Xuly(3);
            List<SanPham_ThongKe> spbanchay = lstSP.Where(t => t.SOLUONG <= max && t.SOLUONG > (max + min) / 2).ToList();
            List<SanPham_ThongKe> spbandc = lstSP.Where(t => t.SOLUONG <= (max + min) / 2 && t.SOLUONG > min).ToList();
            gvBanChay.DataSource = spbanchay;
            gvBanBinhThuong.DataSource = spbandc;
        }

        private void dateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            List<SanPham_ThongKe> lstSP = hd.layDSSPTheo(dateTimePickerFrom.Value, dateTimePickerTo.Value);
            if (lstSP.Count == 0)
            {
                return;
            }
            gvThongKeSP.DataSource = lstSP;

            int max = lstSP.Select(t => t).Max(t => t.SOLUONG);
            int min = lstSP.Select(t => t).Min(t => t.SOLUONG);

            SanPham_Kmean spk = new SanPham_Kmean(lstSP, max, min);
            spk.Xuly(3);
            gvBanChay.DataSource = lstSP.Where(t => t.SOLUONG <= max);
        }
    }
}
