using System;
using System.Collections.Generic;
using System.Linq;
using OnionInvesto.Core.Interface.Repository;
using OnionInvesto.Core.Models.Entities;
using OnionInvesto.Data.Context;

namespace OnionInvesto.Core.Domain.Repository
{
    public class ManagerRepository : IManagerRepository
    {

        private readonly InvestoContext _context;

        public ManagerRepository(InvestoContext context)
        {
            _context = context;
        }



        public Manager AddManager(Manager manager)
        {
            _context.Managers.Add(manager);
            _context.SaveChanges();
            return manager;
        }

        public int CreateManager(Manager manager)
        {
            try
            {
                _context.Managers.Add(manager);
                _context.SaveChanges();
                return manager.Id;
            }
            catch (Exception x)
            {
                Console.WriteLine($"error: {x.Message}");
            }
            return manager.Id;
        }

        public void DeleteManager(int id)
        {
            var manager = _context.Managers.Find(id);
            _context.Remove(manager);
            _context.SaveChanges();
        }

        public Manager FindByEmail(string email)
        {
            return _context.Managers.FirstOrDefault(i => i.Email == email);
        }

        public List<Manager> GetAll()
        {
            return _context.Managers.ToList();
        }

        public Manager GetManager(int id)
        {
            return _context.Managers.Find(id);
        }

        public Manager Update(Manager manager)
        {
            _context.Managers.Update(manager);
            _context.SaveChanges();
            return manager;
        }
    }
}
