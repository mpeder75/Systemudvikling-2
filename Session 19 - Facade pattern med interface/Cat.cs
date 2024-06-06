using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_19___Facade_pattern_med_interface
{
    internal class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Miaw miaw");
        }
    }
}
