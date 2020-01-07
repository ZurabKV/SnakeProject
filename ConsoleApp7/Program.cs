using System;
using System.Threading;

namespace ConsoleApp7
{
    class Program
    {
        static Snake snake = new Snake();
        static Food food = new Food();

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            while (true)
            {
                Drawing.DrawScreen(snake, food);

                if (snake.x==food.x && snake.y == food.y)
                {
                    food = new Food();
                }

                Input.AcceptInput(snake);
            }
        }
        
        
    }
}
