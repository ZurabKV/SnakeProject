using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7.Entities
{
    class Enemy: Creature
    {
        public override ConsoleColor CreatureColor => ConsoleColor.DarkRed;

        public override char shape => 'X';
    }
}
