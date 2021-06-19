using System.Collections.Generic;

namespace OnionInvesto.Core.Entities
{
    public class Bank: BaseEntity
    {
        public string Name { get; set; }

        public string Code { get; set; }

        public IList<InvestorBank> InvestorBanks { get; set; } = new List<InvestorBank>();

    }
}
