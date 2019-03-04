using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class SpinClass
    {
        public static void Spin()
        {           
            Random random = new Random();
            var r = new Random();
            string[] color = { "Red", "Black" };
            string bet;
            int games = 0;
            int betamount;
            int money = 20000;
            while (money != 0)
            {
                string currentchips="Current Chips:$" + money + "          Bets Placed: " + games;
                Console.WriteLine(currentchips.PadLeft((currentchips.Length + Console.WindowWidth) / 2));
                string placebet = "Please place your bet by choosing a letter option below:";
                Console.WriteLine(placebet.PadLeft((placebet.Length + Console.WindowWidth) / 2));
                string eolh = "E)Even    O)Odd    L)Low    H)High";
                Console.WriteLine(eolh.PadLeft((eolh.Length + Console.WindowWidth) / 2));
                string rbf=" R)Red    B)Black    F)1st Dozen";
                Console.WriteLine(rbf.PadLeft((rbf.Length + Console.WindowWidth) / 2));
                string st="   S)2nd Dozen    T)3rd Dozen";
                Console.WriteLine(st.PadLeft((st.Length + Console.WindowWidth) / 2));
                bet = (Console.ReadLine());                
                bet.ToLower();
                bool check = bet == "e" || bet == "o" || bet == "l" || bet == "h" || bet == "r" || bet == "b" || bet == "f" || bet == "s" || bet == "t" || bet == "q";
                if (check == false)
                {
                    string apology = "My apologies. That does not seem to be a proper bet.\n";
                    Console.WriteLine(apology.PadLeft((apology.Length + Console.WindowWidth) / 2));
                    string tryagain = "Please try again and hurry before the ball stops rolling.";
                    Console.WriteLine(tryagain.PadLeft((tryagain.Length + Console.WindowWidth) / 2));
                    Console.ReadKey();
                    continue;
                }
                if(bet.ToLower() == "q")
                    {
                        break;
                    }                
                else
                {
                Betamount:
                    string howmuchtobet= "How much would you like to place on that bet?";
                    Console.WriteLine(howmuchtobet.PadLeft((howmuchtobet.Length + Console.WindowWidth) / 2));
                    betamount = Convert.ToInt32(Console.ReadLine());                  
                    if (betamount > money)
                    {
                        string notenough="It appears that you do not have enough money";
                        Console.WriteLine(notenough.PadLeft((notenough.Length + Console.WindowWidth) / 2));
                        string moremoney = "I suggest you go to the ATM or go home.";
                        Console.WriteLine(moremoney.PadLeft((moremoney.Length + Console.WindowWidth) / 2));
                        string smallerbet = "Press enter to try again with a smaller bet.";
                        Console.WriteLine(smallerbet.PadLeft((smallerbet.Length + Console.WindowWidth) / 2));
                        Console.ReadKey();
                        goto Betamount;
                    }
                    else
                    {
                        money -= betamount;
                        int spin = random.Next(0, 37);
                        string randomColor = color[r.Next(color.Length)];
                        bool even = spin % 2 == 0;
                        if ((((bet == "e") && (even == true))) || 
                           (((bet == "o") && (even == false))) || 
                           ((bet == "r") && (randomColor == "Red") || 
                           (bet == "b") && (randomColor == "Black"))|| 
                           ((bet == "l") && ((spin > 0) && (spin < 19)))||
                           ((bet == "h") && ((spin > 18) && (spin < 37)))||
                           ((bet == "f") && (spin > 0 && spin < 13) || 
                           (bet == "s") && (spin > 12 && spin < 25) ||
                           (bet == "t") && (spin > 24 && spin < 37)))
                        {
                            string landed="The roulette landed on " + randomColor + " " + spin;
                            Console.WriteLine(landed.PadLeft((landed.Length + Console.WindowWidth) / 2));
                            string won="You won! +$" + betamount * 2 + "!";
                            Console.WriteLine(won.PadLeft((won.Length + Console.WindowWidth) / 2));
                            string entertocontinue="<Press enter to continue>";
                            Console.WriteLine(entertocontinue.PadLeft((entertocontinue.Length + Console.WindowWidth) / 2));
                            money += betamount * 2;
                            games += 1;
                            Console.ReadKey();
                        }                       
                        else
                        {
                            string landed = "The roulette landed on " + randomColor + " " + spin;
                            Console.WriteLine(landed.PadLeft((landed.Length + Console.WindowWidth) / 2));
                            string lost="You lost! -$" + betamount + "!";
                            Console.WriteLine(lost.PadLeft((lost.Length + Console.WindowWidth) / 2));
                            string entertocontinue = "<Press enter to continue>";
                            Console.WriteLine(entertocontinue.PadLeft((entertocontinue.Length + Console.WindowWidth) / 2));
                            games += 1;
                            Console.ReadKey();
                            if (money == 0)
                            {
                                string notenough = "It appears that you are out of money";
                                Console.WriteLine(notenough.PadLeft((notenough.Length + Console.WindowWidth) / 2));
                                string moremoney = "I suggest you go to the ATM or go home.";
                                Console.WriteLine(moremoney.PadLeft((moremoney.Length + Console.WindowWidth) / 2));                                
                                Console.WriteLine(entertocontinue.PadLeft((entertocontinue.Length + Console.WindowWidth) / 2));
                                Console.ReadKey();
                            }
                        }
                    }
                }              
            }
        }
    }
}
