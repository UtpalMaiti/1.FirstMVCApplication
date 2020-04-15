using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstMVCApplication.Models
{
    public class LoginInfo
    {
        [Required(ErrorMessage ="Please Enter UserName")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Please Enter PassWord")]
        public string PassWord { get; set; }
    }
}