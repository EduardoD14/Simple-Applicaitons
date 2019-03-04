using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class LowHighClass
    {
        public static string Low_High(int i) //returns which half of the numbers the input is in
        {
            if (i < 19 && i > 0)
            {
                return "low (1-18)";
            }
            else
            {
                return "high (19-36)";
            }
        }

    }
}
