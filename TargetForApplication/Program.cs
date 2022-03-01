using TargetForApplication;
using TargetForApplication.Contracts;
using TargetForApplication.BL;
using TargetForApplication.UI;

ITaxCalculator taxCalculator = new TaxCalculator();
IShoppingBasketPrinter printer = new ShoppingBasketConsolePrinter();

var shoppingBasket = InputData.GetFirstShoppingBasket();
taxCalculator.Calculate(shoppingBasket.Items);
printer.Print(shoppingBasket);

shoppingBasket = InputData.GetSecondShoppingBasket();
taxCalculator.Calculate(shoppingBasket.Items);
printer.Print(shoppingBasket);

shoppingBasket = InputData.GetThirdShoppingBasket();
taxCalculator.Calculate(shoppingBasket.Items);
printer.Print(shoppingBasket);

