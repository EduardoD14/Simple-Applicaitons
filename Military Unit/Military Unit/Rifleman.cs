using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit
{
    internal class Rifleman : Infantry
    {
        public Rifleman(string name, string rank, Weapon weapon = null, Marine supervisor = null) : base(name, rank, weapon, supervisor)
        {
            this.Name = name;
            this.Rank = rank;
            this.Weapon = weapon;
            this.Supervisor = supervisor;
            if (this.Supervisor.Team != null)
            {
                this.Team = this.Supervisor.Team;
            }
        }
        public override void BattleDrillOneA()
        {
            if (this.Team is "Wiskey Tango Foxtrot Team")
            {
                Console.WriteLine($"{this.Rank} {this.Name} manuevers on-line with the {this.Team} to provide covering fire.");
                this.Weapon.Shoot();
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"{this.Rank} {this.Name} manuevers with {this.Team} to flank the enemy.");
                this.Weapon.Shoot();
                Console.ReadKey();
            }
        }
    }
}