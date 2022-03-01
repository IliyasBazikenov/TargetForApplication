using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetForApplication.Contracts
{
    public interface ITax
    {
        decimal GetTaxRate(IProduct product);
    }
}
