using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop
{
    class ShopBasket
    {
        public Merchandise merchandise;
        public int PurchaseAmount { get; private set; }

        public ShopBasket(Merchandise merch)
        {
            merchandise = merch;
            PurchaseAmount = 1;
        }
        public void ChangeAmount(int amount)
        {
            PurchaseAmount = amount;
        }



    }
}
