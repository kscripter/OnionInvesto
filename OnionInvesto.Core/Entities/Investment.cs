using System;
namespace OnionInvesto.Core.Entities
{
    public class Investment : BaseEntity
    {

        public decimal AmountInvested { get; set; }

        public double Rate { get; set; }

        public Guid InvestmentTypeId { get; set; }

        public InvestmentType InvestmentType { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public Investor Investor { get; set; }

        public Guid InvestorId { get; set; }

        public string DepositType { get; set; }

        public bool InvestmentStatus { get; set; }

    }
}
