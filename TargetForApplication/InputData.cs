using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TargetForApplication.Contracts;
using TargetForApplication.Models;

namespace TargetForApplication
{
    internal class InputData
    {
        public static ShoppingBasket GetFirstShoppingBasket()
        {
            return new ShoppingBasket
            {
                Items = new List<IShoppingBasketItem> 
                {
                    new ShoppingBasketItem
                    {
                        Product = new Product
                        {
                            Name = "book",
                            BasePrice = 12.49m,
                            ProductType = ProductType.Book,
                            IsImported = false,
                        },
                        Count = 1
                    },
                    new ShoppingBasketItem
                    {
                        Product = new Product
                        {
                            Name = "music CD",
                            BasePrice = 14.99m,
                            ProductType = ProductType.Other,
                            IsImported = false,
                        },
                        Count = 1
                    },
                    new ShoppingBasketItem
                    {
                        Product = new Product
                        {
                            Name = "chocolate bar",
                            BasePrice = 0.85m,
                            ProductType = ProductType.Food,
                            IsImported = false,
                        },
                        Count = 1
                    }
                }
            };
        }

        public static ShoppingBasket GetSecondShoppingBasket()
        {
            return new ShoppingBasket
            {
                Items = new List<IShoppingBasketItem> 
                {
                    new ShoppingBasketItem
                    {
                        Product = new Product
                        {
                            Name = "imported box of chocolates",
                            BasePrice = 10.00m,
                            ProductType = ProductType.Food,
                            IsImported = true,
                        },
                        Count = 1
                    },
                    new ShoppingBasketItem
                    {
                        Product = new Product
                        {
                            Name = "imported bottle of perfume",
                            BasePrice = 47.50m,
                            ProductType = ProductType.Other,
                            IsImported = true,
                        },
                        Count = 1
                    }
                }
            };
        }

        public static ShoppingBasket GetThirdShoppingBasket()
        {
            return new ShoppingBasket
            {
                Items = new List<IShoppingBasketItem> 
                {
                    new ShoppingBasketItem
                    {
                        Product = new Product
                        {
                            Name = "imported bottle of perfume",
                            BasePrice = 27.99m,
                            ProductType = ProductType.Other,
                            IsImported = true,
                        },
                        Count = 1
                    },
                    new ShoppingBasketItem
                    {
                        Product = new Product
                        {
                            Name = "bottle of perfume",
                            BasePrice = 18.99m,
                            ProductType = ProductType.Other,
                            IsImported = false,
                        },
                        Count = 1
                    },
                    new ShoppingBasketItem
                    {
                        Product = new Product
                        {
                            Name = "packet of headache pills",
                            BasePrice = 9.75m,
                            ProductType = ProductType.Medical,
                            IsImported = false,
                        },
                        Count = 1
                    },
                    new ShoppingBasketItem
                    {
                        Product = new Product
                        {
                            Name = "imported box of chocolates",
                            BasePrice = 11.25m,
                            ProductType = ProductType.Food,
                            IsImported = true,
                        },
                        Count = 1
                    }
                }
            };
        }
    }
}
