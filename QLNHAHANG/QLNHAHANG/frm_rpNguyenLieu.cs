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
    public partial class frm_rpNguyenLieu : Form
    {
        public frm_rpNguyenLieu()
        {
            InitializeComponent();
        }
        private void frm_rpNguyenLieu_Load(object sender, EventArgs e)
        {
            rpNguyenLieu rp = new rpNguyenLieu();
            crystalReportViewer1.ReportSource = rp;
            rp.SetDatabaseLogon("sa", "sa2012", "DESKTOP-HHM5LAU", "QL_NHAHANG");
            crystalReportViewer1.Refresh();
            crystalReportViewer1.DisplayToolbar = false;
            crystalReportViewer1.DisplayStatusBar = false;
        }
    }
}
