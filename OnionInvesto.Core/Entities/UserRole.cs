﻿using System;
namespace OnionInvesto.Core.Entities
{
    public class UserRole : BaseEntity
    {

        public User User { get; set; }

        public Role Role { get; set; }

        public Guid UserId { get; set; }

        public Guid RoleId { get; set; }

    }
}
