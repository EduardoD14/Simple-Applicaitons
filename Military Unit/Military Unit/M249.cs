using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit
{
    internal class M249 : Weapon
    {
        public override void Shoot()
        {
            Console.WriteLine("Pew pew pew pew pew pew");
            Console.ReadKey();
        }
        public override void Clean()
        {
            Console.WriteLine("Clean clean clean! Spit and shine.");
            Console.ReadKey();
        }
    }
}