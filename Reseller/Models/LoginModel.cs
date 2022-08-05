using System;
using System.Collections.Generic;

#nullable disable

namespace Reseller.Models
{
    public partial class LoginModel
    {
        public int LoginId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public bool RememberMe { get; set; }
        public string ReturnUrl { get; set; }
    }
}
