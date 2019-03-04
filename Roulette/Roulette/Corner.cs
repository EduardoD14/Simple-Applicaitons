using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class CornerClass
    {
        public static string Corner(int i) 
        {
            if (Program.table.Column(i) == 0) 
            {
                if (Program.table.Row(i) == 0)
                {
                    return $"({Program.table.GetNum(Program.table.Row(i), Program.table.Column(i))}," +
                       $" {Program.table.GetNum(Program.table.Row(i), (Program.table.Column(i) + 1))}," +
                        $" {Program.table.GetNum((Program.table.Row(i) + 1), Program.table.Column(i))}," +
                        $" {Program.table.GetNum((Program.table.Row(i) + 1), (Program.table.Column(i) + 1))})";
                }
                else if (Program.table.Row(i) == 11)
                {

                    return $"({Program.table.GetNum((Program.table.Row(i) - 1), Program.table.Column(i))}," +
                          $" {Program.table.GetNum((Program.table.Row(i) - 1), (Program.table.Column(i) + 1))}," +
                          $" {Program.table.GetNum(Program.table.Row(i), Program.table.Column(i))}," +
                        $" {Program.table.GetNum(Program.table.Row(i), (Program.table.Column(i) + 1))}),";
                }
                else
                {
                    return $"({Program.table.GetNum((Program.table.Row(i) - 1), Program.table.Column(i))}," +
                        $" {Program.table.GetNum((Program.table.Row(i) - 1), (Program.table.Column(i) + 1))}," +
                         $" {Program.table.GetNum(Program.table.Row(i), Program.table.Column(i))}," +
                         $" {Program.table.GetNum(Program.table.Row(i), (Program.table.Column(i) + 1))})," +
                         $" ({Program.table.GetNum(Program.table.Row(i), Program.table.Column(i))}," +
                         $" {Program.table.GetNum(Program.table.Row(i), (Program.table.Column(i) + 1))}," +
                        $" {Program.table.GetNum((Program.table.Row(i) + 1), Program.table.Column(i))}," +
                         $" {Program.table.GetNum((Program.table.Row(i) + 1), (Program.table.Column(i) + 1))})";
                }
            }
            else if (Program.table.Column(i) == 1)
            {
                if (Program.table.Row(i) == 0)
                {
                    return $"({Program.table.GetNum(Program.table.Row(i), (Program.table.Column(i) - 1))}," +
                       $" {Program.table.GetNum(Program.table.Row(i), Program.table.Column(i))}," +
                        $" {Program.table.GetNum((Program.table.Row(i) + 1), (Program.table.Column(i) - 1))}," +
                        $" {Program.table.GetNum((Program.table.Row(i) + 1), Program.table.Column(i))})," +
                        $" ({Program.table.GetNum(Program.table.Row(i), Program.table.Column(i))}," +
                        $" {Program.table.GetNum(Program.table.Row(i), (Program.table.Column(i) + 1))}," +
                     $" {Program.table.GetNum((Program.table.Row(i) + 1), Program.table.Column(i))}," +
                      $" {Program.table.GetNum((Program.table.Row(i) + 1), (Program.table.Column(i) + 1))})";
                }
                else if (Program.table.Row(i) == 11)
                {
                    return $"({Program.table.GetNum((Program.table.Row(i) - 1), (Program.table.Column(i) - 1))}," +
                      $" {Program.table.GetNum((Program.table.Row(i) - 1), Program.table.Column(i))}," +
                       $" {Program.table.GetNum(Program.table.Row(i), (Program.table.Column(i) - 1))}," +
                       $" {Program.table.GetNum(Program.table.Row(i), Program.table.Column(i))})," +
                       $" ({Program.table.GetNum((Program.table.Row(i) - 1), Program.table.Column(i))}," +
                        $" {Program.table.GetNum((Program.table.Row(i) - 1), (Program.table.Column(i) + 1))}," +
                        $" {Program.table.GetNum(Program.table.Row(i), Program.table.Column(i))}," +
                      $" {Program.table.GetNum(Program.table.Row(i), (Program.table.Column(i) + 1))})";
                }
                else
                {
                    return $"" +
                        $"({Program.table.GetNum((Program.table.Row(i) - 1), (Program.table.Column(i) - 1))}," +
                       $" {Program.table.GetNum((Program.table.Row(i) - 1), Program.table.Column(i))}," +
                        $" {Program.table.GetNum(Program.table.Row(i), (Program.table.Column(i) - 1))}," +
                      $" {Program.table.GetNum(Program.table.Row(i), Program.table.Column(i))})," +
                      $" ({Program.table.GetNum((Program.table.Row(i) - 1), Program.table.Column(i))}," +
                     $" {Program.table.GetNum((Program.table.Row(i) - 1), (Program.table.Column(i) + 1))}," +
                      $" {Program.table.GetNum(Program.table.Row(i), Program.table.Column(i))}," +
                      $" {Program.table.GetNum(Program.table.Row(i), (Program.table.Column(i) + 1))})," +
                        $" ({Program.table.GetNum(Program.table.Row(i), (Program.table.Column(i) - 1))}," +
                        $" {Program.table.GetNum(Program.table.Row(i), Program.table.Column(i))}," +
                     $" {Program.table.GetNum((Program.table.Row(i) + 1), (Program.table.Column(i) - 1))}," +
                       $" {Program.table.GetNum((Program.table.Row(i) + 1), Program.table.Column(i))})," +
                       $" ({Program.table.GetNum(Program.table.Row(i), Program.table.Column(i))}," +
                      $" {Program.table.GetNum(Program.table.Row(i), (Program.table.Column(i) + 1))}," +
                        $" {Program.table.GetNum((Program.table.Row(i) + 1), Program.table.Column(i))}," +
                    $" {Program.table.GetNum((Program.table.Row(i) + 1), (Program.table.Column(i) + 1))})" +
                      $"";
                }
            }
            else
            {
                if (Program.table.Row(i) == 0)
                {
                    return $"({Program.table.GetNum(Program.table.Row(i), (Program.table.Column(i) - 1))}," +
                         $" {Program.table.GetNum(Program.table.Row(i), Program.table.Column(i))}," +
                       $" {Program.table.GetNum((Program.table.Row(i) + 1), (Program.table.Column(i) - 1))}," +
                       $" {Program.table.GetNum((Program.table.Row(i) + 1), Program.table.Column(i))})";
                }
                else if (Program.table.Row(i) == 11)
                {
                    return $"({Program.table.GetNum((Program.table.Row(i) - 1), (Program.table.Column(i) - 1))}," +
                       $" {Program.table.GetNum((Program.table.Row(i) - 1), Program.table.Column(i))}," +
                       $" {Program.table.GetNum(Program.table.Row(i), (Program.table.Column(i) - 1))}," +
                         $" {Program.table.GetNum(Program.table.Row(i), Program.table.Column(i))})";
                }
                else
                {
                    return $"({Program.table.GetNum((Program.table.Row(i) - 1), (Program.table.Column(i) - 1))}," +
                        $" {Program.table.GetNum((Program.table.Row(i) - 1), Program.table.Column(i))}," +
                        $" {Program.table.GetNum(Program.table.Row(i), (Program.table.Column(i) - 1))}," +
                        $" {Program.table.GetNum(Program.table.Row(i), Program.table.Column(i))})," +
                        $" ({Program.table.GetNum(Program.table.Row(i), (Program.table.Column(i) - 1))}," +
                        $" {Program.table.GetNum(Program.table.Row(i), Program.table.Column(i))}," +
                       $" {Program.table.GetNum((Program.table.Row(i) + 1), (Program.table.Column(i) - 1))}," +
                       $" {Program.table.GetNum((Program.table.Row(i) + 1), Program.table.Column(i))})";
                }
            }
        }
    }
}
