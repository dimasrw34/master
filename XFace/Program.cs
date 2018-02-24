using System;
using System.Windows.Forms;
using XFace.Presentors;
using XFace.Views;


namespace XFace
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MetroViewMain());
        
            var presentor = new PresentorMain(new MetroViewMain());
            presentor.ShowView();
            //Application.Run();
        }
    }
}
