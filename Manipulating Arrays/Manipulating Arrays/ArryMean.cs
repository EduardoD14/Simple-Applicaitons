using System;

namespace Manipulating_Arrays
{
    public class MeanofArray
    {
             //Below is an option that we can use;however, because it is dependent on 
             // other classes perhaps it may not always be the best option.
        public static double ElementAverage(int[] X)
        {
            int count = CountArrayElements.CountElements(X);
            int sum = SumArrayElements.SumElements(X);
            double avg = Convert.ToDouble(sum) / Convert.ToDouble(count);
            return avg;
        }
        // The method below allows us to find the mean without relying on other classes.
        public static double ArrayMean(int[] X)
        {
            int count = 0;
            for (int i = 0; i < X.Length; i++)
            {
                count++;
            }
            int sum = 0;
            foreach (int i in X)
            {
                sum += i;
            }
            double mean = Convert.ToDouble(sum) / Convert.ToDouble(count);
            return mean;
        }
    }
}
