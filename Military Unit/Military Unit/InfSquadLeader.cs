using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit
{
    internal class InfSquadLeader : Infantry
    {
        public InfSquadLeader(string name, string rank, Weapon weapon = null, Marine supervisor = null) : base(name, rank, weapon, supervisor)
        {            
            this.Name = Name;
            this.Rank = rank;
            this.Weapon = weapon;
            this.Supervisor = supervisor;
        }
        public override void BattleDrillOneA()
        {
            Console.WriteLine($"{this.Rank} {this.Name} orders Wiskey Tango Foxtrot Team to provide covering fire" +
               $"\n               and manuevers with the Teuful Hunden Team to the objective.");
            Console.ReadKey();
        }
    }
}