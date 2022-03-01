using TargetForApplication.Contracts;

namespace TargetForApplication
{
    internal interface IShoppingBasketPrinter
    {
        void Print(IShoppingBasket shoppingCart);
    }
}