using ConsoleApp7.Entities;
using ConsoleApp7.Environment;
using ConsoleApp7.UserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp7
{
    class Food : OnePixelCreature
    {
        public override char shape => '+';
        public override ConsoleColor CreatureColor => ConsoleColor.DarkGreen;
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

        public static void IfWasEaten(Player snake, ref Food food)
        {
            bool foodWasEaten = snake.pixel.x == food.pixel.x && snake.pixel.y == food.pixel.y;
            if (foodWasEaten)
            {
                food = new Food();
                Player.score++;
            }
        }
        
    }
}
