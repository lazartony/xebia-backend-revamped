using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void ExerciseOne()
        {
            float preExamMark, finalExamMark;
            Console.Write("Enter pre-exam marks: ");
            preExamMark = float.Parse(Console.ReadLine());
            if (preExamMark > 45)
            {
                Console.Write("Enter final exam  marks:");
                finalExamMark = float.Parse(Console.ReadLine());
                if (finalExamMark > 55)
                {
                    Console.WriteLine("Candidate is selected");
                }
                else
                {
                    Console.WriteLine("Rejected in Final");
                }
            }
            else
            {
                Console.WriteLine("Not Clear Pre");
            }
        }
        public static void ExerciseTwo()
        {
            string userName;
        AcceptUserName:
            Console.WriteLine("Enter a username: ");
            userName = Console.ReadLine();
            if (userName.Length < 6)
            {
                Console.WriteLine("Invalid Username");
                goto AcceptUserName;
            }
        }
        public static void ExerciseThree()
        {
            int[,] studMarks = new int[4, 5];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Student {0}", i + 1);
                Console.Write("Enter the roll no: ");
                studMarks[i, 0] = int.Parse(Console.ReadLine());
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("Enter the mark in sem {0}: ", j + 1);
                    studMarks[j, j + 1] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 4; i++)
            {
                int totalMarks = studMarks[i, 1] + studMarks[i, 2] + studMarks[i, 3] + studMarks[i, 4];
                float percentageOfMarks = totalMarks / 4;
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", studMarks[i, 0], studMarks[i, 1], studMarks[i, 2], studMarks[i, 3], studMarks[i, 4], totalMarks, percentageOfMarks);
            }
        }
        public static void ExerciseFour()
        {
            int n, days;
            Console.Write("Enter the no: of employees: ");
            n = int.Parse(Console.ReadLine());
            int[][] employeeDetails = new int[n][];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Employee {0}", i + 1);
                Console.Write("Enter the no: of working days: ");
                days = int.Parse(Console.ReadLine());
                employeeDetails[i] = new int[days];
                for (int j = 0; j < days; j++)
                {
                    Console.Write("Enter the salary for day {0} : ", j + 1);
                    employeeDetails[i][j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}\t", i + 1);
                int totalSalary = 0;
                for (int j = 0; j < employeeDetails[i].Length; j++)
                {
                    Console.Write("{0}\t", employeeDetails[i][j]);
                    totalSalary += employeeDetails[i][j];
                }
                Console.WriteLine(": {0}", totalSalary);
            }
        }
        public static void ExerciseFive()
        {
            Console.WriteLine("Sample Salary Calculation for an HR: CalcSalary(7,6): {0}", CalcSalary(7, 6));
            Console.WriteLine("Sample Salary Calculation for an Admin: CalcSalary(7,6,10): {0}", CalcSalary(7, 6, 10));
            Console.WriteLine("Sample Salary Calculation for a Developer: CalcSalary(7,6,10,10): {0}", CalcSalary(7, 6, 10, 10));
        }
        static void Main(string[] args)
        {
            //ExerciseOne();
            //ExerciseTwo();
            //ExerciseThree();
            //ExerciseFour();
            ExerciseFive();
            Console.ReadKey();
        }

        public static float CalcSalary(float wHour, int nWDays, int projectHandles = 1, int extras = 0)
        {
            return wHour * nWDays * 100 + projectHandles * 3000 + extras * 2000;
        }
    }
}
