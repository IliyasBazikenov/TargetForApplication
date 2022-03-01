using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetForApplication.Contracts
{
    public interface IShoppingBasket
    {
        IList<IShoppingBasketItem>? Items { get; set; }

        decimal GetSalesTaxes();

        decimal GetTotalCost();
    }
}
