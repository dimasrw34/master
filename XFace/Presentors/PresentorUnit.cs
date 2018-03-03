using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using XFace.PanelBuilders;
using DataLayer.Data;
using BusinessLayer;
using XFace.Views;

namespace XFace.Presentors
{
    class PresentorUnit
    {
        private UnitView _viewUnit;


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

        //событие по изменению данных в коллекции
        public void CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            //событие править
            if (e.Action == NotifyCollectionChangedAction.Replace)
            {
                foreach (Unit unit in e.OldItems)
                {
                    //обновляем в БД                         
                    udi.UpdateUnit(unit);
                }
            }
            //событие удалить
            else if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (Unit unit in e.NewItems)
                {
                    metroGrid.Rows[metroGrid.RowCount - 1].Cells[0].Value = udi.AddUnit(unit);
                }
            }
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
            //metroGrid.Columns[0].Visible = false;


            metroGrid.Columns[1].Name = "Column_1"; 
            metroGrid.Columns[1].HeaderText = "Наименование";
            metroGrid.Columns[1].Width = 300;
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

            ocUnits.CollectionChanged += CollectionChanged;
        }

        public void ShowUnitView(object sender, System.EventArgs e)
        {
   
            _viewUnit = new UnitView();

            if (sender.GetType().GetProperties()[39].GetValue(sender, null).ToString() == "btnAdd")
            {
                _viewUnit.ButtonOkClicked += new EventHandler(AddCell);
            }
            else if (sender.GetType().GetProperties()[39].GetValue(sender, null).ToString()=="btnEdit")
            {
                _viewUnit.Caption = "Редактировать единицу измерения";
                _viewUnit.TextBoxUnitName = metroGrid.Rows[metroGrid.CurrentCell.RowIndex].Cells[1].Value.ToString();
                _viewUnit.TextBoxUnitShortName = metroGrid.Rows[metroGrid.CurrentCell.RowIndex].Cells[2].Value.ToString();

                _viewUnit.ButtonOkClicked += new EventHandler(EditCurrentCell);
            }


            _viewUnit.ShowDialog();
        }


        //сохраняет редактирование данных текущей строки
        private void EditCurrentCell(object sender, EventArgs e)
        {
           
            if (metroGrid.Rows[metroGrid.CurrentCell.RowIndex].Cells[1].Value.ToString() != _viewUnit.TextBoxUnitName |
                 metroGrid.Rows[metroGrid.CurrentCell.RowIndex].Cells[2].Value.ToString() != _viewUnit.TextBoxUnitShortName)
            {
                foreach (Unit unit in ocUnits)
                {
                    if (unit.Id == (int) metroGrid.Rows[metroGrid.CurrentCell.RowIndex].Cells[0].Value)
                    {
                        //ocUnits.RemoveAt(ocUnits.IndexOf(unit));
                        unit.Id = (int) metroGrid.Rows[metroGrid.CurrentCell.RowIndex].Cells[0].Value;
                        unit.FullName = _viewUnit.TextBoxUnitName;
                        unit.ShortName = _viewUnit.TextBoxUnitShortName;
                        //ocUnits.Add(unit);
                        ocUnits[ocUnits.IndexOf(unit)] = unit;
                        metroGrid.Rows[metroGrid.CurrentCell.RowIndex].Cells[1].Value = unit.FullName;
                        metroGrid.Rows[metroGrid.CurrentCell.RowIndex].Cells[2].Value = unit.ShortName;
                        break;
                    }
                }
            }
          
            _viewUnit.ButtonOkClicked -= new EventHandler(EditCurrentCell);
            _viewUnit.Close();
        }

        //сохраняем новую запись в бд
        private void AddCell(object sender, EventArgs e)
        {
            metroGrid.Rows.Add();
            Unit unit = new Unit();
            int newRowIndex = metroGrid.RowCount-1;

            metroGrid.Rows[newRowIndex].Cells[1].Value = _viewUnit.TextBoxUnitName;
            metroGrid.Rows[newRowIndex].Cells[2].Value = _viewUnit.TextBoxUnitShortName;

            unit.FullName = _viewUnit.TextBoxUnitName;
            unit.ShortName = _viewUnit.TextBoxUnitShortName;
            ocUnits.Add(unit);
        
            _viewUnit.ButtonOkClicked -= new EventHandler(AddCell);
            _viewUnit.Close();
        }
    }
}
