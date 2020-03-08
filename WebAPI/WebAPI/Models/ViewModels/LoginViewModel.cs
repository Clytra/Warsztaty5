using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Aby się zalogować, należy podać login użytkownika.")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Aby się zalogować, należy podać hasło użytkownika.")]
        public string Password { get; set; }
    }
}
