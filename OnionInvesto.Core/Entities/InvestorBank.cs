using System;
namespace OnionInvesto.Core.Entities
{
    public class InvestorBank: BaseEntity
    {
        public Guid InvestorId { get; set; }

        public Investor Investor { get; set; }

        public string AccountNumber { get; set; }

        public string AccountName { get; set; }

        public Guid BankId { get; set; }

        public Bank Bank { get; set; }
    }
}
