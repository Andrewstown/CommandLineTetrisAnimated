using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyListener
{
    public abstract class Tetrimino
    {
        protected abstract char[] Body { get; set; }
        public static int Width = 3;

        public abstract void Rotate(bool IsRight);

        public abstract void DrawPiece(int xStart, int yStart);
    }
}
