using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit
{
    internal class M4Carbine : Weapon
    {
        public override void Shoot()
        {
            Console.WriteLine("Pow pow pow pow pow");
            Console.ReadKey();
        }
    }
}