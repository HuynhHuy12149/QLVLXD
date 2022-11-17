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
    public partial class reportkhohang : Form
    {
        public reportkhohang()
        {
            InitializeComponent();
        }
        SqlConnection con;

        DataSet readdata(string cmd)
        {
            DataSet dtset = new DataSet();
            SqlDataAdapter dt = new SqlDataAdapter(cmd, con);
            dt.Fill(dtset);
            return dtset;
        }
        private void reportkhohang_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-F10VF04\SQLEXPRESS;Initial Catalog=Quanlyvatlieuxaydung;Integrated Security=True";
            string cmd = @"select * from  SANPHAM";
            DataSet dtaset = new DataSet();
            dtaset = readdata(cmd);

            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
            reportViewer1.LocalReport.ReportPath = "Reportkhohang.rdlc";
            //reportViewer1.LocalReport.ReportEmbeddedResource = "quanlyvatlieuxaydung.Reporthoadonban.rdlc";
            if (dtaset.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "tbkhohang";
                rds.Value = dtaset.Tables[0];
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }

        }
    }
}
