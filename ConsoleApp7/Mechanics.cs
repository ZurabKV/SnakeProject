using ConsoleApp7.Entities;
using ConsoleApp7.Environment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp7
{
    static class Mechanics
    {
        public static void MoveTowardsPlayer(List<Enemy> enemies, Player player, Food food)
        {
            foreach (Enemy enemy in enemies)
            {
                var dsfsdf = enemy.pixel.DistanceToPlayer(player);
                if (Player.stepsMade % 2 == 0)
                {
                    try
                    {
                        Pixel chosenCell = enemy.SurroundingCells
                                        .OrderBy(pixel => pixel.DistanceToPlayer(player))
                                        .Where(pixel => pixel.x != 0 &&
                                                        pixel.y != 0 &&
                                                        pixel.x != PlayGround.width - 1 &&
                                                        pixel.y != PlayGround.hight - 1 &&
                                                        pixel.x != food.pixel.x &&
                                                        pixel.y != food.pixel.y &&
                                                        enemies.Where(e=>e.id!=enemy.id).All(e => e.pixel.x != pixel.x && e.pixel.y != pixel.y))
                                        .First();
                        enemy.pixel.x = chosenCell.x;
                        enemy.pixel.y = chosenCell.y;
                    }
                    catch (Exception)
                    {
                        var playerX = player.pixel.x;
                    }
                }
            }
        }
        public static void MoveFromPlayer(Food food, Player player)
        {
            if (Player.stepsMade % 2 == 0 || Player.stepsMade % 3 == 0)
            {
                Pixel chosenCell = food.SurroundingCells.OrderByDescending(cell => cell.DistanceToPlayer(player))
                    .Where(cell => 
                    cell.x != 0 && 
                    cell.y != 0 && 
                    cell.x != PlayGround.width - 1 && 
                    cell.y != PlayGround.hight - 1)
                    .First();
                food.pixel.x = chosenCell.x;
                food.pixel.y = chosenCell.y;
            }
        }
    }
}
