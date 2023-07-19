using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebMvc.Models
{
    public class LoginViewModel
    {

        [Required]
        [Display(Name = "Username")]
        [MaxLength(50, ErrorMessage = "Username cannot be more than 50 characters.")]
        [MinLength(4, ErrorMessage = "Username at least 4 characters.")]
        public string Username { get; set; }

        [Required]
        [Display(Name = "Password")]
        [MinLength(4, ErrorMessage = "Password must be more than 4 characters.")]
        [MaxLength(256, ErrorMessage = "Password cannot be more than 256 characters.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}