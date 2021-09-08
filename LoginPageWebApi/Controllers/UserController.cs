using LoginPageWebApi.Data;
using LoginPageWebApi.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace LoginPageWebApi.Controllers
{
    public class UserController : ApiController
    {
        private  UserDetailLogic logic;
        public UserController()
        {
            logic = new UserDetailLogic();
        }

        [HttpPost]
        [Route("api/user/Register")]
        public IHttpActionResult Register([FromBody] UserDetail userDetail)
        {
            if (logic.RegisterDetail(userDetail) != 0)
                return Ok();
            else
                return BadRequest();
                
        }

        [HttpGet]
        [Route("api/user/Details/{userName}")]
        public UserDetail Details(string userName)
        {
            return logic.SendDetail(userName);
        }

    }
}