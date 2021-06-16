using System;
using OnionInvesto.Core.Models.Entities;

namespace OnionInvesto.Core.Interface.Repository
{
    public interface IInvestmentRepository
    {

        public Investment CreateInvestments(Investment investment);

        public Investment AddInvestDays(Investment investment);

        public Investment AddROI(Investment investment);


        public Investment AddInvestmentType(Investment investment);


        public Investment AddInvestmentDate(Investment investment);


        public Investment AddTotalInvestments(Investment investment);

        public Investment AddPendingReturns(Investment investment);

        public Investment AddAmountRecieved(Investment investment);

        public Investment AddAmountInvested(Investment investment);


        public Investment AddDepositType(Investment investment);
    }
}
