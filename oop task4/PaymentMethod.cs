using System;
using System.Collections.Generic;
using System.Text;

namespace oop_task4
{
    abstract class PaymentMethod

    {
        public decimal Amount { get; }
        public PaymentMethod(decimal amount)
        {
            Amount = amount;
        }

        public void PrintReceipt()
        {
            Console.WriteLine("Payment Type:" + GetType().Name);
            Console.WriteLine("Amount: " + Amount);
        }
        public abstract void Pay();

    }
}
