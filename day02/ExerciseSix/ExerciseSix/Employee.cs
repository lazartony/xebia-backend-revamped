using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSix
{
    class Employee
    {
        private int id;
        private string name;
        private float salary;
        private static int count = 0;

        public Employee()
        {
            count += 1;
        }
        public int Id { get { return id; } set { id = value; } }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length > 6)
                {
                    name = value;
                }
                else
                {
                    name = "invalid name";
                }
            }
        }
        public float Salary { get { return salary; } set { salary = value; } }
        public static int Count { get { return count; } }
        public void Display()
        {
            Console.WriteLine("\nId : {0}\nName : {1}\nSalary : {2}", Id, Name, Salary);
        }
    }
}
