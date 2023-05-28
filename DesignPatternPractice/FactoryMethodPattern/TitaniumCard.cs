using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public class TitaniumCard : ICredeitCard
    {
        public int GetAnnualChanges()
        {
            return 500;
        }

        public string GetCredeitCardType()
        {
            return "Titanium";
        }

        public int GetCreditCardLimit()
        {
            return 50000;
        }
    }
}
