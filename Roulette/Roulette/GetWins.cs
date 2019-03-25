using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class GetWinsClass
    {
        public static void GetWins(int i)
        {
            if (i == 37)
            {
                Console.Write($"The following bets win on 00:\nThe Straight Up win is 00.\n");
            }
            else
            {
                Console.Write($"The following bets win on {i}:\nThe Straight Up win is {i}.\n");
            }
            Console.Write($"The Split wins are: {SplitClass.Split(i)}.\n");
            if (i > 0 && i < 37)
            {
                Console.Write($"The Street win is: ({StreetClass.Street(i)}).\n" +
                $"The Corner wins are: {CornerClass.Corner(i)}.\n" +
                $"The Line wins are: {LineClass.Line(i)}.\n" +
                $"The Column win is: {ColumnClass.Column(i)}.\n" +
                $"The Dozen win is: {DozenClass.Dozen(i)}.\n" +
                $"The Low/High number win is: {LowHighClass.Low_High(i)}.\n" +
                $"The Odd/Even win is: {OddEvenClass.Odd_Even(i)}.\n" +
                $"The Color win is: {Program.table.GetColor(i)}.\n");
            }
            if (i < 4 || i == 37)
            {
                Console.Write($"The Basket bet wins (0, 00, 1, 2, 3).\n");
            }
            Console.WriteLine();
        }
    }
}