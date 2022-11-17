using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace GUI
{
    public partial class reporthoadonban : Form
    {
        public reporthoadonban()
        {
            InitializeComponent();
        }

        public string MaHD { get; set; }
        private void reporthoadonban_Load(object sender, EventArgs e)
        {
            QuanlyvatlieuxaydungDataSet dataqlvlxd = new QuanlyvatlieuxaydungDataSet();
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-F10VF04\SQLEXPRESS;Initial Catalog=Quanlyvatlieuxaydung;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter(@"select * from CHITIETHDBAN where MaHD = N'"+MaHD+"' ", conn);
            adapter.Fill(dataqlvlxd,dataqlvlxd.Tables[0].TableName);
            this.reportViewer1.LocalReport.ReportPath=@"Reporthoadonban.rdlc";
            //this.reportViewer1.LocalReport.ReportEmbeddedResource = "quanlyvatlieuxaydung.Reporthoadonban.rdlc";
            //this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            ReportDataSource rds = new ReportDataSource("tb",dataqlvlxd.Tables[0]);
            
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
            
        }
    }
}
