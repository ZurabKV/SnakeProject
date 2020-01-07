using ConsoleApp7;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7.UserInterface
{
    static class UI
    {
        public static string gamOverMessage = "GAME OVER!!!";
        public static Score score = new Score(2);
        public static StepsCounter stepsMade = new StepsCounter(3);

        public static void DrawInterface()
        {
            score.Print();
            stepsMade.Print();
        }
    }
}
