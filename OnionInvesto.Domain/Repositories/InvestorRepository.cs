using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnionInvesto.Core.Entities;
using OnionInvesto.Core.Repositories;
using OnionInvesto.Data.Context;

namespace OnionInvesto.Domain.Repositories
{
    public class InvestorRepository : BaseRepository<Investor>, IInvestorRepository
    {

        public InvestorRepository(InvestoContext context)
        {
            DbContext = context;
        }

        public async Task<Investor> FindByEmail(string email)
        {
            return await DbContext.Investors.SingleOrDefaultAsync(e => e.Email == email);
        }
    }
}
