using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                DoThings();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        private static void DoThings()
        {
            InfPlatoonLeader pl = new InfPlatoonLeader("Cooper", "1LT", new M4Carbine());
            InfPlatoonSergeant psg = new InfPlatoonSergeant("Bradley", "SGT", new M4Carbine(), pl);
            InfSquadLeader sl = new InfSquadLeader("Davis", "SSGT", supervisor: psg);
            InfTeamLeader atl = new InfTeamLeader("Torres", "SGT", supervisor: sl);
            InfTeamLeader btl = new InfTeamLeader("Birney", "SGT", supervisor: sl)
            {
                Team = "Teuful Hunden Team"
            };
            Rifleman grunt1 = new Rifleman("Lankford, Rifleman", "CPL", supervisor: atl);
            Rifleman grunt2 = new Rifleman("Velazquez, Rifleman", "CPL", supervisor: btl);
            Grenedier grunt3 = new Grenedier("Prassas, Grenedier", "LCPL", supervisor: atl);
            Grenedier grunt4 = new Grenedier("Raya, Grenedier", "LCPL", supervisor: btl);
            AutomaticRifleman grunt5 = new AutomaticRifleman("Wilson, SAW Gunner", "PVT", supervisor: atl);
            AutomaticRifleman grunt6 = new AutomaticRifleman("Nelson, SAW Gunner", "PVT", supervisor: btl);
            Infantry[] firstSquad = new Infantry[9] { sl, atl, btl, grunt1, grunt2, grunt3, grunt4, grunt5, grunt6 };
            GetWeapons(firstSquad);
            grunt1.AddEquip.Add(new Rucksack());
            grunt2.AddEquip.Add(new Rucksack());
            pl.BattleDrillOneA();
            SquadAssault(firstSquad);
            psg.BattleDrillOneA();
            Console.WriteLine($"\nAfter Mission, {psg.Rank} {psg.Name} orders the squad to clean their equipment until it is brand new otherwise CIF will send them back 100 times");
            CleanEquip(firstSquad);
            Console.WriteLine("Until the end of time..");
            Console.ReadKey();
        }
        private static void SquadAssault(Infantry[] i)
        {
            foreach (Infantry soldier in i)
            {
                if (i[0].Weapon is null)
                {
                    Console.WriteLine("The unit cannot complete the mission. Properly equip them!");
                    return;
                }
            }
            foreach (Infantry soldier in i)
            {
                if (soldier.Team is null)
                {
                    soldier.BattleDrillOneA();
                }
            }
            foreach (Infantry soldier in i)
            {
                if (soldier.Team is "Wiskey Tango Foxtrot Team")
                {
                    soldier.BattleDrillOneA();
                }
            }
            foreach (Infantry soldier in i)
            {
                if (soldier.Team is "Teuful Hunden Team")
                {
                    soldier.BattleDrillOneA();
                }
            }
        }
        private static void GetWeapons(Infantry[] i)
        {
            foreach (Infantry soldier in i)
            {
                if (soldier.GetType().Name is "AutomaticRifleman")
                {
                    soldier.Weapon = new M249();
                }
                else if (soldier.GetType().Name is "Grenedier")
                {
                    soldier.Weapon = new M4with203();
                }
                else
                {
                    soldier.Weapon = new M4Carbine();
                }
            }
        }
        private static void CleanEquip(Infantry[] i)
        {
            foreach (Infantry soldier in i)
            {
                Console.WriteLine($"{soldier.Rank} {soldier.Name} cleans his equipment:");
                soldier.Weapon.Clean();
                foreach (Equipment e in soldier.AddEquip)
                {
                    e.Clean();
                }
            }
        }
    }

}