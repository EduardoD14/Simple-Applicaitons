using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit
{
    internal class Infantry : Marine
    {
        public Infantry(string name, string rank, Weapon weapon = null, Marine supervisor = null) : base(name, rank, weapon, supervisor)
        {
            this.Name = name;
            this.Rank = rank;
            this.Weapon = weapon;
            this.Supervisor = supervisor;
        }
        public virtual void BattleDrillOneA()
        {
            Console.WriteLine("Default Implementation of Battle Drill 1A.");
            Console.ReadKey();
        }
    }
}