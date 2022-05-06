using System;
using static System.Console;

namespace KeyListener
{
    public class TPiece
    {
        char[] Body = new char[] { ' ', '▉', ' ', '▉', '▉', '▉', ' ', ' ', ' ' };
        const int Width = 3;
        const int xStart = 2;
        const int yStart = 2;

        public void Reset()
        {
            Body = new char[] { ' ', '▉', ' ', '▉', '▉', '▉', ' ', ' ', ' ' };
        }

        public void Rotate(bool IsRight)
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

        public void DrawPiece()
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
