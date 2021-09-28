using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Developer:Employee
    {
        string domain;
        string project;
        public Developer(int id, string name, string domain, string project):base(id,name)
        {
            this.domain = domain;
            this.project = project;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Domain : {0}\nProject : {1}", domain, project);
        }
    }
}
