using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    class Aluguel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        
        public Aluguel() { }

        public override string ToString()
        {
            return $"{Name}, {Email}";
        }
    }
}
