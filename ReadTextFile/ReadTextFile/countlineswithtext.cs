using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ReadTextFile
{
    class countlineswithtextclass
    {
       
        public static void countlineswithtext(string path)
        {
            ArrayList words = new ArrayList();
            string[] lines = System.IO.File.ReadAllLines(path);
            int counter = 0;            
            foreach (var liner in lines)
            {
                if(liner.Trim(' ').Length>0)
                {
                    words.Add(liner);
                    counter++;
                }
            }
            Console.WriteLine("The number of lines with text is {0}", counter);
        }
    }
}
