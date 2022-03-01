using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TargetForApplication.Contracts;

namespace TargetForApplication.UI
{
    internal class ShoppingBasketConsolePrinter : IShoppingBasketPrinter
    {
        public void Print(IShoppingBasket shoppingCart)
        {
            if (shoppingCart == null)
                throw new ArgumentNullException(nameof(shoppingCart));

            if (shoppingCart.Items != null)
                Print(shoppingCart.Items);

            Console.WriteLine($"Sales Taxes: {shoppingCart.GetSalesTaxes()}");
            Console.WriteLine($"Total: {shoppingCart.GetTotalCost()}");
        }

        private void Print(IList<IShoppingBasketItem> items)
        {
            if (items.Count == 0)
                throw new ArgumentException("Argument items cannot be empty");

            foreach (var item in items)
                Console.WriteLine($"{item.Count} {item.Product?.Name}: {item.Cost}");

        }
    }
}
