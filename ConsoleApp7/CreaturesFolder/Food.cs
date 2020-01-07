using ConsoleApp7.Entities;
using ConsoleApp7.UserInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Food: Creature
    {
        public override char shape => '+';
        public override ConsoleColor CreatureColor => ConsoleColor.DarkGreen;

        public static void IfWasEaten(Snake snake, ref Food food)
        {
            bool foodWasEaten = snake.x == food.x && snake.y == food.y;
            if (foodWasEaten)
            {
                food = new Food();
                Snake.score++;
            }
        }

        
    }
}
