using ConsoleApp7.Entities;
using ConsoleApp7.UserInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Snake: Creature
    {
        public static int score=0;
        public static int stepsMade=0;
        public override char shape => 'O';
        public override ConsoleColor Color => ConsoleColor.Magenta;

        public static void IfWasCrushed(ref Snake snake, ref Food food)
        {
            bool SnakeIsDead = snake.x == 0 || snake.y == 0 || snake.x == PlayGround.width - 1 || snake.y == PlayGround.hight - 1;

            if (SnakeIsDead) // game over mechanics
            {
                snake = new Snake();
                food = new Food();
                Console.WriteLine(UI.gamOverMessage);
                Console.ReadKey();
                //UI.score.value = 0;
                score = 0;
                stepsMade = 0;
            }
            else
            {
                stepsMade++;
            }
        }
    }
}
