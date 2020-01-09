using ConsoleApp7.CreaturesFolder;
using ConsoleApp7.Environment;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7.Entities
{
    class Enemy : OnePixelCreature
    {
        public override ConsoleColor CreatureColor => ConsoleColor.DarkRed;

        public override char shape => 'X';

        public List<Pixel> SurroundingCells => new List<Pixel>
        {
            new Pixel(pixel.x-1,pixel.y-1),
            new Pixel(pixel.x,  pixel.y-1),
            new Pixel(pixel.x+1,pixel.y-1),
            new Pixel(pixel.x-1,pixel.y),
            new Pixel(pixel.x+1,pixel.y),
            new Pixel(pixel.x-1,pixel.y+1),
            new Pixel(pixel.x,  pixel.y+1),
            new Pixel(pixel.x+1,pixel.y+1),
        };

        public static List<Enemy> GetEnemies(int count)
        {
            List<Enemy> enemies = new List<Enemy>();
            for (int i = 0; i < count; i++)
            {
                enemies.Add(new Enemy());
            }
            return enemies;
        }
    }
}
