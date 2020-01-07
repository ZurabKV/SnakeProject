using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Snake
    {
        Random random = new Random();
        public int x;
        public int y;
        public Snake()
        {
            x = random.Next(115);
            y = random.Next(30);
        }
    }
}
