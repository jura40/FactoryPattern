using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    /// <summary>  
    /// A 'ConcreteCreator' class  
    /// </summary>  
    class DebitFactory : CardFactory
    {
        private int _creditLimit;
        private int _annualCharge;

        public DebitFactory(int creditLimit, int annualCharge)
        {
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }

        public override CreditCard GetCreditCard()
        {
            return new DebitCreditCard(_creditLimit, _annualCharge);
        }
    }
}
