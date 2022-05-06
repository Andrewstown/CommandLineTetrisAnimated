using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Rotation
    {
        static int Width = 4;
        //Work for ANY WIDTH!

        public int Turns = 1;

        public int[] Matrix = new int[(Width*Width)];
        //Obviously it's not a Matrix, just a name to make sense

        static void Main()
        {
            Rotation Game = new Rotation();
            Game.Start();
        }

        public void Start()
        {
            //Adding values 1-16 to the Matrix
;           for (int i = 0; i < (Width*Width); i++)
            {
                Matrix[i] = i+1;
            }
            Show();
            //Turns as many times as Turns is
            for (int i = 0; i < Turns; i++)
            {
                Calculate();
            }
            Show();
        }

        public void Calculate()
        {
            //THIS GOES TO THE LEFT!
            int[] Temp = new int[(Width*Width)];
            //Move the current Matrix places to the new places in a Temp Array
            for (int i = 0; i < (Width*Width); i++)
            {
                Temp[i] = Matrix[i + ((-1 + Width) + (((-Width - 1) * (i / Width)) + ((Width - 1) * (i % Width))))];
            }
            //Unless there is a better way, set the values of Matrix to the new rotated values of Temp
            for (int i = 0; i < (Width * Width); i++)
            {
                Matrix[i] = Temp[i];
            }
            Console.WriteLine();
        }

        public void Show()
        {
            //Displays the Matrix in a squared format
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Width; y++)
                {
                    Console.Write(Matrix[(x * Width) + y]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
        
