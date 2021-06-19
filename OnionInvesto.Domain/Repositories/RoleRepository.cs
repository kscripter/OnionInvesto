using System;
using OnionInvesto.Core.Entities;
using OnionInvesto.Core.Repositories;
using OnionInvesto.Data.Context;

namespace OnionInvesto.Domain.Repositories
{
    public class RoleRepository : BaseRepository<Role>, IRoleRepository
    {

        public RoleRepository(InvestoContext context)
        {
            DbContext = context;
        }





    }
}
