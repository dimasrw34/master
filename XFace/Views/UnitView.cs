using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace XFace.Views
{
    public partial class UnitView :   MetroFramework.Forms.MetroForm

    {
        public event EventHandler ButtonOkClicked = null;

        public UnitView()
        {
            InitializeComponent();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbUnitName_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ButtonOkClicked.Invoke(sender,e);
        }

        public string TextBoxUnitName
        {
            get { return this.tbUnitName.Text; }
            set { this.tbUnitName.Text = value; }
        }
        
        public string TextBoxUnitShortName
        {
            get { return this.tbUnitShortName.Text; }
            set { this.tbUnitShortName.Text = value; }
        }

        public string Caption
        {
            set { this.lblCaption.Text = value; }
        }

    }
}
