using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7.Environment
{
    class Cell
    {
        public int x;
        public int y;
        public Cell(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public double DistanceToPlayer(Snake snake)
        {
            return Math.Sqrt(Math.Pow(snake.x - x, 2) + Math.Pow(snake.y - y, 2));
        }
    }
}
