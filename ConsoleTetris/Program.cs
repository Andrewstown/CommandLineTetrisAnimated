using System;
using System.Timers;
using static System.Console;
using Blocks;

namespace ConsoleTetris
{
    public class Program
    {
        static float Delay = 1000;
        static System.Timers.Timer Timer = new System.Timers.Timer();
        static ConsoleKey lastKeyPressed;

        static TPiece piece = new TPiece();

        static void Main()
        {
            Timer.Elapsed += Tick;
            Timer.Interval = Delay;
            Timer.Start();
            
            ConsoleKeyInfo info;
            while ((info = ReadKey(true)) != null)
                Input(info.Key);
        }

        static void Input(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    piece.RotateCCW();
                    piece.DrawPiece(2, 2);
                    break;
                case ConsoleKey.RightArrow:
                    piece.RotateCW();
                    piece.DrawPiece(2, 2);
                    break;
                case ConsoleKey.UpArrow:
                case ConsoleKey.DownArrow:
                case ConsoleKey.Spacebar:
                    Tick(key, null);
                    break;
                case ConsoleKey.Escape:
                    Environment.Exit(Environment.ExitCode);
                    break;
            }
        }

        static void Tick(object sender, ElapsedEventArgs e)
        {
            if (sender is ConsoleKey)
            {
                ConsoleKey pressed = (ConsoleKey)sender;
                if (pressed != lastKeyPressed)
                {
                    lastKeyPressed = pressed;
                    ConsoleWriteKey();
                }
            }

            Timer.Interval = Delay;
            Timer.Start();
        }

        static void ConsoleWriteKey()
        {
            SetCursorPosition(0, 0);
            Console.Write(new string(' ', Console.WindowWidth));
            SetCursorPosition(0, 0);
            Write(lastKeyPressed);
            SetCursorPosition(1, 1);
            Console.Write("┌──────┐");
            SetCursorPosition(1, 2);
            Console.Write("│      │");
            SetCursorPosition(1, 3);
            Console.Write("│      │");
            SetCursorPosition(1, 4);
            Console.Write("│      │");
            SetCursorPosition(1, 5);
            Console.Write("└──────┘");
        }
    }
}