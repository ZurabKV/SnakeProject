using ConsoleApp7.CreaturesFolder;
using ConsoleApp7.Environment;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7.Entities
{
    abstract class OnePixelCreature: IHasOnePixel
    {
        public int id = 0;
        public static int idCounter=0;

        public Pixel pixel { get; set; }

        public Random random = new Random();

        public abstract char shape { get;}
        public abstract ConsoleColor CreatureColor { get;}

        public OnePixelCreature()
        {
            idCounter++;
            id = idCounter;
            int x = random.Next(1, PlayGround.width - 1);
            int y = random.Next(1, PlayGround.hight - 1);
            pixel = new Pixel(x, y);
        }

        public void Draw()
        {
            Console.SetCursorPosition(pixel.x, pixel.y);
            Console.ForegroundColor = CreatureColor;
            Console.Write(shape);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
