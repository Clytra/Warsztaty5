using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="To pole nie może być puste.")]
        public string Login { get; set; }

        [Required(ErrorMessage = "To pole nie może być puste.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "To pole nie może być puste.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "To pole nie może być puste.")]
        [Compare("Password")]
        public string RepeatPassword { get; set; }
    }
}
