using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICredeitCard credeitCard = CreditCardFactory.GetCredeitCard("Platinum");
            Console.WriteLine("Card Type :" + credeitCard.GetCredeitCardType());
            Console.WriteLine("Card Limit :" + credeitCard.GetCreditCardLimit());            
            Console.WriteLine("Card Charges : " + credeitCard.GetAnnualChanges());


            Console.WriteLine("Hello World!");
        }
    }
}
