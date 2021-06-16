using System;
namespace OnionInvesto.Core.Models.Entities
{
    public class UserRole : BaseEntity
    {

        public User User { get; set; }

        public Role Role { get; set; }

        public int UserId { get; set; }

        public int RoleId { get; set; }

    }
}
