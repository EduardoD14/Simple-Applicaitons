using System;

namespace Manipulating_Arrays
{
    public class Rotating_Arrays
    {
        public static string RotateArray(int[] X,int cycles)
        {
            int[] y = new int[X.Length];
            string RotatedArray ="";
            for (int i = 0; i > X.Length-1; i++)
            {
                if (X[i + cycles] > X.Length)
                {
                    y[i] = X[i - X.Length - 1];
                }
                else
                {
                    y[i] = X[i + cycles];
                }
                RotatedArray += y[i] + ",";
            }
                
            return RotatedArray;
        }        
    }
}   
