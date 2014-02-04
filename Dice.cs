using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_Game_1
{
    public static class Dice
    {
        static Random randr = new Random();

        public static int roll(int maxroll)
        {
            return Convert.ToInt32(randr.Next(1, maxroll + 1));
        }
    }
}
