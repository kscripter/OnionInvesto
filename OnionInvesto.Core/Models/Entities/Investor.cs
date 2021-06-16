using System;
using System.Collections.Generic;

namespace OnionInvesto.Core.Models.Entities
{
    public class Investor : Details
    {
        public List<Investment> Investments { get; set; }

        public BankDetail BankDetail { get; set; }

    }
}
