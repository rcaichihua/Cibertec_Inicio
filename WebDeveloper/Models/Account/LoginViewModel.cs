using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDeveloper.Models.Account
{
    public class LoginViewModel
    {
        [Display(Name = "Usuario")]
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Password")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
