using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7.Entities
{
    abstract class Creature
    {
        public int x;
        public int y;

        public Random random = new Random();

        public abstract char shape { get;}
        public abstract ConsoleColor CreatureColor { get;}

        public Creature()
        {
            x = random.Next(1, PlayGround.width - 1);
            y = random.Next(1, PlayGround.hight - 1);
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = CreatureColor;
            Console.Write(shape);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
