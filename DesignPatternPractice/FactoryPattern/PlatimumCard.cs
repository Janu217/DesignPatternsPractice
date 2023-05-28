using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class PlatimumCard : ICredeitCard
    {
        public int GetAnnualChanges()
        {
            return 1000;

        }

        public string GetCredeitCardType()
        {
            return "Platinum";
        }

        public int GetCreditCardLimit()
        {
            return 75000;
        }
    }
}
