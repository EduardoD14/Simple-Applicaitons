using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadTextFile
{
    class Program
    {
        static void Main()
        {
            string location = "C:\\Users\\eduar\\source\\repos\\Simple-Applicaitons\\ReadTextFile\\itwasntme.txt";                   
            readasmultipleclass.readasmultiple(location);
            countlinesclass.countlines(location);
            countemptylinesclass.countemptylines(location);
            countlineswithtextclass.countlineswithtext(location);
            countwordsclass.countwords(location);
            countdistinctwordsclass.countdistinctwords(location);
           // readassinglestring.readassinglstring(location);
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }    
    }
}