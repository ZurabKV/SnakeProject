﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    static class PlayGround
    {
        public static int width = 30; //game area
        public static int hight = 20;
        public static char shape = '#';

        public static void DrawPlayGround()
        {
            DrawBorders();
        }
        public static void DrawBorders()
        {
            for (int cursorY = 1; cursorY <= PlayGround.hight; cursorY++)
            {
                for (int cursorX = 1; cursorX <= PlayGround.width; cursorX++)
                {
                    if (cursorY == 1 || cursorY == PlayGround.hight || cursorX == 1 || cursorX == PlayGround.width) //checks if cursor is on first or last position
                    {
                        Console.SetCursorPosition(cursorX - 1, cursorY - 1);
                        Console.Write(PlayGround.shape);
                    }
                }
            }
        }
    }
}
