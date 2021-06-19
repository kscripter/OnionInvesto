using System;
using OnionInvesto.Core.Enum;

namespace OnionInvesto.Core.Entities
{
    public class Investment : BaseEntity
    {
        public string Title { get; set; }

        public decimal AmountInvested { get; set; }

        public double Rate { get; set; }

        public Guid InvestmentTypeId { get; set; }

        public InvestmentType InvestmentType { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public Investor Investor { get; set; }

        public Guid InvestorId { get; set; }

        public DepositType DepositType { get; set; }

        public InvestmentStatus InvestmentStatus { get; set; }

    }
}
