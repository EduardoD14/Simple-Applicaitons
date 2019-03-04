using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadTextFile
{
    class readasmultipleclass
    {
        public static void readasmultiple(string path)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\eduar\source\repos\Simple-Applicaitons\ReadTextFile\itwasntme.txt");
            Console.WriteLine("Contents of itwasntme.txt = ");
            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }
        }
    }
}

