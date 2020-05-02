using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop
{
    class Mailing
    {
        public void Internacional()
        {

        }
        public void Courier()
        {

        }
        public void Mail()
        {

        }
        public void Terminal()
        {

        }
        public double MailingPrice(ShopBasket basket)
        {

            return 0;
        }
        public string Size(ShopBasket basket)
        {
            double totalWeight = 0;
            foreach (var item in basket.listas)
            {
                totalWeight += item.Weight;
            }
            if (totalWeight < 15)
                return "S";
            else if (totalWeight > 50)
                return "L";
            else 
                return "M";

        }
    }
}
