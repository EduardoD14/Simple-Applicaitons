using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulating_Arrays
{
    class Sorting_Arrays
    {
        public static string SortArray(int []X)
        {
            string SortedArray="";
            int temp = 0;
            for (int i = 0; i < X.Length; i++)
            {
                for (int j = 0; j < X.Length-1;j++)
                {
                    if (X[j] > X[j + 1])
                    {
                        temp = X[j+ 1];
                        X[j + 1] = X[j];
                        X[j] = temp;
                    }
                }
            }
            for (int i = 0; i < X.Length; i++)
            {
                if (i < X.Length-1)
                {
                    SortedArray += X[i] + ",";
                }
                else
                {
                    SortedArray += X[i];
                }

            }
            return SortedArray;
        }
    }
}
