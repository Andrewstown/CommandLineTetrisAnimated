using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputTesting
{
    public class GameEngine
    {
        public GameState State { get; set; } = GameState.Idle;
        private Menu menu { get; set; } = new Menu();

        public void DisplayMenu()
        {
            if (State != GameState.DisplayingMenu && menu.Display())
            {
                State = GameState.DisplayingMenu;
            }
        }

        public void Play()
        {
            Console.Clear();
            Console.Write("" +
                "You are in the game!\n" +
                "\n" +
                "Pause - 'p'");

            State = GameState.Playing;
        }

        public void Pause()
        {
            Console.Clear();
            Console.Write("" +
                "You are Pasued!\n" +
                "\n" +
                "Resume - 'r'\n" +
                "Menu - 'm'");

           State = GameState.Paused;
        }

        public void Resume()
        {
            Play();
        }
    }

}
