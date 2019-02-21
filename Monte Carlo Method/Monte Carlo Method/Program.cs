using System;


namespace Monte_Carlo_Method
{
    internal class Program

    {
        private static void Main(string[] args)
        {
            //  Console.WriteLine("Enter a number");
            //int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Arr(10));
            Console.WriteLine(Arr(100));
            Console.WriteLine(Arr(1000));
            Console.WriteLine(Arr(10000));
            Console.WriteLine(Arr(100000000));         
            Console.WriteLine("The difference between my estimate of pi and Math.pi is"+ Math.Abs(Arr(10)-Math.PI));
            Console.WriteLine("The difference between my estimate of pi and Math.pi is" + Math.Abs(Arr(100) - Math.PI));
            Console.WriteLine("The difference between my estimate of pi and Math.pi is" + Math.Abs(Arr(1000) - Math.PI));
            Console.WriteLine("The difference between my estimate of pi and Math.pi is" + Math.Abs(Arr(10000) - Math.PI));
            Console.WriteLine("The difference between my estimate of pi and Math.pi is" + Math.Abs(Arr(100000000) - Math.PI));

            Console.ReadKey();
        }
        public struct Coordinates
        {
            public double x, y;
            public Coordinates(double p1, double p2)
            {
                x = p1;
                y = p2;

            }
            public Coordinates(Random random)
            {
                y = random.NextDouble();
                x = random.NextDouble();
            }
        }
        public static double FindHypotenuse(Coordinates Coords)
        {
            return Math.Sqrt(Coords.x * Coords.x + Coords.y * Coords.y);
        }

        private static double Arr(int x)
        {
            double[] y = new double[x];
            double counter = 0;
            Random r = new Random();
            for (int i = 0; i < y.Length; i++)
            {
                Coordinates NewCoords = new Coordinates(r);
                y[i] = FindHypotenuse(NewCoords);
                if (y[i] < 1)
                {
                    counter += 1;
                }
            }
            return counter / y.Length * 4;
         
        }

    }
}
