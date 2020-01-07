using ConsoleApp7;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7.UserInterface
{
    static class UI
    {
        public static string gamOverMessage = "GAME OVER!!!";
        public static Score score = new Score();

        public static void DrawScore()
        {
            Console.SetCursorPosition(score.x, score.y);
            Console.Write("Score: ");
            Console.Write(score.value);
        }
    }
}
