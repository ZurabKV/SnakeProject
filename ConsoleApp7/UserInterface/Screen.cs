using ConsoleApp7.CreaturesFolder;
using ConsoleApp7.Entities;
using ConsoleApp7.UserInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Screen
    {
        public static void DrawScreen(Player player, Food food, List<Enemy> enemies)
        {
            Console.Clear();
            UI.DrawInterface();
            PlayGround.DrawPlayGround();
            DrawOnePixelCreatures(player, food, enemies);
        }

        private static void DrawOnePixelCreatures(Player player, Food food, List<Enemy> enemies)
        {
            foreach (Enemy enemy in enemies)
            {
                Console.SetCursorPosition(enemy.pixel.x, enemy.pixel.y);
                Console.ForegroundColor = enemy.CreatureColor;
                Console.Write(enemy.shape);
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.SetCursorPosition(food.pixel.x, food.pixel.y);
            Console.ForegroundColor = food.CreatureColor;
            Console.Write(food.shape);
            Console.ForegroundColor = ConsoleColor.White;

            Console.SetCursorPosition(player.pixel.x, player.pixel.y);
            Console.ForegroundColor = player.CreatureColor;
            Console.Write(player.shape);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
