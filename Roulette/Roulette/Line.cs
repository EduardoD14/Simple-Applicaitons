using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class LineClass
    {
        public static string Line(int i)
        {
            if (Program.table.Row(i) == 0)
            {
                return $"({Program.table.GetNum(Program.table.Row(i), 0)}," +
                $" {Program.table.GetNum(Program.table.Row(i), 1)}," +
               $" {Program.table.GetNum(Program.table.Row(i), 2)}," +
                $" {Program.table.GetNum((Program.table.Row(i) + 1), 0)}," +
                $" {Program.table.GetNum((Program.table.Row(i) + 1), 1)}," +
               $" {Program.table.GetNum((Program.table.Row(i) + 1), 2)})";
            }
            else if (Program.table.Row(i) == 11)
            {
                return $"({Program.table.GetNum((Program.table.Row(i) - 1), 0)}," +
                $" {Program.table.GetNum((Program.table.Row(i) - 1), 1)}," +
                $" {Program.table.GetNum((Program.table.Row(i) - 1), 2)}," +
                $" {Program.table.GetNum(Program.table.Row(i), 0)}," +
                $" {Program.table.GetNum(Program.table.Row(i), 1)}," +
               $" {Program.table.GetNum(Program.table.Row(i), 2)})";
            }
            else
            {
                return $"({Program.table.GetNum((Program.table.Row(i) - 1), 0)}," +
                $" {Program.table.GetNum((Program.table.Row(i) - 1), 1)}," +
               $" {Program.table.GetNum((Program.table.Row(i) - 1), 2)}," +
              $" {Program.table.GetNum(Program.table.Row(i), 0)}," +
               $" {Program.table.GetNum(Program.table.Row(i), 1)}," +
                $" {Program.table.GetNum(Program.table.Row(i), 2)}), " +
                $" ({Program.table.GetNum(Program.table.Row(i), 0)}," +
               $" {Program.table.GetNum(Program.table.Row(i), 1)}," +
                $" {Program.table.GetNum(Program.table.Row(i), 2)}," +
                $" {Program.table.GetNum((Program.table.Row(i) + 1), 0)}," +
                $" {Program.table.GetNum((Program.table.Row(i) + 1), 1)}," +
                $" {Program.table.GetNum((Program.table.Row(i) + 1), 2)})";
            }
        }
    }
}
