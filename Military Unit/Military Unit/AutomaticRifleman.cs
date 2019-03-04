using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit
{
    internal class AutomaticRifleman : Infantry
    {
        public AutomaticRifleman(string name, string rank, Weapon weapon = null, Marine supervisor = null) : base(name, rank, weapon, supervisor)
        {
            Name = name;
            Rank = rank;
            Weapon = weapon;
            Supervisor = supervisor;
            if (Supervisor.Team != null)
            {
                Team = Supervisor.Team;
            }
        }
        public override void BattleDrillOneA()
        {
            if (Team is "Wiskey Tango Foxtrot Team")
            {
                Console.WriteLine($"{Rank} Torres provides cover for the {Team} while meanuvering down the line.");
                Weapon.Shoot();
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"{Rank} {Name} flanks the enemy with the {Team}.");
                Weapon.Shoot();
                Console.ReadKey();
            }
        }
    }
}