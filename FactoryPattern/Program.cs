using System;

namespace FactoryPattern
{
    public class ClientApplication
    {
        static void Main()
        {
            CardFactory factory = null;

            Console.WriteLine("Enter köp");
            int saldo = Convert.ToInt32(Console.ReadLine());
         
            Console.Write("Enter the card type you would like to have: ");
            string card = Console.ReadLine();
            

            switch (card.ToLower())
            {
                case "debit":
                    factory = new DebitFactory(5000, saldo);
                    break;
                case "titanium":
                    factory = new TitaniumFactory(10000, saldo);
                    break;
                case "platinum":
                    factory = new PlatinumFactory(50000, saldo);
                    break;
                default:
                    break;
            }

            CreditCard creditCard = factory.GetCreditCard();
            Console.WriteLine("\nYour card details are below : \n");
            Console.WriteLine("Card Type: {0}\nCredit Limit: {1}\nAnnual Charge: {2}",
                creditCard.CardType, creditCard.CreditLimit, creditCard.AnnualCharge);
            Console.WriteLine("To close press the enter");
            Console.ReadKey();
        }
    }
}
