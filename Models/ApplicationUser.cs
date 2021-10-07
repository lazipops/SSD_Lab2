using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace SSDLab1.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required,Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required, Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required, Display(Name = "Email")]
        override
        public string Email { get; set; }
        override
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
