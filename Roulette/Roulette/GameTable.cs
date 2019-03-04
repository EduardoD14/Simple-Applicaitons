using System;

namespace Roulette
{
    public class GameTableClass
    {        
        readonly int[,] table = new int[12, 3]
        {
             { 1, 2, 3 },
             { 4, 5, 6 },
             { 7, 8, 9 },
            { 10, 11, 12 },
            { 13, 14, 15 },
            { 16, 17, 18 },
            { 19, 20, 21 },
            { 22, 23, 24 },
            { 25, 26, 27 },
            { 28, 29, 30 },
            { 31, 32, 33 },
            { 34, 35, 36 }
        };       
        readonly int[] black = new int[18] { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
        readonly int[] red = new int[18] { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
        public int GetNum(int row, int column) 
        {
            return table[row, column];
        }
        public string GetColor(int i) 
        {
            string color = null;
            if (i == 0 || i == 37)
            {
                color = "green";
            }
            foreach (int c in black)
            {
                if (c == i)
                {
                    color = "black";
                }
            }
            foreach (int c in red)
            {
                if (c == i)
                {
                    color = "red";
                }
            }
            return color;
        }
        public int Column(int i) 
        {
            for (int row = 0; row < 12; row++) 
            {
                for (int column = 0; column < 3; column++) 
                {
                    if (table[row, column] == i)
                    {
                        return column;
                    }
                }
            }
            return -1;
        }
        public int Row(int i) 
        {
            for (int row = 0; row < 12; row++) 
            {
                for (int column = 0; column < 3; column++) 
                {
                    if (table[row, column] == i) 
                    {
                        return row;
                    }
                }
            }
            return -1;
        }     
    }
}
    

