using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRegistratorPageLibrary.Model
{
    public class Account
    {
        [Key]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "UserName")]
        public string username { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Display(Name = "Email Address")]
        [Column(TypeName = "varchar(1000)")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [Display(Name = "Address")]
        [Column(TypeName = "nvarchar(1000)")]
        public string address { get; set; }

        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public int phone { get; set; }

        [Display(Name = "Gender")]
        public bool gender { get; set; }
    }
}
