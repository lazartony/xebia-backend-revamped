using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(1,"Name One");
            Employee employee2 = new Employee(2,"Name Two");
            Developer developer1 = new Developer(3, "Name Three","Sample Domain", "Sample Project");


            employee1.Display();
            employee2.Display();
            developer1.Display();

            Console.ReadKey();
        }
    }
}
