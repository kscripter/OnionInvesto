﻿using System;
using System.ComponentModel.DataAnnotations;

namespace OnionInvesto.UI.Models.ViewModel
{
    public class RegisterViewModel
    {

        [Required]
        public string Firstname { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password",
            ErrorMessage = "Password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }


        public string Address { get; set; }


        public int PhoneNumber { get; set; }



    }
}
