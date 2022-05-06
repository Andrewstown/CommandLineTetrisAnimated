using System;
using System.Threading;

namespace InputTesting
{
    public class InputTesting
    {
        public GameEngine Game = new GameEngine();

        private Thread? thread;
        private UserInput? input;

        static void Main(string[] args)
        {
            InputTesting testing = new InputTesting();
            testing.Start();
        }

        public void Start()
        {
            Game.DisplayMenu();

            input = new UserInput(this);
            thread = new Thread(new ThreadStart(input.Capture));
            thread.Start();
        }
    }
}
