
using System;
using MetroFramework.Controls;

namespace XFace.PanelBuilders
{
    abstract class AbsrtactPanelBuilder
    {
   
        public abstract MetroGrid MetroCurrGrid { get; }
        public abstract void AddColums(int columns);
        public abstract void Dispose();
        public abstract MetroPanel BuildMetroPanel();
    }
}
