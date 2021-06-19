using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionInvesto.Core.Entities;
using OnionInvesto.Domain.Repositories;

namespace OnionInvesto.Core.Repositories
{
    public  class InvestmentTypeRepository: BaseRepository<InvestmentType>, IInvestmentTypeRepository
    {
    }
}
