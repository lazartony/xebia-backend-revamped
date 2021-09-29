using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEight
{
    class SavingsAccount:IBankAccount
    {
        private float balance = 0;
        public float Balance { get { return balance; } }
        public bool Deposit(float amount)
        {
            balance += amount;
            return true;
        }
        public bool Withdraw(float amount)
        {
            if (balance > amount)
            {
                balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
