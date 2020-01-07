using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    static class PlayGround
    {
        public static int width = 16;
        public static int hight = 7;
        public static char shape = '#';

        public static void DrawBorders()
        {
            for (int cursorY = 1; cursorY <= PlayGround.hight; cursorY++)
            {
                for (int cursorX = 1; cursorX <= PlayGround.width; cursorX++)
                {
                    if (cursorY == 1 || cursorY == PlayGround.hight || cursorX == 1 || cursorX == PlayGround.width)
                    {
                        Console.SetCursorPosition(cursorX - 1, cursorY - 1);
                        Console.Write(PlayGround.shape);
                    }
                }
            }
        }
    }
}
