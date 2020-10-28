using System;
using System.IO;

namespace Shop
{
    class MarketShop
    {
        static void Main(string[] args)
        {
            /*
            //testiranje kartica manuelno
            GoldenCard golden = new GoldenCard("Milan", 1168.11, 10000);
            golden.printData();

            BronzeCard bronze = new BronzeCard("Petar", 130.99, 120);
            bronze.printData();

            SilverCard silver = new SilverCard("Stefan", 11000, 0);
            silver.printData();
            */

            bool start = true;
            double price, turnover;

            while (start)
            {
                Console.WriteLine("Enter turnover:");
                turnover = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter price of purchase:");
                price = Convert.ToInt32(Console.ReadLine());            

                Console.WriteLine("Choose your card (enter 1, 2 or 3): ");
                Console.WriteLine("1. Bronze");
                Console.WriteLine("2. Silver");
                Console.WriteLine("3. Gold");

                try
                {
                    char pickedCard = Convert.ToChar(Console.Read());

                    if (pickedCard == '1')
                    {
                        BronzeCard bronze = new BronzeCard("Milan", price, turnover);
                        bronze.printData();
                    }
                    else if (pickedCard == '2')
                    {
                        SilverCard silver = new SilverCard("Milan", price, turnover);
                        silver.printData();
                    }
                    else if (pickedCard == '3')
                    {
                        GoldenCard gold = new GoldenCard("Milan", price, turnover);
                        gold.printData();
                    }
                    else
                    {
                        Console.WriteLine("Your input was not as we expected, please try again.");
                        continue;
                    }

                    Console.WriteLine("Another entry?(y/n)");
                    Console.ReadLine(); //this was necessary to read a new line for, to me, unknown reasons.
                    string doItAgain = (Console.ReadLine());
                    

                    if (doItAgain !="y") //if 'n' then loop will be broken (task finished)
                        start = false;

                }
                catch (IOException ioe)
                {
                    Console.WriteLine("Something went wrong!!! " + ioe); //the program will go at the beginning of while loop
                    continue;
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Your input was bad! " + fe); //the program will go at the beginning of while loop
                    continue;
                }
            }
        }
    }
}
