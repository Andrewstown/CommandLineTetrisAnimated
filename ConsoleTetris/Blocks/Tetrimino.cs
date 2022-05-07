using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Blocks
{
    public abstract class Tetrimino
    {
        protected abstract int Width { get; }
        protected abstract char[] Body { get; }

        //public abstract void Reset();

        public void RotateCW()
        {
            char[] Temp = new char[(Width * Width)];
            for (int i = 0; i < (Width * Width); i++)
            {
                Temp[i] = Body[i + (((Width * Width) - Width) + (((-Width + 1) * (i / Width)) + ((-Width - 1) * (i % Width))))];
            }
            for (int i = 0; i < (Width * Width); i++)
            {
                Body[i] = Temp[i];
            }
        }

        public void RotateCCW()
        {
            char[] Temp = new char[(Width * Width)];
            for (int i = 0; i < (Width * Width); i++)
            {
                Temp[i] = Body[i + ((-1 + Width) + (((-Width - 1) * (i / Width)) + ((Width - 1) * (i % Width))))];
            }
            for (int i = 0; i < (Width * Width); i++)
            {
                Body[i] = Temp[i];
            }
        }

        public void DrawPiece(int xStart, int yStart)
        {
            for (int y = 0; y < Width; y++)
            {
                SetCursorPosition(xStart, yStart + y);
                for (int x = 0; x < Width; x++)
                {
                    Write(Body[x+(y*Width)]+""+Body[x + (y * Width)]);
                }
            }
        }
    }
}
