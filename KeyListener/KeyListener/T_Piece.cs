using System;
using static System.Console;

namespace KeyListener
{
    public class T_Piece : Tetrimino
    {
        public T_Piece()
        {
            char[] Body = new char[] { ' ', '▉', ' ', '▉', '▉', '▉', ' ', ' ', ' ' };
            // I = { ' ', ' ', ' ', ' ', '▉', '▉', '▉', '▉', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' }
            // J = { '▉', ' ', ' ', '▉', '▉', '▉', ' ', ' ', ' ' }
            // L = { ' ', ' ', '▉', '▉', '▉', '▉', ' ', ' ', ' ' }
            // O = { '▉', '▉', '▉', '▉' }
            // Z = { '▉', '▉', ' ', ' ', '▉', '▉', ' ', ' ', ' ' }
            // S = { ' ', '▉', '▉', '▉', '▉', ' ', ' ', ' ', ' ' }
            int Width = 3;
        }
        
        public override void Reset()
        {
            Body = new char[] { ' ', '▉', ' ', '▉', '▉', '▉', ' ', ' ', ' ' };
        }

        public override void Rotate(bool IsRight)
        {
            char[] Temp = new char[(Width * Width)];
            for (int i = 0; i < (Width * Width); i++)
            {
                Temp[i] = IsRight ? Body[i + (((Width * Width) - Width) + (((-Width + 1) * (i / Width)) + ((-Width - 1) * (i % Width))))] : Body[i + ((-1 + Width) + (((-Width - 1) * (i / Width)) + ((Width - 1) * (i % Width))))];
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
                    Console.Write(Body[x+(y*Width)]+""+Body[x + (y * Width)]);
                }
            }
        }
    }
}
