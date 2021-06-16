using System;
using System.Collections.Generic;
using OnionInvesto.Core.Models.Entities;

namespace OnionInvesto.Core.Interface.Repository
{
    public interface IUserRepository
    {


        public int CreateUser(User user);


        public User FindByEmail(string email);

        public User GetDetails(int id);

        public User GetInvestor(int id);

        public User FindById(int id);

        public User AddInvestor(User user);


        public List<User> GetAll();

        public void DeleteUser(int id);

        public User UpdateUser(User user);



    }
}
