using System;
using System.Collections.Generic;

namespace OnionInvesto.Core.Entities
{
    public class User : BaseEntity
    {
        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public IList<UserRole> UserRoles { get; set; } = new List<UserRole>();

    }
}
