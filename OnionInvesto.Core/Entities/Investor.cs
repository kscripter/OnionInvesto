using System;
using System.Collections.Generic;

namespace OnionInvesto.Core.Entities
{
    public class Investor : BaseEntity
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public string Address { get; set; }

        public int PhoneNumber { get; set; }

        public bool IsActivated { get; set; }

        public DateTime? ActivatedAt { get; set; }

        public IList<Investment> Investments { get; set; } = new List<Investment>();

        public IList<InvestorBank> InvestorBanks { get; set; } = new List<InvestorBank>();
    }
}
