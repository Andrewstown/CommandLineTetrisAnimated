using System;
using static System.Console;

namespace Blocks
{
    public class TPiece : Tetrimino
    {
        protected override int Width => 3;
        protected override char[] Body => new char[] { ' ', '▉', ' ', '▉', '▉', '▉', ' ', ' ', ' ' };

        // public override void Reset()
        // {
        //     Body = new char[] { ' ', '▉', ' ', '▉', '▉', '▉', ' ', ' ', ' ' };
        // }
    }
}
