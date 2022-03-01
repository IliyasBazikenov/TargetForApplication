using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TargetForApplication.Contracts;
using TargetForApplication.Models;

namespace TargetForApplication.BL
{
    internal class TaxRate: ITax
    {
        public decimal GetTaxRate(IProduct product)
        {
            return product.ProductType switch
            {
                ProductType.Food => TaxRateCatalog.NoTax,
                ProductType.Medical => TaxRateCatalog.NoTax,
                ProductType.Book => TaxRateCatalog.NoTax,
                ProductType.Other => TaxRateCatalog.BaseTaxRate,
                _ => TaxRateCatalog.BaseTaxRate,
            };
        }
    }
}
