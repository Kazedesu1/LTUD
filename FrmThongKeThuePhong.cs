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
    public partial class FrmThongKeThuePhong : Form
    {
        public FrmThongKeThuePhong()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        

        private void crystalReportViewer1_Load_1(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            CrystalReport1 bcp = new CrystalReport1();
            dataTable = kn.Lay_DulieuBang("select * from XemDanhSachSinhVien");
            bcp.SetDataSource(dataTable);
            crystalReportViewer1.ReportSource = bcp;
        }
    }
}
