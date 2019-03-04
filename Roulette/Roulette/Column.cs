using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class ColumnClass
    {
        public static string Column(int i) 
        {
            if (Program.table.Column(i) == 0)
            {
                return "1st (1, 4, ... 31, 34)";
            }
            else if (Program.table.Column(i) == 1)
            {
                return "2nd (2, 5, ... 32, 35)";
            }
            else
            {
                return "3rd (3, 6, ... 33, 36)";
            }
        }
    }
}
