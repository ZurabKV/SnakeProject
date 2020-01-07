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
                Screen.DrawScreen(snake, food);
                Input.AcceptInput(snake);
                Food.IfWasEaten(snake, ref food); //checks if food was eaten
                Snake.IfWasCrushed(ref snake, ref food); //checks if snake has crushed
            }
        }
        
        
    }
}
