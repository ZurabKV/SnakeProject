using ConsoleApp7.Entities;
using System;
using System.Threading;

namespace ConsoleApp7
{
    class Program
    {
        static Snake snake = new Snake();
        static Food food = new Food();
        static Enemy enemy = new Enemy();

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            while (true)
            {
                Screen.DrawScreen(snake, food, enemy);
                Input.AcceptInput(snake);
                enemy.MoveTowardsPlayer(snake);
                food.MoveFromPlayer(snake);
                Food.IfWasEaten(snake, ref food); 
                Snake.IfWasKilled(ref snake, ref food, ref enemy); 
            }
        }
        
        
    }
}
