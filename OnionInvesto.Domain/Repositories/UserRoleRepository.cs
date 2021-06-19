using System;
using OnionInvesto.Core.Interface.Repository;
using OnionInvesto.Data.Context;

namespace OnionInvesto.Core.Domain.Repository
{
    public class UserRoleRepository : IUserRoleRepository
    {

        private readonly InvestoContext _context;


        public UserRoleRepository(InvestoContext context)
        {
            _context = context;
        }


    }
}
