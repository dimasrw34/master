using System;
using System.Windows.Forms;

namespace ReportsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DEVBASEDataSet.dicUnits". При необходимости она может быть перемещена или удалена.
            this.dicUnitsTableAdapter.Fill(this.DEVBASEDataSet.dicUnits);



            this.reportViewer2.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportForm rp = new ReportForm();
            rp.Show();

        }
    }
}