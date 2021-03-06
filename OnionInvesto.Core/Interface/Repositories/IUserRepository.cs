using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OnionInvesto.Core.Entities;
using OnionInvesto.Core.Repositories;

namespace OnionInvesto.Core.Repositories
{
    public interface IUserRepository: IRepository<User>
    {

        public Task<User> FindByEmail(string email);


    }
}
