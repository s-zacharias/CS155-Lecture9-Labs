using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            CashPayment payment1 = new CashPayment(99.89);
            CashPayment payment2 = new CashPayment(10000.76);

            CreditCardPayment payment3 = new CreditCardPayment("Stephanie Zacharias",
                1758658945238456, 36.90);
            CreditCardPayment payment4 = new CreditCardPayment("Dean Chung",
                2589456375148549, 249.65);

            payment1.PaymentDetails();
            payment2.PaymentDetails();
            payment3.PaymentDetails();
            payment4.PaymentDetails();
        }
    }
    class Payment
    {
        // Instance Variable
        private double amount;

        // Methods
        public double Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
            }
        }

        public void PaymentDetails()
        {
            Console.WriteLine("The amount of the payment is $" + Amount);
        }
    }
    class CashPayment:Payment
    {
        public CashPayment(double amount)
        {
            Amount = amount;
        }

        public new void PaymentDetails()
        {
            Console.WriteLine("The amount of cash payment is $" + Amount);
        }
    }
    class CreditCardPayment:Payment
    {
        private String name;
        private long cardNumber;

        public CreditCardPayment(String name, long cardNumber, double amount)
        {
            this.name = name;
            this.cardNumber = cardNumber;
            Amount = amount;
        }

        public new void PaymentDetails()
        {
            Console.WriteLine("The amount of credit card payment is $" + Amount +
                " on a card belonging to " + name + " with a number of " + cardNumber);
        }
    }
}

