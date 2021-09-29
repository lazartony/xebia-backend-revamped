using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSeven
{
    class HerbalProduct:Product
    {
        private string herbsUsed;
        private DateTime mfDate, expDate;

        public override void SetData()
        {
            base.SetData();
            Console.Write("Enter the herbs used");
            herbsUsed = Console.ReadLine();
            Console.Write("Enter the manufacturing date");
            mfDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter the expiry date");
            expDate = DateTime.Parse(Console.ReadLine());
        }
        public override void DisplayData()
        {
            base.DisplayData();
            Console.WriteLine("\nHerbs Used : {0}\nManufacturing Date : {1}\nExpiry Date : {2}", herbsUsed, mfDate, expDate);
        }
    }
}
