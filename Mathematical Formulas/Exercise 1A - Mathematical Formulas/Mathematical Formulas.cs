using System;
namespace Formulas
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine
             ("Hello. Please state your name."
             );
            string name = Console.ReadLine();
            Console.WriteLine
            ("Hello "
            + name
            + "! What would you like to do today?\n"
            + "Press 1 to find the area of a circle\n"
            + "Press 2 to find the circumference of a circle\n"
            + "Press 3 to find the volume of a hemisphere\n"
            + "Press 4 to find the area of a triangle\n"
            + "Press 5 to solve a quadratic equation\n"
            );
            int result = Convert.ToInt32(Console.ReadLine());
            if (result == 1)
            {
                Console.WriteLine
                ("Well "
                + name
                + ", to do that I will need the radius of the circle.\n"
                + "What is it?"
                );
                double radius = Convert.ToInt32(Console.ReadLine());
                double area;
                area = radius * radius * Math.PI;
                Console.WriteLine
                ("The area of your circle is "
                + area
                + "\n Have a nice day!"
                );
                Console.ReadKey();
            }
            else if (result == 2)
            {
                Console.WriteLine
                ("Well "
                + name
                + ", to do that I will need the radius of the circle.\n"
                + "What is it?"
                );
                double radius = Convert.ToInt32(Console.ReadLine());
                double circumference;
                circumference = 2 * Math.PI * radius;
                Console.WriteLine
                ("The circumference of your circle is "
                + circumference
                + "\n Have a nice day!"
                );
                Console.ReadKey();
            }
            else if (result == 3)
            {
                Console.WriteLine
                ("Well "
                + name
                + ", to do that I will need the radius of the hemisphere.\n"
                + "What is it?"
                );
                double radius = Convert.ToInt32(Console.ReadLine());
                double Volume;
                Volume = (((Math.PI * radius * radius * radius) * 4) / 3) / 2;
                Console.WriteLine
                ("The volume of your hemisphere is "
                + Volume
                + "\n Have a nice day!"
                );
                Console.ReadKey();
            }
            else if (result == 4)
            {
                Console.WriteLine
                ("Well "
                + name
                + ", to calculate the area of a triangle I need "
                + "you to give me the length of the sides  A, B, and C. Let's begin!");
                int a, b, c;
                double area, p;
                Console.WriteLine
                ("What is the length of side A: "
                );
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine
                ("What is the length of side B "
                );
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine
                ("What is the length of side C: "
                );
                c = Convert.ToInt32(Console.ReadLine());
                p = (a + b + c) / 2;
                area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine
                ("Thank you! The area of your triangle is: "
                + area
                + "\n Have a nice day!"
                );
            }
            else if (result == 5)
            {
                Console.WriteLine("Well "
                + name
                + ", To solve a quadratic equation,"
                + "I will need the coefficients."
                + "Let's begin!"
                );
                int a, b, c;
                double option1, option2, denominator, first, second;
                Console.WriteLine
                ("Please enter coefficient A: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine
                ("Now please enter coefficient B ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine
                ("Last but not lease, Enter coefficient C: ");
                c = Convert.ToInt32(Console.ReadLine());
                denominator = 2 * a;
                first = -b + (Math.Sqrt((b * b) - (4 * a * c)));
                second = -b - (Math.Sqrt((b * b) - (4 * a * c)));
                option1 = first / denominator;
                option2 = second / denominator;
                Console.WriteLine
                ("Your first possible answer is "
                + option1
                );
                Console.WriteLine
                ("Your second possible answer is  "
                + option2
                + "\n Have a nice day!"
                );
            }
            else
            {
                Console.WriteLine
    ("I'm sorry "
    + name
    + ",I do not know what you want me to do."
    + "GoodBye\n"
    );
            }
            Console.ReadKey();
        }
    }
}
