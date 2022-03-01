using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TargetForApplication.Contracts;
using TargetForApplication.Models;

namespace TargetForApplication.Models
{
    internal class ShoppingBasketItem: IShoppingBasketItem
    {
        public IProduct? Product { get; set; }
        public int Count { get; set; }

        public decimal Tax { get; set; }
        public decimal Cost => Product != null ? Count * (Product.BasePrice + Tax) : 0;
    }
}
