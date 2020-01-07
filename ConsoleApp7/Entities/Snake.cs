using ConsoleApp7.UserInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Snake
    {
        public int x;
        public int y;
        public char shape = 'O';

        Random random = new Random();

        public Snake()
        {
            x = random.Next(1, PlayGround.width - 1);
            y = random.Next(1, PlayGround.hight - 1);
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(shape);
        }

        public static void IfWasCrushed(ref Snake snake, ref Food food)
        {
            bool SnakeIsDead = snake.x == 0 || snake.y == 0 || snake.x == PlayGround.width - 1 || snake.y == PlayGround.hight - 1;

            if (SnakeIsDead) // game over mechanics
            {
                snake = new Snake();
                food = new Food();
                Console.WriteLine(UI.gamOverMessage);
                Console.ReadKey();
                UI.score.value = 0;
            }
        }
    }
}
