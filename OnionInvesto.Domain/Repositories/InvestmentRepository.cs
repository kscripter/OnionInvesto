using System;
using OnionInvesto.Core.Interface.Repository;
using OnionInvesto.Core.Models.Entities;
using OnionInvesto.Data.Context;

namespace OnionInvesto.Domain.Repository
{
    public class InvestmentRepository : IInvestmentRepository
    {

        private readonly InvestoContext _context;

        public InvestmentRepository(InvestoContext context)
        {
            _context = context;
        }


        public Investment AddDepositType(Investment investment)
        {
            throw new NotImplementedException();
        }

        public Investment AddInvestDays(Investment investment)
        {
            throw new NotImplementedException();
        }

        public Investment AddAmountInvested(Investment investment)
        {
            throw new NotImplementedException();
        }

        public Investment AddAmountReceived(Investment investment)
        {
            throw new NotImplementedException();
        }

        public Investment AddPendingReturns(Investment investment)
        {
            throw new NotImplementedException();
        }

        public Investment AddTotalInvestments(Investment investment)
        {
            throw new NotImplementedException();
        }

        public Investment AddInvestmentDate(Investment investment)
        {
            throw new NotImplementedException();
        }

        public Investment AddInvestmentType(Investment investment)
        {
            throw new NotImplementedException();
        }

        public Investment AddROI(Investment investment)
        {
            throw new NotImplementedException();
        }

        public Investment CreateInvestments(Investment investment)
        {
            throw new NotImplementedException();
        }

        public Investment AddAmountRecieved(Investment investment)
        {
            throw new NotImplementedException();
        }
    }
}
