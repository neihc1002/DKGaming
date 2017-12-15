using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DKGaming.Areas.Admin.Models
{
    public class User
    {
        [Required(ErrorMessage = "Nhập tên tài khoản")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Nhập mật khẩu")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}