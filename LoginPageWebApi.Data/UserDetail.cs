using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LoginPageWebApi.Data
{
    public class UserDetail
    {
        [Key]
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
