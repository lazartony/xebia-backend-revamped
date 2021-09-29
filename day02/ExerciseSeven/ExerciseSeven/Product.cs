using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSeven
{
    class Product
    {
        private int pid;
        private string pname;
        private float pprice;

        public virtual void SetData()
        {
            Console.Write("Enter the Product ID");
            pid = int.Parse(Console.ReadLine());
            Console.Write("Enter the Product ID");
            pname = Console.ReadLine();
            Console.Write("Enter the Product ID");
            pprice = float.Parse(Console.ReadLine());
        }
        public virtual void DisplayData()
        {
            Console.WriteLine("\nID : {0}\nName : {1}\nPrice : {2}",pid,pname,pprice);
        }
    }
}
