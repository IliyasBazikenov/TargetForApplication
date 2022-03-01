using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TargetForApplication.Contracts;

namespace TargetForApplication.BL
{
    internal class ImportTaxRate : ITax
    {
        public decimal GetTaxRate(IProduct product)
        {
            if (product.IsImported)
                return TaxRateCatalog.ImportTaxRate;

            return 0;
        }
    }
}
