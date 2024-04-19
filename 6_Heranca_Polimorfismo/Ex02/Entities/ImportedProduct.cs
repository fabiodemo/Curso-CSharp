using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFees { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFees) : base(name, price)
        {
            Name = name;
            Price = price;
            CustomsFees = customsFees;
        }

        double TotalPrice()
        {
            return Price + CustomsFees;
        }

        public override String PriceTag()
        {
            return Name
                + " $ "
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " (Customs fee: $ "
                + CustomsFees.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }
    }
}
