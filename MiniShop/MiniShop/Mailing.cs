using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop
{
    class Mailing
    {
        
        public double MailingPrice(List<ShopBasket> basket, string sendVia = " ")
        {
            switch (sendVia)
            {
                case "International":
                    return Size(basket, 7);
                case "Courier":
                    return Size(basket, 5);
                case "Mail":
                    return Size(basket, 1);
                case "Terminal":
                    return Size(basket, 2);
                default:
                    return Size(basket, 0);
            }
        }

        public double Size(List<ShopBasket> basket,double intrest)
        {
            double price = 0;
            double totalWeight = 0;
            if (basket.Count != 0)
            {
                foreach (var item in basket)
                {
                    price += item.Price * item.PurchaseAmount;
                    totalWeight += item.Weight * item.PurchaseAmount;
                }
                if (totalWeight < 12)
                {
                    return price + intrest + (totalWeight * 0.08);
                }

                else if (totalWeight > 50)
                {
                    return price + intrest + (totalWeight * 0.25);
                }

                else
                {
                    return price + intrest + (totalWeight * 0.15);
                }
            }
            else return price;
        }
    }
}
