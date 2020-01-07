using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7.UserInterface
{
    class GameOverMessage: UIElement
    {
        public GameOverMessage(int line)
            : base(line)
        {
            title = "Game-Over!!!";
        }
        public override void Print()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(title);
        }
    }
}
