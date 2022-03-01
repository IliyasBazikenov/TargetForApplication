
namespace TargetForApplication.Contracts
{
    public interface ITaxCalculator
    {
        void Calculate(IList<IShoppingBasketItem> cartItems);
    }
}