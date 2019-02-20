using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulating_Arrays
{
    public class Prints
    {
       public static void Main(string[] args)
       {
           Console.WriteLine("The elements in array A are:" + Arrays.Print(Arrays.A));
           Console.WriteLine("The mean of the elements in Array A is : " + MeanofArray.ArrayMean(Arrays.A));
           Console.WriteLine("The mean of the elements in Array B is : " + MeanofArray.ArrayMean(Arrays.B));
           Console.WriteLine("The mean of the elements in Array C is : " + MeanofArray.ArrayMean(Arrays.C));
           Console.WriteLine("Array A in reverse is: " + Reversing_Arrays.ReverseArray(Arrays.A));
           Console.WriteLine("Array B in reverse is: " + Reversing_Arrays.ReverseArray(Arrays.B));
           Console.WriteLine("Array C in reverse is: " + Reversing_Arrays.ReverseArray(Arrays.C));
           Console.WriteLine("Array A in rotated to the right one time is: " + Rotating_Arrays.RotateArray(Arrays.A,1));
           Console.ReadKey();      
       }
    }
}
