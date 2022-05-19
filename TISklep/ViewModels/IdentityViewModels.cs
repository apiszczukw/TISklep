using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TISklep.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Musisz wprowadzić email")]
        [EmailAddress(ErrorMessage = "Niepoprawny format email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Musisz wprowadzić login")]
        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required(ErrorMessage = "Musisz wprowadzić hasło")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Musisz wprowadzić hasło")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Hasła muszą być jednakowe!")]
        public string ConfirmPassword { get; set; }
    }


    public class LoginViewModel
    {
        [Required(ErrorMessage = "Musisz wprowadzić login")]
        [Display(Name = "Login")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Musisz wprowadzić hasło")]
        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]
        public string Password { get; set; }
    }
}
