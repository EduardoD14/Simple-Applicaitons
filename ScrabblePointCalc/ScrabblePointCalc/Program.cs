using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrabblePointCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a scrabble word to calculate the number of points you will get for said word: ");
            Console.WriteLine(Points(Console.ReadLine()));
            Console.ReadKey();

        }
        static readonly Dictionary<char, int> scrabble = new Dictionary<char, int>
        {
            {'A',1},{'E',1},{'I',1},{'O',1},{'U',1},
            {'L',1},{'N',1},{'S',1},{'T',1},{'R',1},
            {'D',2},{'G',2},
            {'B',3},{'C',3}, {'M',3},{'P',3},
            {'F',3},{'H',3}, {'V',3},{'W',3},{'Y',3},
            {'K',5},
            {'J',8},{'X',8},
            {'Q',10},{'Z',10}
        };
        public static int Points(string input)
        {
            int total = 0;
            input = input.ToUpper();
            foreach (char c in input)
            {
                total += scrabble[c];
            }

            return total;
        }


    }
}
