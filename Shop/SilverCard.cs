using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class SilverCard : Card
    {
        public SilverCard(string user, double price, double turnover)
        {
            userName = user;

            turnoverLastMonth = turnover;

            priceOfPurchase = price;

            userStatus = "Silver";

            initDiscountRate = 2;

        }
        protected override double calculateDiscount()
        {
            if (turnoverLastMonth > 300) initDiscountRate = 3.5;

            return priceOfPurchase * initDiscountRate / 100;
        }
    }
}
