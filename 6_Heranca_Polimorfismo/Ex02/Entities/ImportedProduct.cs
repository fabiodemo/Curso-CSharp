using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02.Entities
{
    class ImportedProduct : Product
    {
        public double CustomFees { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customFees) : base(name, price)
        {
            Name = name;
            Price = price;
            CustomFees = customFees;
        }

        public string PriceTag()
        {
            return "sus";
        }


    }
}
