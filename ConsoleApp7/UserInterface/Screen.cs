using ConsoleApp7.Entities;
using ConsoleApp7.UserInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Screen
    {
        public static void DrawScreen(Snake snake, Food food, Enemy enemy)
        {
            Console.Clear();
            UI.DrawInterface();
            PlayGround.DrawPlayGround();
            food.Draw();
            snake.Draw();
            enemy.Draw();
        }
    }
}
