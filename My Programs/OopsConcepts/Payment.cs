using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    public class Payment
    {
        public double Balance;

        public virtual void ProcessPayment()
        {
            Console.WriteLine("Balance=" +Balance);
        }




    }

    public class CreditCardPayment : Payment
    {

        private double payment;

        public CreditCardPayment(double payment)
        {
            this.payment = payment;
        }
        public CreditCardPayment() { }
         
        public override void ProcessPayment()
        {
            Double CreditCardPay = Balance - payment;
            Console.WriteLine("Balence After Credit Card Pay=" +CreditCardPay);
        }

    }

    public class CashPayment : Payment
    {
        private double payment;
        public CashPayment(double payment)
        {
            this.payment = payment;
        }
        public CashPayment() { }
        public override void ProcessPayment()
        {
            Double CashPaymentPay = Balance - payment;
            Console.WriteLine("Balence After Cash Pay=" + CashPaymentPay);
        }
    }





}
