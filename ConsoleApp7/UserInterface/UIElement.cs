using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7.UserInterface
{
    class UIElement
    {
        public string title;
        public virtual int value { get; }
        public int x = PlayGround.width+6;
        public int y;

        public UIElement(int line)
        {
            y = line;
        }
        public void Print()
        {
            Console.SetCursorPosition(x, y);
            Console.Write($"{title}: {value}");
        }
    }
}
