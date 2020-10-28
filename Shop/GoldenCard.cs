using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class GoldenCard : Card
    {
        public GoldenCard(string user, double price, double turnover)
        {
            userName = user;

            turnoverLastMonth = turnover;

            priceOfPurchase = price;

            userStatus = "Gold";

            initDiscountRate = 2;

        }

        protected override double calculateDiscount()
        {
            if (turnoverLastMonth >= 800) initDiscountRate = 10;

            else initDiscountRate += turnoverLastMonth / 100;

            return priceOfPurchase * initDiscountRate/100;
        }
    }
}
