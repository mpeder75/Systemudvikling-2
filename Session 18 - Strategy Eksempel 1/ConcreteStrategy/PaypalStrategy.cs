using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_18___Strategy_Eksempel_1.ConcreteStrategy
{
    internal class PaypalStrategy : IPayment
    {
        string Email { get; set; }
        string Password { get; set; }

        public PaypalStrategy(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public void pay(double amount)
        {
            Console.WriteLine($"{amount} paid with Paypal");
        }

    }
}
