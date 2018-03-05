namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.enterpriseReportManagerProxy1 = new CrystalDecisions.Shared.EnterpriseReportManagerProxy();
            this.remoteReportProxyBase1 = new CrystalDecisions.Shared.RemoteReportProxyBase();
            this.serverFileReport1 = new CrystalDecisions.Shared.ServerFileReport();
            this.SuspendLayout();
            // 
            // enterpriseReportManagerProxy1
            // 
            this.enterpriseReportManagerProxy1.Credentials = null;
            this.enterpriseReportManagerProxy1.Url = "http://localhost/websamples/EnterpriseReportManagerProxy.asmx";
            this.enterpriseReportManagerProxy1.UseDefaultCredentials = false;
            // 
            // remoteReportProxyBase1
            // 
            this.remoteReportProxyBase1.Credentials = null;
            this.remoteReportProxyBase1.ReportServiceVersionHeaderValue = null;
            this.remoteReportProxyBase1.Url = "http://localhost/websamples/Chart_src_genproxy.asmx";
            this.remoteReportProxyBase1.UseDefaultCredentials = false;
            // 
            // serverFileReport1
            // 
            this.serverFileReport1.ObjectType = CrystalDecisions.Shared.EnumServerFileType.INVALID;
            this.serverFileReport1.ReportPath = "";
            this.serverFileReport1.ReportSource = null;
            this.serverFileReport1.WebServiceUrl = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 636);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Shared.EnterpriseReportManagerProxy enterpriseReportManagerProxy1;
        private CrystalDecisions.Shared.RemoteReportProxyBase remoteReportProxyBase1;
        private CrystalDecisions.Shared.ServerFileReport serverFileReport1;
    }
}

