using System;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;
using XFace.Views;
using Z80NavBarControl;
using Z80NavBarControl.Z80NavBar;

namespace XFace.Presentors
{
    class PresentorMain
    {
        private readonly MetroViewMain _view;
        private PresentorUnit presentorUnit;
        private readonly ApplicationContext _context;
        private Z80_Navigation z80;

        public event EventHandler AddButtomHandlerMPresentor = null;
        public event EventHandler EditButtomHandlerMPresentor = null;
        public event EventHandler DeleteButtomHandlerMPresentor = null;

        public event EventHandler ExcelButtomHandlerMPresentor = null;

        public PresentorMain(MetroViewMain view)
        {
            this._view = view;
            _context = new ApplicationContext();
            z80 = _view.Z80Navigation;
            z80.SelectedItem += NavigationBarSelectedItem;
            //определяем события кнопок
            _view.AddButtonClicked+=AddButtonClickedMainPresentor;
            _view.EditButtonClicked+=EditButtonClickedMainPresentor;
            _view.DeleteButtonClicked += DeleteButtonClickedMainPresentor;

            _view.ExcelButtonClicked += ExcelButtonClickedMainPresentor;
            ////////////////////////////////////////////////////////////////////////////////////
            

        }

        public void ShowView()
        {
            _context.MainForm = _view;
            Application.Run(_view);
        }

        private void NavigationBarSelectedItem(NavBarItem Item)
        {
            RemoveAllTabPages();
            DropAllEvents();
            switch (Item.ID)
            {

                case 500:
                {
                
                    _view.MainMetroTabControl.TabPages.Add(_view.TabPage_4);
                    presentorUnit = new PresentorUnit();

                    presentorUnit.AddPanelOnTab(_view.TabPage_4);

                    this.AddButtomHandlerMPresentor += presentorUnit.ShowUnitView;
                    this.EditButtomHandlerMPresentor += presentorUnit.ShowUnitView;
                    this.DeleteButtomHandlerMPresentor += presentorUnit.DelCell;

                    this.ExcelButtomHandlerMPresentor += presentorUnit.ExcelLoad;


                    break;
                }
        }
        }

        private void RemoveAllTabPages()
        {
            foreach (TabPage tb in _view.MainMetroTabControl.TabPages)
            {
                _view.MainMetroTabControl.TabPages.Remove(tb);
            }
        }

        private void AddButtonClickedMainPresentor(object sender, System.EventArgs e)
        {
            AddButtomHandlerMPresentor?.Invoke(sender, e);
        }

        private void EditButtonClickedMainPresentor(object sender, System.EventArgs e)
        {
            EditButtomHandlerMPresentor?.Invoke(sender, e);
        }

        private void DeleteButtonClickedMainPresentor(object sender, System.EventArgs e)
        {
            DeleteButtomHandlerMPresentor?.Invoke(sender,e);
        }

        private void ExcelButtonClickedMainPresentor(object sender, EventArgs e)
        {
            ExcelButtomHandlerMPresentor?.Invoke(sender, e);
        }

        private void DropAllEvents()
        {
            if (AddButtomHandlerMPresentor!=null)
                this.AddButtomHandlerMPresentor -= presentorUnit.ShowUnitView;
            if (EditButtomHandlerMPresentor != null)
                this.EditButtomHandlerMPresentor -= presentorUnit.ShowUnitView;
            if (DeleteButtomHandlerMPresentor != null)
                this.DeleteButtomHandlerMPresentor -= presentorUnit.DelCell;
            if (ExcelButtomHandlerMPresentor != null)
                this.ExcelButtomHandlerMPresentor -= presentorUnit.ExcelLoad;
            if (presentorUnit != null)
                presentorUnit = null;
        }

    }
}
