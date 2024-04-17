using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_18___Strategy_Eksempel_1
{
    public class Item
    {
        // prop er public, MEN setter er sat til private (encapsulation)
        // når setter er private, kan man udefra ikke sette værdien
        // man kan kun se værdien gennem public get

        public string UpcCode { get; private set; }
        public double Price { get; private set; }

        public Item(string upccode, double price) 
        {
            UpcCode = upccode;
            Price = price;
        }



    }
}
