using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEight
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch1 = '0', ch2 = '0';
            float amount;
            IBankAccount bankAccount;
            SavingsAccount savingsAccount = new SavingsAccount();
            CurrentAccount currentAccount = new CurrentAccount();
            while (ch1 != '3')
            {
                Console.WriteLine("\n============================================");
                Console.Write("\n1-Saving\n2-Current\n3-Exit\nEnter your choice : ");
                ch1 = char.Parse(Console.ReadLine());
                switch (ch1)
                {
                    case '1':
                        bankAccount = savingsAccount;
                        break;
                    case '2':
                        bankAccount = currentAccount;
                        break;
                    case '3':
                        continue;
                    default:
                        Console.WriteLine("\nInvalid Choice");
                        continue;
                }
                Console.Write("\n\t1-Balance\n\t2-Deposit\n\t3-Withdraw\n\tEnter your choice : ");
                ch2 = char.Parse(Console.ReadLine());
                switch (ch2)
                {
                    case '1':
                        Console.WriteLine("\nBalance : {0}", bankAccount.Balance);
                        break;
                    case '2':
                        Console.Write("\nEnter the amount to be deposited : ");
                        amount = float.Parse(Console.ReadLine());
                        if (bankAccount.Deposit(amount))
                        {
                            Console.WriteLine("\nTransaction Completed");
                        }
                        else
                        {
                            Console.WriteLine("\nTransaction Failed");
                        }
                        break;
                    case '3':
                        Console.Write("\nEnter the amount to be withdrawn : ");
                        amount = float.Parse(Console.ReadLine());
                        if (bankAccount.Withdraw(amount))
                        {
                            Console.WriteLine("\nTransaction Completed");
                        }
                        else
                        {
                            Console.WriteLine("\nTransaction Failed");
                        }
                        break;
                    default:
                        Console.WriteLine("\nInvalid Choice");
                        break;
                }
            }
        }
    }
}
