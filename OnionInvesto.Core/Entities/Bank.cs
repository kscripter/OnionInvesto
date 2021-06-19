using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionInvesto.Core.Entities
{
    public class Bank: BaseEntity
    {
        public string Name { get; set; }

        public string Code { get; set; }

        public IList<InvestorBank> InvestorBanks { get; set; } = new List<InvestorBank>();

    }
}
