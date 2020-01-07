using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Drawing
    {
        public static void DrawScreen(Snake snake, Food food)
        {
            Console.Clear();
            Draw(snake);
            Draw(food);

        }

        public static void Draw(Food food)
        {
            Console.SetCursorPosition(food.x, food.y);
            Console.Write('+');
        }

        public static void Draw(Snake snake)
        {
            Console.SetCursorPosition(snake.x, snake.y);
            Console.Write('O');
        }
        
        
    }
}
