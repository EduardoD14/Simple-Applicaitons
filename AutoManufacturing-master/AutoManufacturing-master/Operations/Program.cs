using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoManufacturing;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            // get the color list
            Console.WriteLine("\n\tnew colors!");
            List<ColorChoice> colors = PaintDept.GetInitialColorInventory();
            foreach (var c in colors)
            {
                Console.WriteLine($" {c.ColorName}");
            }

            // get the model list
            Console.WriteLine("\n\tnew models!");
            List < CarModel> models = DesignDept.GetNewModels();
            foreach (var m in models)
            {
                Console.WriteLine($" {m.Year} {m.Name}");
            }
            Console.ReadKey();


            // add to traffic
            Console.WriteLine("\n\tavailable inventory!");
            List < Cars> newCars = ProductionLine.BuildCars(30, colors.Count, models.Count);
            foreach (var car in newCars)
            {
                // TODO: Fix this display to show color and model names!
                Console.WriteLine($" {car.BuildDate.Year} {car.Style} {car.color}");
            }
        }
    }
}
