using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulating_Arrays
{
    class SumArrayElements
    {
        public static int SumElements(int[] X)
        {
            int sum = 0;
            foreach (int i in X)
            {
                sum += i;
            }
            return sum;
        }
    }
}
