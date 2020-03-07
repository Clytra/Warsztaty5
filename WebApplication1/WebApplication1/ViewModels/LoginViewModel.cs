using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Aby się zalogować, należy wprowadzić swój login.")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Aby się zalogować, należy wprowadzić swoje hasło")]
        public string Password { get; set; }
    }
}
