using System;
using System.Collections.Generic;

#nullable disable

namespace Reseller.Models
{
    public partial class RegisterModel
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
