using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ReadTextFile
{
    class countdistinctwordsclass
    {
        public static void countdistinctwords(string path)
        {
            ArrayList distinctWords = new ArrayList();
            string[] lines = System.IO.File.ReadAllLines(path);
            List<string> distinctwords = new List<string>();
            foreach (var word in lines)
            {
                if (!distinctWords.Contains(word))
                {
                    distinctWords.Add(word);
                }
            }
            Console.WriteLine($"The number of distinct words in the text is {distinctWords.Count}");
        }
    }
}
