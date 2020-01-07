using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Snake
    {
        Random random = new Random();
        public int x;
        public int y;
        public char shape = 'O';

        public Snake()
        {
            x = random.Next(1, PlayGround.width-1);
            y = random.Next(1, PlayGround.hight-1);
        }

        public static void IfWasCrushed(ref Snake snake, ref Food food)
        {
            if (snake.x == 0 || snake.y == 0 || snake.x == PlayGround.width - 1 || snake.y == PlayGround.hight - 1) // game over mechanics
            {
                snake = new Snake();
                food = new Food();
                Console.WriteLine(UI.gamOverMessage);
                Console.ReadKey();
            }
        }
    }
}
