namespace TargetForApplication.Contracts
{
    public interface IShoppingBasketItem
    {
        IProduct? Product { get; set; }
        int Count { get; set; }
        decimal Tax { get; set; }
        decimal Cost { get; }
    }
}