using System;
using System.Threading;

namespace InputTesting
{
    public class InputTesting
    {
        Thread thread;

        private ConsoleKeyInfo input;

        private bool inputSwitch = true;

        public int state = 0;

        static void Main(string[] args)
        {
            InputTesting input = new InputTesting();
            input.Start();
        }

        public void Start()
        {
            thread = new Thread(new ThreadStart(InputThread));
            thread.Start();
            Menu();
        }

        public void InputThread()
        {
            while(inputSwitch == true)
            {
                input = Console.ReadKey(true);
                Input();
            }
        }

        public void Input()
        {
            var key = Char.ToLower(input.KeyChar);
            switch (state)
            {
                case 0:
                    switch (key)
                    {
                        case 'g':
                            Game();
                            break;
                        case 'e':
                            Environment.Exit(0);
                            break;
                        default:
                            break;
                    }
                    break;
                case 1:
                    switch (key)
                    {
                        case 'p':
                            Pause();
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    switch (key)
                    {
                        case 'r':
                            Game();
                            break;
                        case 'm':
                            Menu();
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }

        public void Menu()
        {
            state = 0;
            Console.Clear();
            Console.Write("" +
                "Welcome to the menu!\n" +
                "\n" +
                "Game - 'g'\n" +
                "Exit - 'e'");
        }

        public void Game()
        {
            state = 1;
            Console.Clear();
            Console.Write("" +
                "You are in the game!\n" +
                "\n" +
                "Pause - 'p'");
        }

        public void Pause()
        {
            state = 2;
            Console.Clear();
            Console.Write("" +
                "You are Pasued!\n" +
                "\n" +
                "Resume - 'r'\n" +
                "Menu - 'm'");
        }
    }
}