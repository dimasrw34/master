namespace ReportsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components;

        /// <summary>
        /// Очистка всех занятых ресурсов.
        /// </summary>
        /// <param name="disposing">Значение true, если следует освободить управляемые ресурсы, в противном случае значение false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, формируемый конструктором Windows Form Designer 

        /// <summary>
        /// Обязательный метод для поддержки конструктора Designer, не изменяйте
        /// его содержимое в редакторе кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dicUnitsBindingSource = new System.Windows.Forms.BindingSource(this.components);

            this.DEVBASEDataSet = new ReportsApplication1.DEVBASEDataSet();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dicUnitsTableAdapter = new ReportsApplication1.DEVBASEDataSetTableAdapters.dicUnitsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dicUnitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEVBASEDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dicUnitsBindingSource
            // 
            this.dicUnitsBindingSource.DataMember = "dicUnits";
            this.dicUnitsBindingSource.DataSource = this.DEVBASEDataSet;
            // 
            // DEVBASEDataSet
            // 
            this.DEVBASEDataSet.DataSetName = "DEVBASEDataSet";
            this.DEVBASEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer2
            // 
            this.reportViewer2.KeepSessionAlive = false;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dicUnitsBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Report1.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(12, 12);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(602, 307);
            this.reportViewer2.TabIndex = 0;
            // 
            // dicUnitsTableAdapter
            // 
            this.dicUnitsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(606, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 475);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dicUnitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEVBASEDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private DEVBASEDataSet DEVBASEDataSet;
        private System.Windows.Forms.BindingSource dicUnitsBindingSource;
        private DEVBASEDataSetTableAdapters.dicUnitsTableAdapter dicUnitsTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}

