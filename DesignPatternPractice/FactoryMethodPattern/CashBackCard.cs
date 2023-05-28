using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public class CashBackCard : ICredeitCard
    {
        public int GetAnnualChanges()
        {
            return 200;
        }

        public string GetCredeitCardType()
        {
            return "CashBack card";
        }

        public int GetCreditCardLimit()
        {
            return 25000;
        }
    }
}
