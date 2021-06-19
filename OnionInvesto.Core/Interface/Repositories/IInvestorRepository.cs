using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OnionInvesto.Core.Entities;
using OnionInvesto.Core.Repositories;

namespace OnionInvesto.Core.Repositories
{
    public interface IInvestorRepository: IRepository<Investor>
    {
        Task<Investor> FindByEmail(string email);
    }
}
