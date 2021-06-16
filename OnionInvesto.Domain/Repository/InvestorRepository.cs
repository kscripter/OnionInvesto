﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using OnionInvesto.Core.Interface.Repository;
using OnionInvesto.Core.Models.Entities;
using OnionInvesto.Data.Context;

namespace OnionInvesto.Core.Domain.Repository
{
    public class InvestorRepository : IInvestorRepository
    {


        private readonly InvestoContext _context;

        public InvestorRepository(InvestoContext context)
        {
            _context = context;
        }



        public void DeleteInvestor(int id)
        {
            var investor = _context.Investors.Find(id);
            _context.Remove(investor);
            _context.SaveChanges();
        }



        public Investor AddInvestor(Investor investor)
        {
            _context.Investors.Add(investor);
            _context.SaveChanges();
            return investor;
        }

        public Investor FindByEmail(string email)
        {
            return _context.Investors.FirstOrDefault(e => e.Email == email);
        }

        public Investor FindById(int id)
        {
            return _context.Investors.FirstOrDefault(i => i.Id == id);
        }

        public List<Investor> GetAll()
        {
            return _context.Investors.ToList();
        }



        public Investor GetInvestor(int id)
        {
            return _context.Investors.Find(id);
        }



        public Investor UpdateInvestor(Investor investor)
        {
            _context.Investors.Update(investor);
            _context.SaveChanges();
            return investor;
        }

        public int CreateInvestor(Investor investor)
        {
            try
            {
                _context.Investors.Add(investor);
                _context.SaveChanges();
                return investor.Id;
            }
            catch (Exception ea)
            {
                Console.WriteLine($"error: {ea.Message}");
            }
            return 0;
        }




    }
}
