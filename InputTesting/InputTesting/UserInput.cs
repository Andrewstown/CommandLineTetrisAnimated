using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputTesting
{
    internal class UserInput
    {
        private bool isCapturing = true;
        private InputTesting app = null!;

        public UserInput(InputTesting app) => this.app = app;

        public void Capture()
        {
            while (isCapturing)
            {
                Process(Console.ReadKey(true));
            }
        }

        public void Process(ConsoleKeyInfo input)
        {
            var key = Char.ToLower(input.KeyChar);
            switch (app.Game.State)
            {
                case GameState.DisplayingMenu:
                    switch (key)
                    {
                        case 'g':
                            app.Game.Play();
                            break;

                        case 'e':
                            Environment.Exit(0);
                            break;

                        default:
                            break;
                    }
                    break;

                case GameState.Playing:
                    switch (key)
                    {
                        case 'p':
                            app.Game.Pause();
                            break;
                        default:
                            break;
                    }
                    break;

                case GameState.Paused:
                    switch (key)
                    {
                        case 'r':
                            app.Game.Resume();
                            break;
                        case 'm':
                            app.Game.DisplayMenu();
                            break;
                        default:
                            break;
                    }
                    break;

                default:
                    break;
            }
        }

    }
}
