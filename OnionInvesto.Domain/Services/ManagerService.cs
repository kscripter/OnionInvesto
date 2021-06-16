using System;
using System.Collections.Generic;
using OnionInvesto.Core.Interface.Repository;
using OnionInvesto.Core.Interface.Services;
using OnionInvesto.Core.Models.Entities;

namespace OnionInvesto.Core.Domain.Services
{
    public class ManagerService : IManagerService
    {

        private readonly IManagerRepository _managerRepository;


        public ManagerService(IManagerRepository managerRepository)
        {
            _managerRepository = managerRepository;
        }


        public Manager AddManager(Manager manager)
        {
            Manager manage = _managerRepository.AddManager(manager);
            return manage;
        }

        public void DeleteManager(int id)
        {
            _managerRepository.DeleteManager(id);
        }

        public List<Manager> GetAll()
        {
            return _managerRepository.GetAll();
        }

        public Manager GetManager(int id)
        {
            return _managerRepository.GetManager(id);
        }



        public Manager Update(Manager manager)
        {
            return _managerRepository.Update(manager);
        }

    }
}
