using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace GUI
{
    public partial class reportdoanhthu : Form
    {
        public reportdoanhthu()
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
        private void reportdoanhthu_Load(object sender, EventArgs e)
        {

            con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-F10VF04\SQLEXPRESS;Initial Catalog=Quanlyvatlieuxaydung;Integrated Security=True";
            string cmd = @"select * from  HOADONBAN";
            DataSet dtaset = new DataSet();
            dtaset = readdata(cmd);

            rpdoanhthu.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            rpdoanhthu.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rpdoanhthu.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            rpdoanhthu.ZoomPercent = 100;
            rpdoanhthu.LocalReport.ReportPath = "Reportdoanhthu.rdlc";
            //reportViewer1.LocalReport.ReportEmbeddedResource = "quanlyvatlieuxaydung.Reporthoadonban.rdlc";
            if (dtaset.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "tbhd";
                rds.Value = dtaset.Tables[0];
                rpdoanhthu.LocalReport.DataSources.Clear();
                rpdoanhthu.LocalReport.DataSources.Add(rds);
                rpdoanhthu.RefreshReport();
            }

        }
    }
}
