using System;
using static System.Console;

namespace KeyListener
{
    public class T_Piece : Tetrimino
    {
        //protected override char[] Body { get; set; } = new char[] { ' ', '▉', ' ', '▉', '▉', '▉', ' ', ' ', ' ' };
        protected override char[] Body { get; set; } = new char[] { ' ', ' ', ' ', ' ', '▉', '▉', '▉', '▉', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        // protected override char[] Body => new char[] { '▉', ' ', ' ', '▉', '▉', '▉', ' ', ' ', ' ' };
        // protected override char[] Body { get; set; } = new char[] { ' ', ' ', '▉', '▉', '▉', '▉', ' ', ' ', ' ' };
        // protected override char[] Body { get; set; } = new char[] { '▉', '▉', '▉', '▉' };
        // protected override char[] Body { get; set; } = new char[] { '▉', '▉', ' ', ' ', '▉', '▉', ' ', ' ', ' ' };
        // protected override char[] Body { get; set; } = new char[] { ' ', '▉', '▉', '▉', '▉', ' ', ' ', ' ', ' ' };

    
        public override void Rotate(bool IsRight)
        {
            char[] Temp = new char[(Width * Width)];
            for (int i = 0; i < (Width * Width); i++)
            {
                try
                {
                    Temp[i] = IsRight ? Body[i + (((Width * Width) - Width) + (((-Width + 1) * (i / Width)) + ((-Width - 1) * (i % Width))))] : Body[i + ((-1 + Width) + (((-Width - 1) * (i / Width)) + ((Width - 1) * (i % Width))))];
                }
                catch (Exception e)
                {
                    Console.WriteLine(IsRight);
                    Console.WriteLine(i);
                    Console.WriteLine(e.ToString());
                }
            }

            for (int i = 0; i < (Width * Width); i++)
            {
                Body[i] = Temp[i];
            }
        }

        public override void DrawPiece(int xStart, int yStart)
        {
            for (int y = 0; y < Width; y++)
            {
                SetCursorPosition(xStart, yStart + y);
                for (int x = 0; x < Width; x++)
                {
                    Console.Write(Body[x+(y*Width)]);
                }
            }
        }
    }
}
