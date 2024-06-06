using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_19___Fasade_pattern
{
    public class Projector
    {
        public void TurnOn() => Console.WriteLine("Projector on");
        public void TurnOff() => Console.WriteLine("Projector off");
    }
}
