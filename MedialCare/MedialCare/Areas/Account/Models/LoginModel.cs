using MedialCare.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MedialCare.Areas.Account.Models
{
    public class LoginModel
    {
        
        public Level Level { get; set; }

        [Required(ErrorMessage = "Please enter User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter Password")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
