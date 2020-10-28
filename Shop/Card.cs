using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    abstract class Card
    {
        protected string userName { get; set; }
        protected string userStatus { get; set; }
        protected double turnoverLastMonth { get; set; }
        protected double initDiscountRate { get; set; }
        protected double priceOfPurchase { get; set; }
        
        //apstraktna metoda koju ce svaka cerka-klasa predefinisati za svoje potrebe
        protected abstract double calculateDiscount();

        public void printData()
        {
            double discount = calculateDiscount();

            //String format omogucava prikaz koji se trazi u primeru (150.00)
            Console.WriteLine("Purchase value: $" + String.Format("{0:0.00}",priceOfPurchase));

            Console.WriteLine("Discount rate: " + initDiscountRate + "%");

            Console.WriteLine("Total discount: $" + String.Format("{0:0.00}",discount));

            Console.WriteLine("Total: $" + String.Format("{0:0.00}",(priceOfPurchase - discount)));

        }
    }
}
