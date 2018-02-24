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


        public PresentorMain(MetroViewMain view)
        {
            this._view = view;
            _context = new ApplicationContext();
            z80 = _view.Z80Navigation;
            z80.SelectedItem += new Z80NavBarControl.Z80_Navigation.SelectedItemEventHandler(NavigationBarSelectedItem);

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


    }
}
