using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class BronzeCard : Card
    {
        public BronzeCard(string user, double price, double turnover)
        {
            userName = user;

            turnoverLastMonth = turnover;

            priceOfPurchase = price;

            userStatus = "Bronze";

            initDiscountRate = 0;

        }

        protected override double calculateDiscount()
        {
            if (turnoverLastMonth > 100 && turnoverLastMonth < 300) 
                
                initDiscountRate = 1;

            else if (turnoverLastMonth > 300) 
                
                initDiscountRate = 2.5;


            return priceOfPurchase * initDiscountRate / 100;
        }
    }
}
