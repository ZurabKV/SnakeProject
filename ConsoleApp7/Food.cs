using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Food
    {
        static Random random = new Random();
        public int x;
        public int y;
        public char shape = '+';

        public Food()
        {
            x = random.Next(1, PlayGround.width-1);
            y = random.Next(1, PlayGround.hight-1);
        }

        public static void IfWasEaten(Snake snake, ref Food food)
        {
            if(snake.x == food.x && snake.y == food.y) // eating mechanics
            {
                food = new Food();
            }
        }

        
    }
}
