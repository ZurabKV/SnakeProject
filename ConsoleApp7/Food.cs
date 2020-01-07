using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Food
    {
        static Random random = new Random();
        public int x;
        public int y;

        public Food()
        {
            x = random.Next(115);
            y = random.Next(30);
        }

        
    }
}
