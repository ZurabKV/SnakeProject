using ConsoleApp7.Entities;
using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp7
{
    class Program
    {
        static Player player = new Player();
        static Food food = new Food();
        static List<Enemy> enemies = Enemy.GetEnemies(10);

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            while (true)
            {
                Screen.DrawScreen(player, food, enemies);
                Input.AcceptInput(player);
                Mechanics.MoveTowardsPlayer(enemies, player, food);
                Mechanics.MoveFromPlayer(food ,player);
                Food.IfWasEaten(player, ref food); 
                Player.IfWasKilled(ref player, ref food, ref enemies); 
            }
        }
        
        
    }
}
