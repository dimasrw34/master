using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Repos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //         this.reportViewer1.RefreshReport();
         

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
    
            using (DEVBASEEntities dn = new DEVBASEEntities())
            {

                reportViewer1.ProcessingMode = ProcessingMode.Local;
              
                LocalReport lReport = new LocalReport();
                lReport.ReportPath = "Repos.UnitsReport.rdls";

                MessageBox.Show(lReport.ReportPath);
                              
                dicUnitsBindingSource.DataSource = dn.dicUnits.ToList();
                

                ReportDataSource _rds = new ReportDataSource("dicUnits", dicUnitsBindingSource);
                 //this.reportViewer1.LocalReport.DataSources.Clear();
                lReport.DataSources.Add(_rds);


               this.reportViewer1.LocalReport.ReportPath = lReport.ReportPath;
                this.reportViewer1.RefreshReport();
            }
        }

        private void dicUnitsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
