using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee
    {
        readonly int id;
        readonly string name;
        public Employee(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
        public virtual void Display()
        {
            Console.WriteLine("\nID : {0}\nName : {1}",id,name);
        }
    }
}
