using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionInvesto.Core.Entities
{
    public class InvestmentType: BaseEntity
    {
        public string Name { get; set; }

        public decimal MinimumAmount { get; set; }

        public decimal MaximumAmount { get; set; }

        public double Rate { get; set; }  // per month

        public IList<Investment> Investments { get; set; } = new List<Investment>();

    }
}
