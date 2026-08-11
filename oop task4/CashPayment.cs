using System;
using System.Collections.Generic;
using System.Text;

namespace oop_task4
{
    internal class CashPayment : PaymentMethod
    {
        public CashPayment(decimal amount) : base(amount)
        {
        }
        public override void Pay()
        {
            Console.WriteLine("Paid "+ Amount + " in cash");
        }
    }
}
