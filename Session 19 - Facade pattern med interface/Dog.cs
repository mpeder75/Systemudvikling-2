using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_19___Facade_pattern_med_interface
{
    internal class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Woof woof");
        }
    }
}
