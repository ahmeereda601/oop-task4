namespace oop_task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PaymentMethod[] payments =
              {
                new CreditCardPayment(1500),
                new CashPayment(300)
            };
            foreach (PaymentMethod payment in payments)
            {

                payment.Pay();


                payment.PrintReceipt();


                if (payment is IRefundable refundablePayment)
                {

                    refundablePayment.Refund();
                }


            }
        }
    }
}

