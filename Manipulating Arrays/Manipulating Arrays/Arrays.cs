namespace Manipulating_Arrays
{
    public class Arrays
    {
        public static int[] A = { 0, 2, 4, 6, 8, 10 };
        public static int[] B = { 1, 3, 5, 7, 9 };
        public static int[] C = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
        public static string Print(int[] X)
        {
            string printedArray = "";
            for (int i = 0; i < X.Length; i++)
            {
                if (i<X.Length-1)
                {
                    printedArray += X[i] + ",";
                }
                else
                {
                    printedArray += X[i];
                }
            }
            return printedArray;
        }
    }


}
