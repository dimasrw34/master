using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportsApplication1
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }
    

        private DEVBASEDataSet DEVBASEDataSet;
        private DEVBASEDataSetTableAdapters.dicUnitsTableAdapter dicUnitsTableAdapter;

        private void ReportForm_Load(object sender, EventArgs e)
        {
        

            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();


            this.DEVBASEDataSet = new ReportsApplication1.DEVBASEDataSet();
            this.dicUnitsTableAdapter = new ReportsApplication1.DEVBASEDataSetTableAdapters.dicUnitsTableAdapter();
                          
            // 
            // DEVBASEDataSet
            // 
           // this.DEVBASEDataSet.DataSetName = "DEVBASEDataSet";
                      
            // 
            // reportViewer2
            reportDataSource1.Name = "DataSetReport";
            reportDataSource1.Value = DEVBASEDataSet.Tables[0];
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Report2.rdlc";
            
            // 
            // dicUnitsTableAdapter
            // 
            this.dicUnitsTableAdapter.ClearBeforeFill = true;

           // ((System.ComponentModel.ISupportInitialize)(this.DEVBASEDataSet)).EndInit();
          


            this.dicUnitsTableAdapter.Fill(this.DEVBASEDataSet.dicUnits);
            this.reportViewer.RefreshReport();
        }
    }
}
