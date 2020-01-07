using ConsoleApp7.UserInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Screen
    {
        public static void DrawScreen(Snake snake, Food food)
        {
            Console.Clear();
            PlayGround.DrawBorders();
            food.Draw();
            snake.Draw();
            UI.DrawScore();
        }
    }
}
