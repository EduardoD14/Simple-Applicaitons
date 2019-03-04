using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit
{
    internal class Weapon : Equipment
    {
        public override void Clean()
        {
            Console.WriteLine("1Lt says: I SEE BLACK!! Automatic Weapons failure. AGAIN! ");
            Console.ReadKey();
        }
        public virtual void Shoot()
        {
            Console.WriteLine($"The {GetType().Name} fires.");
            Console.ReadKey();
        }
    }
}