using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TargetForApplication.Contracts;

namespace TargetForApplication.Models
{
    internal class ShoppingBasket: IShoppingBasket
    {
        public IList<IShoppingBasketItem>? Items { get; set; }

        public decimal GetSalesTaxes() => Items != null ? Items.Sum(s => s.Tax) : 0;

        public decimal GetTotalCost() => Items != null ? Items.Sum(s => s.Cost) : 0;
    }
}
