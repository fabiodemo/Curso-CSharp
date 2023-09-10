using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadorRef
{
    class Calculator
    {
        public static void Triple(ref int x)
        {
            x = x * 3;
        }

        public static void TripleNew(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
