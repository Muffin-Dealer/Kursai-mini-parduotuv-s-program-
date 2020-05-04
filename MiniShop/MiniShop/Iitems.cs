using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop
{
     public interface Iitems
    {
        string Id { get; }
        string Name { get; }
        double Price { get; }
        double Weight { get; }

    }
}
