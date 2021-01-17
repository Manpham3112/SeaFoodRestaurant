using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNHAHANG
{
    public partial class frm_rpKhuyenMai : Form
    {
        public frm_rpKhuyenMai()
        {
            InitializeComponent();
        }
        private void frm_rpKhuyenMai_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.Refresh();

            rpKhuyenMai rp = new rpKhuyenMai();
            //rp.SetDatabaseLogon("sa", "sa2012", "DESKTOP-HHM5LAU", "QL_BANHANG");
            //rp.Refresh();
            
            crystalReportViewer1.ReportSource = rp;
            crystalReportViewer1.Refresh();
            
            crystalReportViewer1.DisplayToolbar = false;
            crystalReportViewer1.DisplayStatusBar = false;
        }
    }
}
