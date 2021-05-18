using System;
using System.Collections.Generic;
using System.Text;

namespace FigureFactory.Block
{
    class OBlock_ : IFigure
    {
        public override RGB RGB { get; set; }
        public override byte[][] Figure { get; set; }
        public override string Name { get; set; }

        public OBlock_()
        {
            Name = "O block";
            Figure = new byte[][] {
            new byte[]{0,1,1,0 },
            new byte[]{0,1,1,0 },
            new byte[]{0,0,0,0},
            new byte[]{0,0,0,0},
            };
        }

    }
}
