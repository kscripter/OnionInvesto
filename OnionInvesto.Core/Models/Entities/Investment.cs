using System;
namespace OnionInvesto.Core.Models.Entities
{
    public class Investment : BaseEntity
    {

        public double AmountInvested { get; set; }

        public double ROI { get; set; }

        public int InvestDays { get; set; }

        public string InvestmentType { get; set; }

        public DateTime InvestmentDate { get; set; }


        public Investor Investor { get; set; }


        public string DepositType { get; set; }

    }
}
