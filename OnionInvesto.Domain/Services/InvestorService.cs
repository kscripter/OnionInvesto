using System;
using System.Collections.Generic;
using OnionInvesto.Core.Interface.Repository;
using OnionInvesto.Core.Interface.Services;
using OnionInvesto.Core.Models.Entities;

namespace OnionInvesto.Core.Domain.Services
{
    public class InvestorService : IInvestorService
    {


        private readonly IInvestorRepository _investorRepository;


        public InvestorService(IInvestorRepository investorRepository)
        {
            _investorRepository = investorRepository;
        }










        public Investor GetInvestor(int id)
        {
            return _investorRepository.GetInvestor(id);
        }





        public void DeleteInvestor(int id)
        {
            _investorRepository.DeleteInvestor(id);
        }


        public List<Investor> GetAll()
        {
            return _investorRepository.GetAll();
        }


        public Investor UpdateInvestor(Investor investor)
        {
            return _investorRepository.UpdateInvestor(investor);
        }



        public Investor AddInvestor(Investor investor)
        {
            Investor invest = _investorRepository.AddInvestor(investor);

            return invest;
        }



    }
}
