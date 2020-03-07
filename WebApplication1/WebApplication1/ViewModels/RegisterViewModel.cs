using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "To pole nie może zostać puste.")]
        public string Login { get; set; }

        [Required(ErrorMessage = "To pole nie może zostać puste.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "To pole nie może zostać puste.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "To pole nie może zostać puste.")]
        [Compare("Password")]
        public string RepeatPassword { get; set; }
    }
}
