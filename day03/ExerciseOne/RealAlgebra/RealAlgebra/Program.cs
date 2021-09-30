using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeAreaLib;

namespace RealAlgebra
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = '0';
            while (ch != '5')
            {
                Console.Write("\n1-Rectangle\n2-Square\n3-Circle\n4-Triangle\n5-Exit\nEnter your choice : ");
                ch = char.Parse(Console.ReadLine());
                switch (ch)
                {
                    case '1':
                        Console.Write("Enter the Length: ");
                        double length = double.Parse(Console.ReadLine());
                        Console.Write("Enter the Width: ");
                        double width = double.Parse(Console.ReadLine());
                        Console.WriteLine("\nArea = {0}", Rectangle.Area(length, width));
                        break;
                    case '2':
                        Console.Write("Enter the length of a side: ");
                        double sideLength = double.Parse(Console.ReadLine());
                        Console.WriteLine("\nArea = {0}", Square.Area(sideLength));
                        break;
                    case '3':
                        Console.Write("Enter the Radius: ");
                        double radius = double.Parse(Console.ReadLine());
                        Console.WriteLine("\nArea = {0}", Circle.Area(radius));
                        break;
                    case '4':
                        Console.Write("Enter the height: ");
                        double height = double.Parse(Console.ReadLine());
                        Console.Write("Enter the length of base: ");
                        double baseLength = double.Parse(Console.ReadLine());
                        Console.WriteLine("\nArea = {0}", Triangle.Area(height, baseLength));
                        break;
                    case '5':
                        Console.WriteLine("Invalid Input");
                        break;
                    default:
                        break;
                }
                Console.WriteLine("\n===============================\n");
            }
        }
    }
}
