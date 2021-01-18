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
    public partial class frm_rpLoaiNguyenLieu : Form
    {
        public frm_rpLoaiNguyenLieu()
        {
            InitializeComponent();
        }
        private void frm_rpLoaiNguyenLieu_Load(object sender, EventArgs e)
        {
            rpLoaiNguyenLieu rp = new rpLoaiNguyenLieu();
            crystalReportViewer1.ReportSource = rp;
            rp.SetDatabaseLogon("sa", "sa2012", "DESKTOP-HHM5LAU", "QL_NHAHANG");
            crystalReportViewer1.Refresh();
            crystalReportViewer1.DisplayToolbar = false;
            crystalReportViewer1.DisplayStatusBar = false;
        }
    }
}
