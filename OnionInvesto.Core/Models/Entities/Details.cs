using System;
namespace OnionInvesto.Core.Models.Entities
{
    public abstract class Details : BaseEntity
    {


        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }


        public int PhoneNumber { get; set; }

    }
}
