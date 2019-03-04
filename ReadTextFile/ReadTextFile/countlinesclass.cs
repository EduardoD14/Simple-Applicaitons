using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadTextFile
{
    class countlinesclass
    {
        public static void countlines(string path)
        {
            try
            {
                string[] lines = File.ReadAllLines(path);
                Console.WriteLine($"{lines.Length} lines read");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file cannot be opened");
            }
        }
    }
}
