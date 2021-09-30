using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseThree
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, Customer> customerList = new SortedList<int, Customer>() {
                {1, new Customer() { CName = "Name One", CCity = "City One", CODLimt = 10000 } },
                {2, new Customer() { CName = "Name Two", CCity = "City Two", CODLimt = 10000 } },
                {3, new Customer() { CName = "Name Three", CCity = "City Three", CODLimt = 20000 } },
                {4, new Customer() { CName = "Name Four", CCity = "City Four", CODLimt = 10000 } },
                {5, new Customer() { CName = "Name Five", CCity = "City Five", CODLimt = 10000 } } };


        }
        public void deleteRecord(SortedList<int, Customer> customerList, int index)
        {
            customerList.Remove(index);
        }
    }
}
