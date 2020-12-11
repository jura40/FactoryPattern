using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    // Factory
    abstract class CardFactory
    {
        public abstract CreditCard GetCreditCard();
        
    }
}
