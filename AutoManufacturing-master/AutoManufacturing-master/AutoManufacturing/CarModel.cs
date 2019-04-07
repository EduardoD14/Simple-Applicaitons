using System.Collections.Generic;

namespace AutoManufacturing
{
    public class CarModel
    {
        public int Year { get; set; }
        public string Name { get; set; }
        public int StyleID { get; set; }
        public string BodyStyle { get; set; }
        public int NumDoors { get; set; }
    }

    public class DesignDept
    {
        public static List<CarModel> GetNewModels()
        {
            List<CarModel> YearModels = new List<CarModel>();

            YearModels.Add(new CarModel { Year = 2020, Name = "Escargot", StyleID = 20201, BodyStyle = "sedan", NumDoors = 2 });
            YearModels.Add(new CarModel { Year = 2020, Name = "Arachnid", StyleID = 20202, BodyStyle = "fastback", NumDoors = 2 });
            YearModels.Add(new CarModel { Year = 2020, Name = "Platypus", StyleID = 20203, BodyStyle = "utility", NumDoors = 2 });
            YearModels.Add(new CarModel { Year = 2020, Name = "Tomcat", StyleID = 20204, BodyStyle = "convertible", NumDoors = 2 });
            YearModels.Add(new CarModel { Year = 2020, Name = "Chihuahua", StyleID = 20205, BodyStyle = "sedan", NumDoors = 4 });

            return YearModels;
        }
    }
}
