using System;
using OnionInvesto.Core.Interface.Repository;
using OnionInvesto.Data.Context;

namespace OnionInvesto.Core.Domain.Repository
{
    public class RoleRepository : IRoleRepository
    {

        private readonly InvestoContext _context;


        public RoleRepository(InvestoContext context)
        {
            _context = context;
        }





    }
}
