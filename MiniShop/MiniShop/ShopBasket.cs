using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop
{
    public class ShopBasket : Iitems
    {
        //public Merchandise merchandise { get; set; }
       

        public string Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public double Weight { get; set; }

        public int PurchaseAmount { get; set; }

        public ShopBasket(Iitems merch) 
        {
            Id = merch.Id;
            Name = merch.Name;
            Price = merch.Price;
            Weight = merch.Weight;
            PurchaseAmount = 1;
        }
        public void ChangeAmount(int amount)
        {
            PurchaseAmount = amount;
        }



    }
}
