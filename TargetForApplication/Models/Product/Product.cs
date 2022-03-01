using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TargetForApplication.Contracts;

namespace TargetForApplication.Models
{
    internal class Product : IProduct
    {
        public decimal BasePrice { get; set; }
        public string? Name { get; set; }
        public bool IsImported { get; set; }
        public ProductType ProductType { get; set; }       
    }
}
