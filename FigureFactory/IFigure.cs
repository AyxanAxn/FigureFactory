using System;
using System.Collections.Generic;
using System.Text;

namespace FigureFactory
{
    abstract class IFigure
    {
        public abstract string Name { get; set; }
        public abstract RGB RGB { get; set; }
        public abstract byte[][] Figure { get; set; }

        public void Show()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Figure[i][j]==0)
                    {
                        Console.Write(" ");
                    }
                    if (Figure[i][j] != 0)
                    {
                        Console.Write(Figure[i][j]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
