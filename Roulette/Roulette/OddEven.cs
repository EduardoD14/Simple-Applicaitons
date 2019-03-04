using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class OddEvenClass
    {
        public static string Odd_Even(int i)
        {
            if (i % 2 == 0)
            {
                return "even";
            }
            else
            {
                return "odd";
            }
        }
    }
}
