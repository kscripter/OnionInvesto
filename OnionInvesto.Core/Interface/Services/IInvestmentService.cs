using System;
using OnionInvesto.Core.Models.Entities;

namespace OnionInvesto.Core.Interface.Services
{
    public interface IInvestmentService
    {


        public Investment CreateTotalInvestments(Investment investment);


        public Investment CreateAmountInvested(Investment investment);


        public Investment CreatePendingReturns(Investment investment);

        public Investment GetAmountRecieved(Investment investment);

        public Investment GetDepositType(Investment investment);

    }
}
