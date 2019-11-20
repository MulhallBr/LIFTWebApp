using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LIFTWebApp.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required, EmailAddress ,MaxLength(256), Display(Name = "Email")]
        public string Email { get; set; }

        [Required,MaxLength(256), Display(Name ="Username")]
        public string Username { get; set; }

        [Required,DataType(DataType.Password),MaxLength(50),MinLength(8),Display(Name = "Password")]
        public string Password { get; set; }
        [Required, DataType(DataType.Password), MaxLength(50), MinLength(8), Display(Name ="Confirm Password")]
        [Compare("Password", ErrorMessage = "Password fields do not match")]
        public string ConfrimPassword { get; set; }

    }
}
