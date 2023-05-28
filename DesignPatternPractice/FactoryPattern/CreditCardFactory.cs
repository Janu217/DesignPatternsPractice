using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
   public class CreditCardFactory
    {

        public static ICredeitCard GetCredeitCard(string CardType)
        {
            ICredeitCard creditcard = null;
            if (CardType == "Platinum")
            {
                creditcard = new PlatimumCard();
            }
            else if (CardType == "Titanium")
            {
                creditcard = new TitaniumCard();
            }
            else if (CardType == "CashBack")
            {
                creditcard = new CashBackCard();
            }

            return creditcard;
        }

    }
}
