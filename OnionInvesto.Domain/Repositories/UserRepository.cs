using System;
using System.Collections.Generic;
using OnionInvesto.Core.Interface.Repository;
using OnionInvesto.Core.Models.Entities;
using OnionInvesto.Data.Context;

namespace OnionInvesto.Core.Domain.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly InvestoContext _context;

        public UserRepository(InvestoContext context)
        {
            _context = context;
        }

        public User AddInvestor(User user)
        {
            throw new NotImplementedException();
        }

        public int CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public User FindByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public User FindById(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetDetails(int id)
        {
            throw new NotImplementedException();
        }

        public User GetInvestor(int id)
        {
            throw new NotImplementedException();
        }

        public User UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
