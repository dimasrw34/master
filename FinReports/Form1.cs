using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace FinReports
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            //reportViewer1.ProcessingMode = ProcessingMode.Local;

            //LocalReport localReport = reportViewer1.LocalReport;

            //localReport.ReportPath = "..\\..\\Report1.rdlc";

            //DataSet dataset = new DataSet();


            //////////////// // Get the sales order data  
            //GetDataUnitsForReport(ref dataset);




            //////////////// // Create a report data source for the sales order data  
            //ReportDataSource dsSalesOrder = new ReportDataSource();
            //dsSalesOrder.Name = "Unit";
            //dsSalesOrder.Value = dataset.Tables[0];

            //localReport.DataSources.Add(dsSalesOrder);


            this.reportViewer1.RefreshReport();
        }






        public void GetDataUnitsForReport( ref DataSet dsUnits)
        {
            string stringSQL = "SELECT UnitsID,UnitsName, SUnitsName FROM dicUnits";

            SqlConnection connection = new
           SqlConnection("Data Source=DEVCOMP; " +
                         "Initial Catalog=DEVBASE; " +
                         "Integrated Security=SSPI");

            SqlCommand command =
                new SqlCommand(stringSQL, connection);

           

            SqlDataAdapter salesOrderAdapter = new
                SqlDataAdapter(command);

            salesOrderAdapter.Fill(dsUnits);

        }
    }
}
