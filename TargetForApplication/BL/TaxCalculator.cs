using TargetForApplication.Contracts;

namespace TargetForApplication.BL
{
    public class TaxCalculator: ITaxCalculator
    {
        protected decimal RoundPrecision = 0.05m;
        protected IEnumerable<ITax> Taxes => new List<ITax>() { new TaxRate(), new ImportTaxRate() };

        public void Calculate(IList<IShoppingBasketItem> cartItems)
        {
            if(cartItems == null)
                    throw new ArgumentNullException(nameof(cartItems));

            if (cartItems.Count == 0)
                throw new ArgumentException("CartItems cannot be empty!");

            foreach (var cartItem in cartItems)
            {
                if(cartItem.Product != null)
                {
                    var notRoundedResult = cartItem.Product.BasePrice * Taxes.Sum(t => t.GetTaxRate(cartItem.Product!));
                    cartItem.Tax = Math.Ceiling(notRoundedResult / RoundPrecision) * RoundPrecision;
                }
            }
        }
    }
}
