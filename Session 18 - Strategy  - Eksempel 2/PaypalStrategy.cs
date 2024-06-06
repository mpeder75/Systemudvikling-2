using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_18___Strategy____Eksempel_2
{
    internal class PaypalStrategy : IPaymentStrategy
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public PaypalStrategy(string email, string password)
        {
            Email = email;
            Password = password;
        }    


        public void Pay(int amount)
        {
            Console.WriteLine($"{amount} paid by paypal transfer");
        }
    }
}
