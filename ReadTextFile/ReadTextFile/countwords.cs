using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadTextFile
{
    class countwordsclass
    {
        public static void countwords(string path)
        {                    
            StreamReader sr = new StreamReader(path);
            int counter = 0;
            string delim = " ,.?!"; 
            string[] fields = null;
            string line = null;
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                line.Trim();
                fields = line.Split(delim.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                counter += fields.Length;
            }
            sr.Close();
            Console.WriteLine("The word count is {0}", counter);
        }

    }
}
