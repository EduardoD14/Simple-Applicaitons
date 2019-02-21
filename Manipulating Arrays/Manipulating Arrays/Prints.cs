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
           Console.WriteLine("The elements in array B are:" + Arrays.Print(Arrays.B));
           Console.WriteLine("The elements in array C are:" + Arrays.Print(Arrays.C));
           Console.WriteLine("The mean of the elements in Array A is : " + MeanofArray.ArrayMean(Arrays.A));
           Console.WriteLine("The mean of the elements in Array B is : " + MeanofArray.ArrayMean(Arrays.B));
           Console.WriteLine("The mean of the elements in Array C is : " + MeanofArray.ArrayMean(Arrays.C));
           Console.WriteLine("Array A in reverse is: " + Reversing_Arrays.ReverseArray(Arrays.A));
           Console.WriteLine("Array B in reverse is: " + Reversing_Arrays.ReverseArray(Arrays.B));
           Console.WriteLine("Array C in reverse is: " + Reversing_Arrays.ReverseArray(Arrays.C));
           Console.WriteLine("Array A in rotated to the left two times is: " + Rotating_Arrays.RotateArray(Arrays.A,"Left",2));
           Console.WriteLine("Array B in rotated to the right two times is: " + Rotating_Arrays.RotateArray(Arrays.B,"Right",2));
           Console.WriteLine("Array C in rotated to the left four times is: " + Rotating_Arrays.RotateArray(Arrays.C,"Left", 4));
           Console.WriteLine("Array C sorted is: " + Sorting_Arrays.SortArray(Arrays.C));
           Console.ReadKey();      
       }
    }
}
