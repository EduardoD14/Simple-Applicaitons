using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_rate_needed_to_hit_a_target
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a proposed rate: ");
            double x = Convert.ToDouble(Console.ReadLine());
            GetRate(x);
            Console.ReadKey();
        }

        // I am a day trader and I would like to make 1 million dollars in 10 weeks.
        //I want to know the minimum rate of increase I need to earn daily if I want
        // to spread out the gains evenly. My starting funds are $100,000. 

        public static void GetRate(double x)
        {
            double Rate = 100000;
            for (int i = 0; i < 50; i++)
            {
                double rate = Rate * (x / 100 + 1);
                Rate = rate;
                Console.WriteLine(Rate);
            }         
        }
    }
}
