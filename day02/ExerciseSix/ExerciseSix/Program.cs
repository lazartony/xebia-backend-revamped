using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee
            {
                Id = 1,
                Name = "Emp One",
                Salary = 20000
            };
            Employee employee2 = new Employee
            {
                Id = 2,
                Name = "Emp Two",
                Salary = 30000
            };
            employee1.Display();
            employee2.Display();
            Console.WriteLine("\nNo: of Employees : {0}",Employee.Count);
            Console.ReadKey();

        }
    }
}
