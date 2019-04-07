using System;
using System.Collections.Generic;

namespace AutoManufacturing
{
    public class Cars
    {
        public static Random pseudo = new Random();
        // TODO: create private VIN field and make property readonly
        public string VIN { get; set; }

        // TODO: create private field and make readonly
        public DateTime BuildDate { get; set; }

        // TODO: add validation against available car models
        public int Style { get; set; }
        public int color { get; set; }
    }

    public class ProductionLine
    {
        const int MAXCOUNT = 25;

        public static List<Cars> BuildCars(int maxCount = MAXCOUNT, int nrColors = 1, int nrStyles = 5)
        {
            List<Cars> ProductionRun = new List<Cars>();

            for( int count=0; count<maxCount; count++ )
            ProductionRun.Add(new Cars
            {
                VIN = "XX" + Cars.pseudo.Next(1000),
                Style = 20200 + (count % nrStyles),
                BuildDate = DateTime.Today,
                color = 99 + (count % nrColors)
            });

            return ProductionRun;
        }
    }
}
