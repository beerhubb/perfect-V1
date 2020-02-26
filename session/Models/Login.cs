using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace session.Models
{
    public class Login
    {
        [Required]
        [Display(Name = "UserName")]
        public string username { get; set; }

        [Required]
        [Display(Name ="PassWord")]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}
