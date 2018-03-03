using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing.Text;
using System.Windows.Forms;
using Z80NavBarControl.Z80NavBar;
using Z80NavBarControl.Z80NavBar.Themes;
using MetroFramework.Forms;
using XFace.PanelBuilders;
using BusinessLayer;
using DataLayer.Data;
using MetroFramework.Controls;
using XFace.Presentors;
using Z80NavBarControl;

namespace XFace.Views
{
    public partial class MetroViewMain : MetroForm
    {
        private NavBarItem nvBarItem = new NavBarItem();

        //событие которое уведомит главный презентер, что нажали кнопки
        public event EventHandler AddButtonClicked = null;
        public event EventHandler EditButtonClicked = null;
        public event EventHandler DeleteButtonClicked = null;
      


        public MetroViewMain()
        {
            InitializeComponent();

            List<NavBarItem> demoItemsChild1 = new List<NavBarItem>
            {
                new NavBarItem {ID = 500, ParentID = 5, Text = "Единицы измерения", ToolTip = "Справочник единиц измерения"},
                new NavBarItem {ID = 501, ParentID = 5, Text = "Справочник 2"},
                new NavBarItem {ID = 502, ParentID = 5, Text = "Справочник 3"}
            };

            List<NavBarItem> demoItemsChild2 = new List<NavBarItem>
            {
                new NavBarItem {ID = 100, ParentID = 1, Text = "Бюджеты"},
                new NavBarItem {ID = 101, ParentID = 1, Text = "Структура"},
                new NavBarItem {ID = 102, ParentID = 1, Text = "ЦФО"}
            };


            List<NavBarItem> demoItems = new List<NavBarItem>
            {
                new NavBarItem {ID = 1, Text = "Регламент", Childs = demoItemsChild2},
                new NavBarItem {ID = 2, Text = "Исполение"},
                new NavBarItem {ID = 3, Text = "Отчеты"},
                new NavBarItem {ID = 4, Text = "Сервис"},
                new NavBarItem {ID = 5, Text = "Справочники", Childs = demoItemsChild1}
            };



            z80_Navigation1.Initialize(demoItems,
                new ThemeSelector(Z80NavBarControl.Z80NavBar.Themes.Theme.RoyalBlue).CurrentTheme);

            this.metroTabControl.TabPages.Remove(this.tabPage1);
            this.metroTabControl.TabPages.Remove(this.tabPage2);
            this.metroTabControl.TabPages.Remove(this.tabPage3);
            this.metroTabControl.TabPages.Remove(this.tabPage4);

           
        }
 
        
        public TabPage TabPage_1
        {
            get { return tabPage1; }
            
        }

        public TabPage TabPage_2
        {
            get { return tabPage2; }

        }

        public TabPage TabPage_3
        {
            get { return tabPage3; }

        }

        public TabPage TabPage_4
        {
            get { return tabPage4; }

        }

        public MetroTabControl MainMetroTabControl
        {
            get { return metroTabControl; }
        }

        public Z80_Navigation Z80Navigation
        {
            get { return this.z80_Navigation1; }
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            AddButtonClicked.Invoke(sender,e);   
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            EditButtonClicked.Invoke(sender,e);
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            DeleteButtonClicked.Invoke(sender,e);
        }
    }
    
}
