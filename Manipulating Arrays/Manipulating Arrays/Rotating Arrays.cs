using System;

namespace Manipulating_Arrays
{
    public class Rotating_Arrays
    {
        public static string RotateArray(int[] X)
        {
            int[] y = new int[X.Length];
            string RotatedArray ="";
            int temp = X[0];
            for (int i = 1; i <X.Length-1; i++)
            {
                y[i] = X[i-1];
                RotatedArray += y[i] + ",";
            }
                y[X.Length - 1] = temp;
          
            //foreach (int y in X)
            //{
            //    Console.WriteLine(y + " ");
            //}
            return RotatedArray;
        }        
    }
}   
