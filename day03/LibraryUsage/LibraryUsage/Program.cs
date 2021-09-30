using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcLib;

namespace LibraryUsage
{
    public static class ExtensionClass
    {
        public static void Welcome(this Calculator obj)
        {
            Console.WriteLine("hai");
        }
        public static double Max(this Calculator obj, double n1, double n2)
        {
            if (n1 > n2)
            {
                return n1;
            }
            else
            {
                return n2;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.Welcome();
            double n1, n2;
            char ch;
            do
            {
                Console.Write("Enter the first number : ");
                n1 = double.Parse(Console.ReadLine());
                Console.Write("Enter the second number : ");
                n2 = double.Parse(Console.ReadLine());

                Console.WriteLine("\nAdd({0},{1}) = {2}", n1, n2, calculator.Add(n1, n2));
                Console.WriteLine("Diff({0},{1}) = {2}", n1, n2, calculator.Diff(n1, n2));
                Console.WriteLine("Mul({0},{1}) = {2}", n1, n2, calculator.Mul(n1, n2));
                Console.WriteLine("Div({0},{1}) = {2}", n1, n2, calculator.Div(n1, n2));
                Console.WriteLine("Avg({0},{1}) = {2}", n1, n2, calculator.Avg(n1, n2));
                Console.WriteLine("Max({0},{1}) = {2}", n1, n2, calculator.Max(n1, n2));


                Console.Write("\nEnter <y> to continue: ");
                ch = char.Parse(Console.ReadLine());
                Console.WriteLine("\n=================================\n");

            } while (ch == 'y');
        }
    }
}
