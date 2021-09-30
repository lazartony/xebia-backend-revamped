using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseThree
{
    class Customer
    {
        private string cName, cCity;
        private float cODLimit;
        public string CName { get => cName; set { cName = value; } }
        public string CCity { get { return cCity; } set { cCity = value; } }
        public float CODLimt { get { return cODLimit; } set { cODLimit = value; } }
    }
}
