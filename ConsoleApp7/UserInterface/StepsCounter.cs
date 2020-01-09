using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7.UserInterface
{
    class StepsCounter: UIElement
    {
        public override int value => Player.stepsMade;

        public StepsCounter(int line)
            : base(line)
        {
            title = "Steps made";
        }
    }
}
