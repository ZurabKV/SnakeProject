using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7.UserInterface
{
    class Score: UIElement
    {
        public override int value => Snake.score;
        public Score(int line)
            :base(line)
        {
            title = "Score";
        }
    }
}
