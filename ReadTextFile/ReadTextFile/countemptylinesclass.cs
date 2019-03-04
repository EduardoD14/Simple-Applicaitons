using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadTextFile
{
    class countemptylinesclass
    {
        public static void countemptylines(string path)
        {
            int blanklines = 0;
            string[] lines = System.IO.File.ReadAllLines(path);           
            foreach (string line in lines)
            {
                if (line.Length < 1) blanklines++;
            }
            Console.WriteLine($"There are {blanklines} blank lines ");
        }
    }
}
