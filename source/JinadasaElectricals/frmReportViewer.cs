using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data.SqlClient;
using System.Configuration;
namespace  BarcodeGenarator
{
    public partial class frmReportViewer : Form
    {
        public frmReportViewer()
        {
            InitializeComponent();
        }

        public void LoadItemReport()
        {

            SqlConnection Con = new SqlConnection(ConfigurationSettings.AppSettings["Database.ConnectionStr"]);
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            ReportDocument rptDoc = new ReportDocument();
            Con.Open();


            cmd.CommandText = "GetAllItems";
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@accountNo", SqlDbType.VarChar);

            //cmd.Parameters["@accountNo"].Value = accountNo;
            cmd.Connection = Con;
            ds = new DataSet();
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds, "GetAllItems");

            rptDoc.Load(@"../../Reports/Items.rpt");

            rptDoc.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rptDoc;
        }

       
        public void LoadBarcodeReport(DataSet ds)
        {

       
            ReportDocument rptDoc = new ReportDocument();
          

            rptDoc.Load(@"../../Reports/BarcodeDetails.rpt");

            rptDoc.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rptDoc;
        }

        public void LoadTVSBarcodeReport(DataSet ds)
        {
            ReportDocument rptDoc = new ReportDocument();


            rptDoc.Load(@"../../Reports/TVSBarcodeDetails.rpt");

            rptDoc.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rptDoc;
        }

        public void LoadBajajBarcodeReport(DataSet ds)
        {
            ReportDocument rptDoc = new ReportDocument();


            rptDoc.Load(@"../../Reports/BajajBarcodeDetails.rpt");

            rptDoc.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rptDoc;
        }

        public void LoadHeroBarcodeReport(DataSet ds)
        {
            ReportDocument rptDoc = new ReportDocument();


            rptDoc.Load(@"../../Reports/HeroBarcodeDetails.rpt");

            rptDoc.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rptDoc;
        }
    }
}
