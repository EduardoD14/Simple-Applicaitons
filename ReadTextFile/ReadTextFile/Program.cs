using System;
using System.IO;

namespace ReadTextFile
{
    internal class Program
    {
        private static void Main()
        {
            // The files used in this example are created in the topic
            // How to: Write to a Text File. You can change the path and
            // file name to substitute text files of your own.
            // Read the file as one string.
            //string text = System.IO.File.ReadAllText(@"C:\Users\eduar\source\repos\Simple-Applicaitons\ReadTextFile\itwasntme.txt");
            //Console.WriteLine("Contents of itwasntme.txt = {0}", text);

            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string location = "C:\\Users\\eduar\\source\\repos\\Simple-Applicaitons\\ReadTextFile\\itwasntme.txt";
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\eduar\source\repos\Simple-Applicaitons\ReadTextFile\itwasntme.txt");
            Console.WriteLine("Contents of itwasntme.txt = ");
            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }
            readtextfile(location);
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
        public static void readtextfile(string path)
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