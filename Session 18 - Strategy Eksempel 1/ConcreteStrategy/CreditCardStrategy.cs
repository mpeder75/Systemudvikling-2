using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_18___Strategy_Eksempel_1.ConcreteStrategy
{
    internal class CreditCardStrategy : IPayment
    {
        string Name { get; set; }
        string CardNumber { get; set; }
        int Cvv { get; set; }
        DateTime DateOfExpiry { get; set; }

        public CreditCardStrategy(string name, string cardNumber, int cvv, DateTime dateOfExpiry)
        {
            Name = name;
            CardNumber = cardNumber;
            Cvv = cvv;
            DateOfExpiry = dateOfExpiry;
        }

        public void pay(double amount)
        {
            Console.WriteLine($"{amount} paid with Credit Card");
        }


    }
}
