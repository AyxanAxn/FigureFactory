using System;
using System.Collections.Generic;
using System.Text;

namespace FigureFactory.Block
{
    class IBlock : IFigure
    {
        public override RGB RGB { get; set; }
        public override byte[][] Figure { get; set; }
        public override string Name { get; set; }

        public IBlock()
        {
            Name = "I block";
            Figure = new byte[][] {
            new byte[]{1,1,1,1},
            new byte[]{0,0,0,0},
            new byte[]{0,0,0,0},
            new byte[]{0,0,0,0},
            };
        }

    }
}
