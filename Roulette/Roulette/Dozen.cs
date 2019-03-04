using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class DozenClass
    {
        public static string Dozen(int i) 
        {
            if (i < 19 && i > 0)
            {
                return "1st (1-12)";
            }
            else if (i < 19 && i > 0)
            {
                return "2nd (13-24)";
            }
            else
            {
                return "3rd (25-36)";
            }
        }
    }
}
