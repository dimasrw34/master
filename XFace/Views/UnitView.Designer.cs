namespace XFace.Views
{
    partial class UnitView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOK = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.tbUnitName = new MetroFramework.Controls.MetroTextBox();
            this.lblCaption = new MetroFramework.Controls.MetroLabel();
            this.tbUnitShortName = new MetroFramework.Controls.MetroTextBox();
            this.lblUnitName = new MetroFramework.Controls.MetroLabel();
            this.lblUnitShortName = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(598, 108);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(118, 24);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "ОК";
            this.btnOK.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnOK.UseSelectable = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(719, 108);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 24);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbUnitName
            // 
            // 
            // 
            // 
            this.tbUnitName.CustomButton.Image = null;
            this.tbUnitName.CustomButton.Location = new System.Drawing.Point(655, 1);
            this.tbUnitName.CustomButton.Name = "";
            this.tbUnitName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tbUnitName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbUnitName.CustomButton.TabIndex = 1;
            this.tbUnitName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbUnitName.CustomButton.UseSelectable = true;
            this.tbUnitName.CustomButton.Visible = false;
            this.tbUnitName.Lines = new string[0];
            this.tbUnitName.Location = new System.Drawing.Point(156, 52);
            this.tbUnitName.MaxLength = 32767;
            this.tbUnitName.Name = "tbUnitName";
            this.tbUnitName.PasswordChar = '\0';
            this.tbUnitName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbUnitName.SelectedText = "";
            this.tbUnitName.SelectionLength = 0;
            this.tbUnitName.SelectionStart = 0;
            this.tbUnitName.ShortcutsEnabled = true;
            this.tbUnitName.Size = new System.Drawing.Size(679, 25);
            this.tbUnitName.TabIndex = 0;
            this.tbUnitName.UseSelectable = true;
            this.tbUnitName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbUnitName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbUnitName.Click += new System.EventHandler(this.tbUnitName_Click);
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblCaption.Location = new System.Drawing.Point(10, 16);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(230, 20);
            this.lblCaption.TabIndex = 3;
            this.lblCaption.Text = "Добавить единицу измерения";
            this.lblCaption.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tbUnitShortName
            // 
            // 
            // 
            // 
            this.tbUnitShortName.CustomButton.Image = null;
            this.tbUnitShortName.CustomButton.Location = new System.Drawing.Point(259, 1);
            this.tbUnitShortName.CustomButton.Name = "";
            this.tbUnitShortName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tbUnitShortName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbUnitShortName.CustomButton.TabIndex = 1;
            this.tbUnitShortName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbUnitShortName.CustomButton.UseSelectable = true;
            this.tbUnitShortName.CustomButton.Visible = false;
            this.tbUnitShortName.Lines = new string[0];
            this.tbUnitShortName.Location = new System.Drawing.Point(156, 83);
            this.tbUnitShortName.MaxLength = 32767;
            this.tbUnitShortName.Name = "tbUnitShortName";
            this.tbUnitShortName.PasswordChar = '\0';
            this.tbUnitShortName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbUnitShortName.SelectedText = "";
            this.tbUnitShortName.SelectionLength = 0;
            this.tbUnitShortName.SelectionStart = 0;
            this.tbUnitShortName.ShortcutsEnabled = true;
            this.tbUnitShortName.Size = new System.Drawing.Size(283, 25);
            this.tbUnitShortName.TabIndex = 1;
            this.tbUnitShortName.UseSelectable = true;
            this.tbUnitShortName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbUnitShortName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblUnitName
            // 
            this.lblUnitName.AutoSize = true;
            this.lblUnitName.Location = new System.Drawing.Point(6, 54);
            this.lblUnitName.Name = "lblUnitName";
            this.lblUnitName.Size = new System.Drawing.Size(113, 20);
            this.lblUnitName.TabIndex = 5;
            this.lblUnitName.Text = "Наименование: ";
            this.lblUnitName.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblUnitShortName
            // 
            this.lblUnitShortName.AutoSize = true;
            this.lblUnitShortName.Location = new System.Drawing.Point(17, 84);
            this.lblUnitShortName.Name = "lblUnitShortName";
            this.lblUnitShortName.Size = new System.Drawing.Size(99, 20);
            this.lblUnitShortName.TabIndex = 6;
            this.lblUnitShortName.Text = "Сокращение: ";
            this.lblUnitShortName.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // UnitView
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(849, 149);
            this.ControlBox = false;
            this.Controls.Add(this.lblUnitShortName);
            this.Controls.Add(this.lblUnitName);
            this.Controls.Add(this.tbUnitShortName);
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.tbUnitName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.DisplayHeader = false;
            this.Name = "UnitView";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnOK;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroTextBox tbUnitName;
        private MetroFramework.Controls.MetroLabel lblCaption;
        private MetroFramework.Controls.MetroTextBox tbUnitShortName;
        private MetroFramework.Controls.MetroLabel lblUnitName;
        private MetroFramework.Controls.MetroLabel lblUnitShortName;
    }
}