namespace Manipulating_Arrays
{
    public class Rotating_Arrays
    {
        public static string RotateArray(int[] X, string direction, int cycles)
        {
            string RotatedArr = (direction == "left" ? RotateArrayLeft(X, cycles) : RotateArrayRight(X, cycles));
            return RotatedArr;
        }
        public static string RotateArrayLeft(int[] X, int cycles)
        {
            int[] y = new int[X.Length];
            for (int i = 0; i < X.Length; i++)
            {
                if ((i + cycles) > X.Length - 1)
                {
                    y[i] = X[i - X.Length + cycles];
                }
                if ((i + cycles) < X.Length)
                {
                    y[i] = X[i + cycles];
                }
            }
            string RotatedArray = Arrays.Print(y);
            return RotatedArray;
        }
        public static string RotateArrayRight(int[] X, int cycles)
        {
            int[] y = new int[X.Length];
            for (int i = X.Length - 1; i >= 0; i--)
            {
                if ((i + cycles) > X.Length - 1)
                {
                    y[i] = X[i - X.Length + cycles];
                }
                if ((i + cycles) < X.Length)
                {
                    y[i] = X[i + cycles];
                }
            }
            string RotatedArray = Arrays.Print(y);
            return RotatedArray;
        }
    }
}
