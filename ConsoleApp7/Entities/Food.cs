using ConsoleApp7.UserInterface;
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

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(shape);
        }

        public static void IfWasEaten(Snake snake, ref Food food)
        {
            bool foodWasEaten = snake.x == food.x && snake.y == food.y;
            if (foodWasEaten)
            {
                food = new Food();
                UI.score.value++;
            }
        }

        
    }
}
