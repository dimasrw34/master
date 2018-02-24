
using System;
using MetroFramework.Controls;

namespace XFace.PanelBuilders
{
    abstract class AbsrtactPanelBuilder
    {
   
        public abstract MetroGrid MetroCurrGrid { get; }
        public abstract void AddColums(int columns);
        public abstract void Dispose();

        // строим панель и грид
        public abstract  void BuildMetroPanel();

        //возвращаем готовую панель с гридом
        public abstract MetroPanel GetMetroPanel();

   


    }
}
