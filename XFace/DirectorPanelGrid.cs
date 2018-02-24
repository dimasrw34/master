using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XFace.PanelBuilders;

namespace XFace
{
    class DirectorPanelGrid
    {
        private readonly AbsrtactPanelBuilder _absrtactPanelBuilder;


        public DirectorPanelGrid(AbsrtactPanelBuilder absrtactPanelBuilder)
        {
            this._absrtactPanelBuilder = absrtactPanelBuilder;
        }

        public void Construct()
        {
           _absrtactPanelBuilder.BuildMetroPanel();

        }
    }
}
