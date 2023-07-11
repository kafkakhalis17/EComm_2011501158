using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComm_2011501158.Shared
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Username harus diisi")]
        public string Username { get; set; } = string.Empty;
        [Required(ErrorMessage = "Password harus diisi")]
        public string Password { get; set; } = string.Empty;
        public bool Status { get; set; }
    }
}
