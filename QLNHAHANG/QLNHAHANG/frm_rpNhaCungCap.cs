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
    public partial class frm_rpNhaCungCap : Form
    {
        public frm_rpNhaCungCap()
        {
            InitializeComponent();
        }
        private void frm_rpNhaCungCap_Load(object sender, EventArgs e)
        {
            rpNhaCungCap rp = new rpNhaCungCap();
            crystalReportViewer1.ReportSource = rp;
            rp.SetDatabaseLogon("sa", "sa2012", "DESKTOP-HHM5LAU", "QL_NHAHANG");
            crystalReportViewer1.Refresh();
            crystalReportViewer1.DisplayToolbar = false;
            crystalReportViewer1.DisplayStatusBar = false;
        }
    }
}
