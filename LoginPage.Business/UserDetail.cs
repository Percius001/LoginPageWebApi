using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LoginPage.Business
{
    public class UserDetail
    {
        [Key]
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
