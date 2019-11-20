
using Microsoft.AspNetCore.Identity;
using System;

namespace LIFTWebApp.Models
{
    public class AppUser : IdentityUser
    {
        public DateTime DateRegistered { get; set; }
        public int ID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
