using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulating_Arrays
{
    class CountArrayElements
    {
        public static int CountElements(int[] X)
        {
            int count = 0;
            for (int i = 0; i < X.Length; i++)
            {
                count++;
            }
            return count;
        }
    }
}
