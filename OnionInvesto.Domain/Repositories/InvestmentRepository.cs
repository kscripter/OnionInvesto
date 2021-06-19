using System;
using OnionInvesto.Core.Entities;
using OnionInvesto.Core.Repositories;
using OnionInvesto.Data.Context;

namespace OnionInvesto.Domain.Repositories
{
    public class InvestmentRepository : BaseRepository<Investment>,  IInvestmentRepository
    {

        public InvestmentRepository(InvestoContext context)
        {
            DbContext = context;
        }


    }
}
