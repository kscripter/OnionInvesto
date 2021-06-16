using System;
namespace OnionInvesto.Core.Models.Entities
{
    public class BankDetail
    {

        public Investor Investor { get; set; }

        public Guid InvestorId { get; set; }

        public string Bankname { get; set; }

        public string AccountNumber { get; set; }

        public string AccountName { get; set; }
    }
}
