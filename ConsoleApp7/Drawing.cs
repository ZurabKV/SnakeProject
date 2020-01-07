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
            DrawBorders();
            Draw(food);
            Draw(snake);
        }

        public static void Draw(Food food)
        {
            Console.SetCursorPosition(food.x, food.y);
            Console.Write(food.shape);
        }

        public static void Draw(Snake snake)
        {
            Console.SetCursorPosition(snake.x, snake.y);
            Console.Write(snake.shape);
        }

        public static void DrawBorders()
        {
            for (int cursorY = 1; cursorY <= PlayGround.hight; cursorY++)
            {
                for (int cursorX = 1; cursorX <= PlayGround.width; cursorX++)
                {
                    if (cursorY==1||cursorY== PlayGround.hight|| cursorX== 1 || cursorX == PlayGround.width)
                    {
                        Console.SetCursorPosition(cursorX-1, cursorY-1);
                        Console.Write(PlayGround.shape);
                    }
                }
            }
        }

        
        
    }
}
