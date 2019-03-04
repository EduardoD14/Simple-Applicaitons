using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadTextFile
{
    class readassinglestring
    {
        public static void readassinglstring(string path)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\eduar\source\repos\Simple-Applicaitons\ReadTextFile\itwasntme.txt");
            Console.WriteLine("Contents of itwasntme.txt = {0}", text);
        }
    }
}
