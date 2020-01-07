using ConsoleApp7.CreaturesFolder;
using ConsoleApp7.Entities;
using ConsoleApp7.UserInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Snake : Creature, IMovable
    {
        public static int score = 0;
        public static int stepsMade = 0;
        public override char shape => 'O';
        public override ConsoleColor CreatureColor => ConsoleColor.Magenta;


        public static void IfWasKilled(ref Snake snake, ref Food food, ref Enemy enemy)
        {
            bool SnakeTouchedWall = snake.x == 0 || snake.y == 0 || snake.x == PlayGround.width - 1 || snake.y == PlayGround.hight - 1;
            bool SnakeTouchedEnemy = snake.x == enemy.x && snake.y == enemy.y;

            if (SnakeTouchedEnemy||SnakeTouchedWall)
            {
                ExecutePostDeathAction(ref snake, ref food, ref enemy);
            }
        }

        public void Move(ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.LeftArrow:
                    x--;
                    break;
                case ConsoleKey.RightArrow:
                    x++;
                    break;
                case ConsoleKey.UpArrow:
                    y--;
                    break;
                case ConsoleKey.DownArrow:
                    y++;
                    break;
            }
            stepsMade++;
        }
        public static void ExecutePostDeathAction(ref Snake snake, ref Food food, ref Enemy enemy)
        {
            snake = new Snake();
            food = new Food();
            enemy = new Enemy();
            UI.gameover.Print();
            Console.ReadKey();
            score = 0;
            stepsMade = 0;
        }
    }
}
