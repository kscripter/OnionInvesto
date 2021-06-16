using System;
using System.Collections.Generic;
using OnionInvesto.Core.Models.Entities;

namespace OnionInvesto.Core.Interface.Services
{
    public interface IInvestorService
    {

        public Investor AddInvestor(Investor investor);


        public Investor GetInvestor(int id);


        public void DeleteInvestor(int id);


        public List<Investor> GetAll();


        public Investor UpdateInvestor(Investor investor);


    }
}
