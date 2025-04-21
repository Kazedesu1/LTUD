using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanLyktx
{
    public partial class FormThongKeThanhToanHoaDon : Form
    {
        public FormThongKeThanhToanHoaDon()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            CrystalReport6 bcp = new CrystalReport6();
            dataTable = kn.Lay_DulieuBang("select * from XemThongKeChuaThanhToanHoaDon");
            bcp.SetDataSource(dataTable);
            crystalReportViewer1.ReportSource = bcp;
        }
    }
}
