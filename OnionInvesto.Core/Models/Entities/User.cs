using System;
using System.Collections.Generic;

namespace OnionInvesto.Core.Models.Entities
{
    public class User : BaseEntity
    {

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public string HashSalt { get; set; }

        List<Role> Roles { get; set; }

    }
}
