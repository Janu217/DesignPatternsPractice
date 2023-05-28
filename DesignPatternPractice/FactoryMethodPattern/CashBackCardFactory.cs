using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class CashBackCardFactory : CreditCardFactory
    {
        public override ICredeitCard MakeProduct()
        {
            return new CashBackCard();
        }
    }
}
