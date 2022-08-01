using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Reseller.Models
{
    public class LoginModel
    {
        public int LoginID { get; set; }


        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        

        public bool RememberMe {get;set;}
        public string ReturnUrl { get; set; }
        public string Role { get; internal set; }
    }
}
