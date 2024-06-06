using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_18___Strategy____Eksempel_2
{
    // Denne class forwarder request fra Client til IPaymentStrategy med argument
    // IPaymentStrategy vil derefter kalde den korrekte ContcreteStrateg med argumentet
    internal class ShoppingcartContext
    {
        List<Item> items;

        public ShoppingcartContext()
        {
            items = new List<Item>();
        }

        public void Add(Item item) 
        {
            items.Add(item);
        }

        public void Remove(Item item)
        {
            items.Remove(item);
        }

        public int CalculateTotal()
        {
            int sum = 0;

           foreach (Item item in items)
            {
                sum += item.Price;
            }

            return sum;
        }
    }
}
