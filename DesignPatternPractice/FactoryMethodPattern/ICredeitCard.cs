using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public interface ICredeitCard
    {
        string GetCredeitCardType();
        int GetCreditCardLimit();
        int GetAnnualChanges();
    }

}
