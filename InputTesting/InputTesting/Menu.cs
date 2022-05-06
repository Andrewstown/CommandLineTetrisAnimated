using System;

namespace InputTesting
{
    public class Menu
    {
        public bool Display()
        {
            Console.Clear();
            Console.Write("" +
                "Welcome to the menu!\n" +
                "\n" +
                "Game - 'g'\n" +
                "Exit - 'e'");

            return true;
        }
    }
}
