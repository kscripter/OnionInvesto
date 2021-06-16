﻿using System;
using System.Collections.Generic;
using OnionInvesto.Core.Models.Entities;

namespace OnionInvesto.Core.Interface.Repository
{
    public interface IManagerRepository
    {

        public int CreateManager(Manager manager);

        public Manager AddManager(Manager manager);

        public Manager GetManager(int id);

        public Manager Update(Manager manager);

        public List<Manager> GetAll();

        public Manager FindByEmail(string email);

        public void DeleteManager(int id);

    }
}
