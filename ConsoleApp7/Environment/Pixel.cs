using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7.Environment
{
    class Pixel
    {
        public int x;
        public int y;
        public Pixel(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public double DistanceToPlayer(Player snake)
        {
            return Math.Sqrt(Math.Pow(snake.pixel.x - x, 2) + Math.Pow(snake.pixel.y - y, 2));
        }
    }
}
