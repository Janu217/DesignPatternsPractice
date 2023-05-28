using System;

namespace FactoryPattern
{
    class Program
    {
        //According to Gang of Four(GoF), the Factory Design Pattern states that A factory is an object which is used for creating other objects.
        //a factory is a class with a method.That method will create and return different types of objects based on the input parameter, it received.
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
