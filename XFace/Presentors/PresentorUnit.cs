using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using XFace.PanelBuilders;
using DataLayer.Data;
using BusinessLayer;

namespace XFace.Presentors
{
    class PresentorUnit
    {

        private AbsrtactPanelBuilder absrtactPanelBuilder;
        private DirectorPanelGrid directorPanelGrid;

        private UnitDataInterrop udi;
        private ObservableCollection<Unit> ocUnits;

        private MetroPanel metroPanel;
        private DataGridViewColumn dgvc;
        private MetroGrid metroGrid;

        private System.Windows.Forms.TabPage tabPage;


        public PresentorUnit()
        {
            absrtactPanelBuilder = new BuiderPanelAndOneGrid();
            directorPanelGrid= new DirectorPanelGrid(absrtactPanelBuilder);
        }

        public void AddPanelOnTab(System.Windows.Forms.TabPage _metroTabPage)
        {
            directorPanelGrid.Construct();
            metroPanel = absrtactPanelBuilder.GetMetroPanel();
            tabPage = _metroTabPage;
            tabPage.Text = "Спарвочник единиц измерений";
            tabPage.Controls.Add(metroPanel);
            metroGrid=absrtactPanelBuilder.MetroCurrGrid;
            AddColumns();
        }

        private void AddColumns()
        {
          
            metroGrid.Columns.Add("", "");
            metroGrid.Columns.Add("", "");
            metroGrid.Columns.Add("", "");

            metroGrid.Columns[0].Name = "Column_0";
            metroGrid.Columns[0].HeaderText = "UnitID";
            metroGrid.Columns[0].ReadOnly = true;

            metroGrid.Columns[1].Name = "Column_1"; 
            metroGrid.Columns[1].HeaderText = "Наименование";
            metroGrid.Columns[1].ReadOnly = true;

            metroGrid.Columns[2].Name = "Column_2";
            metroGrid.Columns[2].HeaderText = "Сокращенное наименование";
            metroGrid.Columns[2].ReadOnly = true;

            GetData();
        }

        private void GetData()
        {
            udi = new UnitDataInterrop();
            ocUnits = udi.GetUnits();

            int i = 0;
            foreach (Unit un in ocUnits)
            {

                metroGrid.Rows.Add();
                metroGrid.Rows[i].Cells[0].Value = un.Id;
                metroGrid.Rows[i].Cells[1].Value = un.FullName;
                metroGrid.Rows[i].Cells[2].Value = un.ShortName;
                i += 1;
            }
        }





    }
}
