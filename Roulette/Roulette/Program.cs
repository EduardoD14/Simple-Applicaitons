using System;

namespace Roulette
{
    class Program
    {
       
        public static GameTableClass table = new GameTableClass();
        static void Main(string[] args)
        {
            Console.Title = "Davila's Casino - Roulette Table";
            Console.WindowHeight = 50;
            Console.WindowWidth = 100;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            try
            {
                string Welcome = "Hello there! Welcome to Davila's CASINO!";
                Console.WriteLine(Welcome.PadLeft((Welcome.Length +Console.WindowWidth)/2));
                string FindPlayerName = ("Now, Before we get started, what is your name? Please enter it now: ");
                Console.WriteLine("\n"+FindPlayerName.PadLeft((FindPlayerName.Length+Console.WindowWidth)/2));
                string PlayerName= Console.ReadLine();
                String Intro = "Hello " + PlayerName + "! Welcome to the roulette table!\n";
                Console.WriteLine(Intro.PadLeft((Intro.Length + Console.WindowWidth )/2));
                PlayerOptions.Roulette(); 
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }  
    }
}