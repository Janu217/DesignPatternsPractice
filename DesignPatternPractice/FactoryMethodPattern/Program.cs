using System;

namespace FactoryMethodPattern
{
    class Program
    {
        //According to the Gang of Four, the Factory Method Design Pattern States that Defines an interface for creating an object, but lets the subclasses decide which class to instantiate.
        ////The Factory method lets a class defer instantiation to subclasses.
        ///in the factory method design pattern we will create an abstract class as the Factory class which will create and return the instance of the product, 
        ///but it will let the subclasses decide which class to instantiate.
        static void Main(string[] args)
        {
            ICredeitCard credeitCard = new TitaniumFactory().CreateProduct();
            Console.WriteLine("Card Type :" + credeitCard.GetCredeitCardType());
            Console.WriteLine("Card Limit :" + credeitCard.GetCreditCardLimit());
            Console.WriteLine("Card Charges : " + credeitCard.GetAnnualChanges());
            Console.WriteLine("Hello World!");
        }
    }
}
