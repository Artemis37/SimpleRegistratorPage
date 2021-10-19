using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleRegistrationPage.Models
{
    public class Account
    {
        [Key]
        [Display(Name = "UserName")]
        public string username { get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]

        public string password { get; set; }
        [Required]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("password", ErrorMessage = "Password doesn't match")]
        public string confirmPassword { get; set; }

        [Display(Name = "Email Address")]
        public string email { get; set; }

        [Display(Name = "Address")]
        public string address { get; set; }

        [Display( Name = "Phone Number")]
        public int phone { get; set; }

        [Display(Name = "Gender")]
        public bool gender { get; set; }
    }
}
