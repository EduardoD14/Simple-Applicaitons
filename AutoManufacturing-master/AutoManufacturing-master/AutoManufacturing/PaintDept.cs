using System.Collections.Generic;

namespace AutoManufacturing
{
    public class ColorChoice
    {
        public string ColorName { get; set; }
        public int ColorID { get; set; }
    }

    public class PaintDept
    {
        public static List<ColorChoice> GetInitialColorInventory()
        {
            List<ColorChoice> colors = new List<ColorChoice>();

            colors.Add(new ColorChoice { ColorName = "Black", ColorID = 99 });
            colors.Add(new ColorChoice { ColorName = "White", ColorID = 100 });
            colors.Add(new ColorChoice { ColorName = "Red", ColorID = 101 });
            colors.Add(new ColorChoice { ColorName = "Orange", ColorID = 102 });
            colors.Add(new ColorChoice { ColorName = "Yellow", ColorID = 103 });
            colors.Add(new ColorChoice { ColorName = "Green", ColorID = 104 });
            colors.Add(new ColorChoice { ColorName = "Blue", ColorID = 105 });
            colors.Add(new ColorChoice { ColorName = "Violet", ColorID = 106 });

            return colors;
        }
    }
}
