using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Input
    {
        public static void AcceptInput(Snake snake)
        {
            ConsoleKeyInfo key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.LeftArrow:
                    snake.x--;
                    break;
                case ConsoleKey.RightArrow:
                    snake.x++;
                    break;
                case ConsoleKey.UpArrow:
                    snake.y--;
                    break;
                case ConsoleKey.DownArrow:
                    snake.y++;
                    break;

            }
        }
    }
}
