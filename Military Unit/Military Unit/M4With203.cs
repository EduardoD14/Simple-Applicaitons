using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit
{
    internal class M4with203 : Weapon
    {
        public override void Shoot()
        {
            Console.WriteLine("Pew pew pew pew shuckkk..peeeeeeewwwwww PWHUAABBBooooom!");
            Console.ReadKey();
        }
    }
}