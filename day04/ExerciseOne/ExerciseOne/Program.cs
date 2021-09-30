using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOne
{
    public delegate void SpinDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            SpinDelegate spinDelegate = null;
            int spins = 5;
            while (spins>0)
            {
                int luckyNumber;
                Console.Write("Enter your lucky number (1 - 10) : ");
                luckyNumber = int.Parse(Console.ReadLine());
                switch (luckyNumber)
                {
                    case 1:
                        spinDelegate += game.FirstSpin;
                        break;
                    case 2:
                        spinDelegate += game.SecondSpin;
                        break;
                    case 3:
                        spinDelegate += game.ThirdSpin;
                        break;
                    case 4:
                        spinDelegate += game.FourthSpin;
                        break;
                    case 5:
                        spinDelegate += game.FifthtSpin;
                        break;
                    case 6:
                        spinDelegate += game.SixthSpin;
                        break;
                    case 7:
                        spinDelegate += game.SeventhtSpin;
                        break;
                    case 8:
                        spinDelegate += game.EightSpin;
                        break;
                    case 9:
                        spinDelegate += game.NinthSpin;
                        break;
                    case 10:
                        spinDelegate += game.TenthSpin;
                        break;

                    default:
                        break;
                }
                spins--;
            }
            spinDelegate();
            Console.WriteLine("{0}",game.determinePrize());
            Console.ReadKey();

        }
    }
}
