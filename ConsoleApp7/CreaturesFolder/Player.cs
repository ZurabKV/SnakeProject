using ConsoleApp7.CreaturesFolder;
using ConsoleApp7.Entities;
using ConsoleApp7.UserInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Player : OnePixelCreature, IMovable
    {
        public static int score = 0;
        public static int stepsMade = 0;
        public override char shape => 'O';
        public override ConsoleColor CreatureColor => ConsoleColor.Magenta;


        public static void IfWasKilled(ref Player snake, ref Food food, ref List<Enemy> enemies)
        {
            bool SnakeTouchedWall = snake.pixel.x == 0 || snake.pixel.y == 0 || snake.pixel.x == PlayGround.width - 1 || snake.pixel.y == PlayGround.hight - 1;
            bool SnakeTouchedEnemy = false; 
            foreach (Enemy enemy in enemies) //check each enemy if touched player
            {
                if (snake.pixel.x == enemy.pixel.x && snake.pixel.y == enemy.pixel.y)
                {
                    SnakeTouchedEnemy = true;
                    break;
                }
            }
                

            if (SnakeTouchedEnemy||SnakeTouchedWall)
            {
                ExecutePostDeathAction(ref snake, ref food, ref enemies);
            }
        }

        public void Move(ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.LeftArrow:
                    pixel.x--;
                    break;
                case ConsoleKey.RightArrow:
                    pixel.x++;
                    break;
                case ConsoleKey.UpArrow:
                    pixel.y--;
                    break;
                case ConsoleKey.DownArrow:
                    pixel.y++;
                    break;
            }
            stepsMade++;
        }
        public static void ExecutePostDeathAction(ref Player snake, ref Food food, ref List<Enemy> enemies)
        {
            snake = new Player();
            food = new Food();
            enemies = Enemy.GetEnemies(enemies.Count);
            UI.gameover.Print();
            Console.ReadKey();
            score = 0;
            stepsMade = 0;
        }
    }
}
