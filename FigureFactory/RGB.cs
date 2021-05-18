using System;
using System.Collections.Generic;
using System.Text;

namespace FigureFactory
{
    struct RGB
    {
        public RGB(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }
        public byte Red { get; set; }
        public byte Green{ get; set; }
        public byte Blue { get; set; }
    }
}
