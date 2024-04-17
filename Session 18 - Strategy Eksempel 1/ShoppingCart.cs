using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_18___Strategy_Eksempel_1
{
    public class ShoppingCart
    {
        List<Item> items;

        public ShoppingCart()
        {
            items = new List<Item>();
        }

        public void AddItem(Item item) => items.Add(item);
        

        public void Remove(Item item) => items.Remove(item);
        

        public double CalculateTotal()
        {
            double total = items.Sum(item => item.Price);

            return total;
        }

        // Det er her vi beslutter og kalder HVILKEN ConcreteStrategy vi vil bruge (CreditCard eller Paypal)
        public void Pay(IPayment paymentMethod)
        {
            double amount = CalculateTotal();
            paymentMethod.pay(amount);
        }
    }
}
