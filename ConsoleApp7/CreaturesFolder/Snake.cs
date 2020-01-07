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
        public override ConsoleColor CreatureColor => ConsoleColor.Magenta;

        public static void IfWasKilled(ref Snake snake, ref Food food, ref Enemy enemy)
        {
            bool SnakeTouchedWall = snake.x == 0 || snake.y == 0 || snake.x == PlayGround.width - 1 || snake.y == PlayGround.hight - 1;
            bool SnakeTouchedEnemy = snake.x == enemy.x && snake.y == enemy.y;

            if (SnakeTouchedWall||SnakeTouchedEnemy) // game over mechanics
            {
                snake = new Snake();
                food = new Food();
                enemy = new Enemy();
                UI.gameover.Print();
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
