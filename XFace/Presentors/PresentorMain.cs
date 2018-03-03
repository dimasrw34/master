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

        public PresentorMain(MetroViewMain view)
        {
            this._view = view;
            _context = new ApplicationContext();
            z80 = _view.Z80Navigation;
            z80.SelectedItem += new Z80NavBarControl.Z80_Navigation.SelectedItemEventHandler(NavigationBarSelectedItem);
            //определяем события кнопок
            _view.AddButtonClicked+=new EventHandler(AddButtonClickedMainPresentor);
            _view.EditButtonClicked+=new EventHandler(EditButtonClickedMainPresentor);
            _view.DeleteButtonClicked += new EventHandler(DeleteButtonClickedMainPresentor);
        }

        public void ShowView()
        {
            _context.MainForm = _view;
            Application.Run(_view);
        }

        private void NavigationBarSelectedItem(NavBarItem Item)
        {
            RemoveAllTabPages();

            switch (Item.ID)
            {
               
                case 500:
                    _view.MainMetroTabControl.TabPages.Add(_view.TabPage_4);
                    presentorUnit = new PresentorUnit();
                   
                    presentorUnit.AddPanelOnTab(_view.TabPage_4);
                    this.AddButtomHandlerMPresentor += new EventHandler(presentorUnit.ShowUnitView);
                    this.EditButtomHandlerMPresentor+=new EventHandler(presentorUnit.ShowUnitView);

                    break;
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
            AddButtomHandlerMPresentor.Invoke(sender,e);
            
        }

        private void EditButtonClickedMainPresentor(object sender, System.EventArgs e)
        {
            EditButtomHandlerMPresentor.Invoke(sender,e);
        }

        private void DeleteButtonClickedMainPresentor(object sender, System.EventArgs e)
        {
            DeleteButtomHandlerMPresentor.Invoke(sender,e);
        }
    }
}
