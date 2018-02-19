
using System;
using MetroFramework.Controls;

namespace XFace.PanelBuilders
{
    abstract class AbsrtactPanelBuilder
    {
        //public abstract void BuildCaption();
        //public abstract void BuildGrid();
        public abstract void AddColums(int columns);
        public abstract void Dispose();
        public abstract MetroPanel BuildMetroPanel();
    }
}
