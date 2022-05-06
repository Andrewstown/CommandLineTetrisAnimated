using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyListener
{
    public abstract class Tetrimino
    {
        public char[] Body;
        public static int Width;

        public abstract void Reset();

        public abstract void Rotate(bool IsRight);

        public abstract void DrawPiece(int xStart, int yStart);
    }
}
