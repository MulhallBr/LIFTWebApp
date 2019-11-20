
using Microsoft.AspNetCore.Identity;
using System;

namespace LIFTWebApp.Models
{
    public class AppUser : IdentityUser
    {
        public DateTime DateRegistered { get; set; }

    }
}
