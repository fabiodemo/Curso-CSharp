using SobreposicaoVirtualOverrideBase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed.Entities
{
    internal class SavingsAccountPlus : SavingsAccount
    {
        // Proibido porque o método está selado.
        public override void Withdraw()
    }
}
