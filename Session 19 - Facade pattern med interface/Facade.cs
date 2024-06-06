using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_19___Facade_pattern_med_interface
{
    internal class Facade
    {
        IAnimal cat;
        IAnimal dog;

        public Facade()
        {
            this.cat =  new Cat();
            this.dog = new Dog();
        }

        public void CatMakeSound()
        {
            dog.MakeSound();
        }


        public void DogMakeSound()
        {
            cat.MakeSound();
        }
    }
}
