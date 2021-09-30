using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Dictionary<string, string> dictionary = new Dictionary<string, string>() { { "HDD", "Floppy Disk" }, { "RAM", "Random Access Memory" }, { "ROM", "Read Only Memory" }, { "FDD", "Hard Disk" } };
            Console.WriteLine("INDEX\tKEY\tVALUE\n");
            for (int i = 0; i < dictionary.Count; i++)
            {
                Console.WriteLine("{0}\t{1}\t{2}", i + 1, dictionary.ElementAt(i).Key, dictionary.ElementAt(i).Value);
            }
            do
            {               
                Console.Write("\nEnter the Key to be changed/added : ");
                string key = Console.ReadLine();
                Console.Write("Enter the value : ");
                string value = Console.ReadLine();
                if (dictionary.ContainsKey(key))
                {
                    dictionary[key] = value;
                }
                else
                {
                    dictionary.Add(key, value);
                }
                Console.WriteLine("\nINDEX\tKEY\tVALUE\n");
                for (int i = 0; i < dictionary.Count; i++)
                {
                    Console.WriteLine("{0}\t{1}\t{2}", i + 1, dictionary.ElementAt(i).Key, dictionary.ElementAt(i).Value);
                }
                Console.Write("\nEnter y to continue : ");
                ch = char.Parse(Console.ReadLine());
                Console.WriteLine("\n====================================\n");
            } while (ch == 'y');
            Console.ReadKey();
        }
    }
}
