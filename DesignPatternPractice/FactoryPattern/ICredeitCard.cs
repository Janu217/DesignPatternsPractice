using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public interface ICredeitCard
    {
        string GetCredeitCardType();
        int GetCreditCardLimit();
        int GetAnnualChanges();
    }

}
