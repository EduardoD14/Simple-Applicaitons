using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit
{
    internal class InfTeamLeader : Infantry
    {
        public InfTeamLeader(string name, string rank, Weapon weapon = null, Marine supervisor = null) : base(name, rank, weapon, supervisor)
        {
            this.Name = name;
            this.Rank = rank;
            this.Weapon = weapon;
            this.Supervisor = supervisor;
            this.Team = "Wiskey Tango Foxtrot Team";
        }
        public override void BattleDrillOneA()
        {
            if (this.Team is "Wiskey Tango Foxtrot Team")
            {
                Console.WriteLine($"{this.Rank} {this.Name} manuevers with the {this.Team} on-line to provide covering fire.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"{this.Rank} {this.Name} manuevers the {this.Team} to flank the enemy.");
                Console.ReadKey();
            }
        }
    }
}