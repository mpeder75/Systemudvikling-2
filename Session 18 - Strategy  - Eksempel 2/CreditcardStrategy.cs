using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Session_18___Strategy____Eksempel_2
{
    internal class CreditcardStrategy : IPaymentStrategy
    {
        public string Name { get; set; }
        public string CardNumber { get; set; }
        public string Cvv { get; set; }
        public string DateOfExpiry { get; set; }
        public CreditcardStrategy(string name, string cardNumber, string cvv, string dateOfExpiry)
        {
            Name = name;
            CardNumber = cardNumber;
            Cvv = cvv;
            DateOfExpiry = dateOfExpiry;
        }

        public void Pay(int amount)
        {            
            Console.WriteLine($"{amount} paid with credit/debit card");
        }
    }
}
