using ConsoleApp7.Entities;
using ConsoleApp7.Environment;
using ConsoleApp7.UserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp7
{
    class Food : Creature
    {
        public override char shape => '+';
        public override ConsoleColor CreatureColor => ConsoleColor.DarkGreen;
        public List<Cell> SurroundingCells => new List<Cell> 
        {
            new Cell(x-1,y-1),
            new Cell(x,  y-1),
            new Cell(x+1,y-1),
            new Cell(x-1,y),
            new Cell(x+1,y),
            new Cell(x-1,y+1),
            new Cell(x,  y+1),
            new Cell(x+1,y+1),
        };

        public static void IfWasEaten(Snake snake, ref Food food)
        {
            bool foodWasEaten = snake.x == food.x && snake.y == food.y;
            if (foodWasEaten)
            {
                food = new Food();
                Snake.score++;
            }
        }
        public void MoveFromPlayer(Snake snake)
        {
            if (Snake.stepsMade%2==0||Snake.stepsMade%3==0)
            {
                Cell chosenCell = SurroundingCells.OrderByDescending(cell => cell.DistanceToPlayer(snake)).Where(cell => cell.x != 0 && cell.y != 0 && cell.x != PlayGround.width - 1 && cell.y != PlayGround.hight - 1).First();
                x = chosenCell.x;
                y = chosenCell.y; 
            }
        }
    }
}
