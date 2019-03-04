using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit
{
    internal class Grenedier : Infantry
    {
        public Grenedier(string name, string rank, Weapon weapon = null, Marine supervisor = null) : base(name, rank, weapon, supervisor)
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
                Console.WriteLine($"{this.Rank} {this.Name} provides covering fire for  {this.Team}.");
                this.Weapon.Shoot();
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"{this.Rank} {this.Name} flanks the enemy with {this.Team}.");
                this.Weapon.Shoot();
                Console.ReadKey();
            }
        }
    }
}