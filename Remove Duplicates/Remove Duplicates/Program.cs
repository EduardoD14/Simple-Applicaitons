using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Duplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string: ");
          PrintRemovedDuplicates( Console.ReadLine());
            Console.ReadKey();
        }
        static void PrintRemovedDuplicates(string input)
        {
            input = input.ToUpper();
            for (char c= 'A'; c <= 'Z'; c++)
            {
                int count = 0;
                if (input.Contains(c.ToString()))
                {
                    foreach (char ch in input)
                    {
                        if (ch == c) count++;
                    }
                    Console.WriteLine($"{c} - {count}");
                }
            }            
                                 
        }
    }
    
}
