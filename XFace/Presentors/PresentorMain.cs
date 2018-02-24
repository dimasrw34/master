using System.Windows.Forms;
using XFace.Views;

namespace XFace.Presentors
{
    class PresentorMain
    {
        private readonly MetroViewMain _view;
        private readonly ApplicationContext _context;

        public PresentorMain(MetroViewMain view)
        {
            this._view = view;
            _context = new ApplicationContext();
        }

        public void ShowView()
        {
            _context.MainForm = _view;
            Application.Run(_view);
        }
    }
}
