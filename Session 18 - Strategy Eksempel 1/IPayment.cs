using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//! Dette er Strategy i UML oversigten

// ConcreteStrategy classes der implementer dette interface,
// implementere forskelligt logik for pay();
// så vi har et strategy pattern med forskellige implementeringer

namespace Session_18___Strategy_Eksempel_1
{
    public interface IPayment
    {
        public void pay(double amount);
    }
}
