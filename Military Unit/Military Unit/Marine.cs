using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit
{
    internal class Marine
    {
        public string Name { get; set; }
        public string Rank { get; set; }
        public Weapon Weapon { get; set; }
        public Marine Supervisor { get; set; }
        public List<Equipment> AddEquip = new List<Equipment>();
        public string Team { get; set; }
        public Marine(string name, string rank, Weapon weapon = null, Marine supervisor = null)
        {
            Name = name;
            Rank = rank;
            Weapon = weapon;
            Supervisor = supervisor;
        }
    }
}