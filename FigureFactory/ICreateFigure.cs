using System;
using System.Collections.Generic;
using System.Text;

namespace FigureFactory
{
    static class ICreateFigure
    {
        public static IFigure CreateFigure(string Choice)
        {
            if (Choice == "I")
                return new Block.IBlock();
            if (Choice == "O")
                return new Block.OBlock_();    
            if (Choice == "S")
                return new Block.SBlock();
            if (Choice == "J")
                return new Block.JBlock();
            throw new IndexOutOfRangeException(nameof(Choice));
        }
    }
}
