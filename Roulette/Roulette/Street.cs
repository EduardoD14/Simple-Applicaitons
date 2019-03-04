using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class StreetClass
    {
        public static string Street(int i) 
        {
            return $"{Program.table.GetNum(Program.table.Row(i), 0)}," +
                $" {Program.table.GetNum(Program.table.Row(i), 1)}," +
                $" {Program.table.GetNum(Program.table.Row(i), 2)}";
        }
    }
}
