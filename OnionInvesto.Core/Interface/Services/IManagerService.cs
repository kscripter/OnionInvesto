using System;
using System.Collections.Generic;
using OnionInvesto.Core.Models.Entities;

namespace OnionInvesto.Core.Interface.Services
{
    public interface IManagerService
    {

        public Manager AddManager(Manager manager);

        public Manager Update(Manager manager);


        public List<Manager> GetAll();

        public void DeleteManager(int id);

        public Manager GetManager(int id);
    }
}
