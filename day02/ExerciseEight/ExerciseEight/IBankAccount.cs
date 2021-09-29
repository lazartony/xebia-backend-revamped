using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEight
{
    interface IBankAccount
    {
        float Balance { get; }
        bool Deposit(float amount);
        bool Withdraw(float amount);
    }
}
