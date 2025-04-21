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
    public partial class FrmThongKeKhieuNai : Form
    {
        public FrmThongKeKhieuNai()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            CrystalReport5 bcp = new CrystalReport5();
            dataTable = kn.Lay_DulieuBang("select * from XemThongKeKhieuNaiChuaXuLy");
            bcp.SetDataSource(dataTable);
            crystalReportViewer1.ReportSource = bcp;
        }
    }
}
