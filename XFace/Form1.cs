using System.Collections.Generic;
using System.Windows.Forms;
using Z80NavBarControl.Z80NavBar;
using Z80NavBarControl.Z80NavBar.Themes;
using MetroFramework.Forms;
using XFace.PanelBuilders;

namespace XFace
{
    public partial class Form1 : MetroForm
    {
        private NavBarItem nvBarItem = new NavBarItem();
        AbsrtactPanelBuilder absrtactBuilder;

        public Form1()
        {
            InitializeComponent();

            List<NavBarItem> demoItemsChild1 = new List<NavBarItem>
            {
                new NavBarItem {ID = 500, ParentID = 5,Text = "Справочник 1",ToolTip = "Справочник номер один"},
                new NavBarItem {ID = 501,ParentID = 5, Text = "Справочник 2"},
                new NavBarItem {ID = 502,ParentID = 5,Text = "Справочник 3"}
            };

            List<NavBarItem> demoItemsChild2 = new List<NavBarItem>
            {
                new NavBarItem {ID = 100, ParentID = 1,Text = "Бюджеты"},
                new NavBarItem {ID = 101,ParentID = 1, Text = "Структура"},
                new NavBarItem {ID = 102,ParentID = 1,Text = "ЦФО"}
            };


            List<NavBarItem> demoItems = new List<NavBarItem>
            {
                new NavBarItem {ID = 1, Text = "Регламент", Childs = demoItemsChild2},
                new NavBarItem {ID = 2, Text = "Исполение"},
                new NavBarItem {ID = 3, Text = "Отчеты"},
                new NavBarItem {ID = 4, Text = "Сервис"},
                new NavBarItem {ID = 5, Text = "Справочники",Childs = demoItemsChild1}
            };

          
           
            z80_Navigation1.Initialize(demoItems, new ThemeSelector(Z80NavBarControl.Z80NavBar.Themes.Theme.RoyalBlue).CurrentTheme);
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void z80_Navigation1_SelectedItem(NavBarItem item)
        {
            if (item.ID == 501)
            {

            MessageBox.Show("", item.Text, MessageBoxButtons.OK);
        }

    }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            //TabPage tb =  metroTabControl1.TabPages[2];
            //metroTabControl1.TabPages.Remove(metroTabControl1.TabPages[2]);
            //metroTabControl1.TabPages.Add(tb);


         //  absrtactBuilder = new BuiderPanelAndOneGrid();

           // this.tabPage4.Controls.Add(absrtactBuilder.BuildMetroPanel());
            
            metroButton4.Hide();
        }

        private void metroButton1_Click(object sender, System.EventArgs e)
        {
            absrtactBuilder = new BuiderPanelAndOneGrid();

            this.tabPage4.Controls.Add(absrtactBuilder.BuildMetroPanel());
            absrtactBuilder.AddColums(4);
            metroButton4.Select();
        }

        private void tabPage1_Click(object sender, System.EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton3_Click(object sender, System.EventArgs e)
        {
           
            absrtactBuilder.Dispose();
            absrtactBuilder = null;
            metroButton4.Select();
        }
    }
    
}
