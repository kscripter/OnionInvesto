using System;
using System.Collections.Generic;

namespace OnionInvesto.Core.Entities
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }

        public IList<UserRole> UserRoles { get; set; } = new List<UserRole>();

    }
}
