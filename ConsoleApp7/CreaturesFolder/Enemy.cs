using ConsoleApp7.CreaturesFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7.Entities
{
    class Enemy : Creature
    {
        public override ConsoleColor CreatureColor => ConsoleColor.DarkRed;

        public override char shape => 'X';

        public void MoveTowardsPlayer(Snake snake)
        {
            if (Snake.stepsMade%2==0)
            {
                int distanceToThePLayerX = this.x - snake.x;
                int distanceToThePLayerY = this.y - snake.y;
                if (distanceToThePLayerX > 0)
                {
                    this.x--;
                }
                if (distanceToThePLayerX < 0)
                {
                    this.x++;
                }
                if (distanceToThePLayerY > 0)
                {
                    this.y--;
                }
                if (distanceToThePLayerY < 0)
                {
                    this.y++;
                } 
            }
        }
    }
}
