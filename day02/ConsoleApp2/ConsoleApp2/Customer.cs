using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Customer
    {
        private int cid;
        private string cname;
        private string ccity;
        private readonly double cODLimit;
        private static double tax = 12.45;
        public Customer()
        {
            cid = -1;
        }

        public int Id { get { return cid } set { } }
    }

}
