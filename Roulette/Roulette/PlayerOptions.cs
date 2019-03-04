using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class PlayerOptions
    {
       public static void Roulette()
        {
            Random random = new Random();
            while (true)
            {
                try
                {
                    string playeroptions1 = "Please preess p to play,q to quit or enter a number";
                    Console.WriteLine(playeroptions1.PadLeft((playeroptions1.Length + Console.WindowWidth) / 2));
                    string playeroptionscontinued= "to check what bets would give you a win should the ball land on that number: ";                   
                    Console.WriteLine(playeroptionscontinued.PadLeft((playeroptionscontinued.Length + Console.WindowWidth) / 2));
                    string selection = Console.ReadLine();
                    if (selection.ToLower() == "q")
                    {
                        break;
                    }
                    if (selection.ToLower() == "p")
                    {
                        SpinClass.Spin();
                    }
                    if (selection == "00")
                    {
                        GetWinsClass.GetWins(37);
                    }
                    else
                    {
                        int value = int.Parse(selection);
                        if (value >= 0 && value <= 36)
                        {
                            GetWinsClass.GetWins(value);
                        }                        
                    }
                }
                catch (Exception)
                {
                    string badentry = "C'mon now, Enter a value between 0 and 36 or 00. Otherwise, there's the door.\n";
                    Console.WriteLine(badentry.PadLeft((badentry.Length + Console.WindowWidth) / 2));
                }
            }
        }
    }
}
