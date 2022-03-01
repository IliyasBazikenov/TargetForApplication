using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TargetForApplication.Models;

namespace TargetForApplication.Contracts
{
    public interface IProduct
    {
        decimal BasePrice { get; set; }
        string? Name { get; set; }
        bool IsImported { get; set; }
        ProductType ProductType { get; set; }
    }
}
