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

            snake.Move(key);
        }
    }
}
