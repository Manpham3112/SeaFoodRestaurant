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
    public partial class frmThongKe : Form
    {
        HoaDon_BLL_DAL hd = new HoaDon_BLL_DAL();
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            fillchart();
        }
        private void fillchart()
        {
            Salary.Series["Salary"].Points.AddXY("Ajay", "10000");
            Salary.Series["Salary"].Points.AddXY("Ramesh", "8000");
            Salary.Series["Salary"].Points.AddXY("Ankit", "7000");
            Salary.Series["Salary"].Points.AddXY("Gurmeet", "10000");
            Salary.Series["Salary"].Points.AddXY("Suresh", "8500");
            //chart title  
            Salary.Titles.Add("Salary Chart");
        }

        private void Salary_Click(object sender, EventArgs e)
        {

        }
    }
}
