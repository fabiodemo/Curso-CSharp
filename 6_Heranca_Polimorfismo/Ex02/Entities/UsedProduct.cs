using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02.Entities
{
    class UsedProduct : Product
    {
        DateTime ManufaactureDate { get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price, DateTime manufaactureDate) : base(name, price)
        {
            Name = name;
            Price = price;
            ManufaactureDate = manufaactureDate;
        }
    }
}
