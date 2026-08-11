using System;
using System.Collections.Generic;
using System.Text;

namespace oop_task4
{
    internal class CreditCardPayment : PaymentMethod, IRefundable
    {
        public string CardNumber { get; }
        public CreditCardPayment(decimal amount, string cardNumber) : base(amount)
        {
            
        }

        public CreditCardPayment(decimal amount) : base(amount)
        {
        }

        public override void Pay()
        {
            Console.WriteLine("Paid " + Amount + " using credit card: " + CardNumber);
        }
        public void Refund()
        {
            Console.WriteLine("Refunded " + Amount + " to credit card: " + CardNumber);
        }
    
    }
}
