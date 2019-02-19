namespace Manipulating_Arrays
{
    public class Reversing_Arrays
    {
        public static string ReverseArray(int[] X)
        {
            string ReversedArray = "";
            int[] ArrayReversed = new int[X.Length];

            for (int j = X.Length - 1; j >= 0; j--)
            {
                for (int i = 0; i < X.Length; i++)
                {
                    ArrayReversed[i] = X[j];
                }
                if (j > 0)
                {
                    ReversedArray += ArrayReversed[j] + ",";
                }
                else
                {
                    ReversedArray += ArrayReversed[j];
                }
            }
            return ReversedArray;
        }
    }
}
