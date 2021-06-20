using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnionInvesto.Core.Entities;
using OnionInvesto.Core.Repositories;
using OnionInvesto.Data.Context;

namespace OnionInvesto.Domain.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {

        public UserRepository(InvestoContext context)
        {
            DbContext = context;
        }

        public async Task<User> FindByEmail(string email)
        {
            return await DbContext.Users.SingleOrDefaultAsync(e => e.Email == email);
        }
    }

}
