using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit
{
    internal class Rucksack : Equipment
    {
        public List<Equipment> Contents = new List<Equipment>();
        public override void Clean()
        {
            Console.WriteLine("Take every single part off of the main frame and SCRUUUUB!");
            Console.ReadKey();
        }
    }
}