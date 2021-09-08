
using LoginPageWebApi.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace LoginPageWebApi.Business
{
    public class UserDetailLogic
    {
        public int RegisterDetail(UserDetail userDetail)
        {
            UserDataAccessLayer userDataAccessLayer = new UserDataAccessLayer();
            return userDataAccessLayer.AddAUser(userDetail);
        }

        public UserDetail SendDetail(string userName)
        {
            UserDataAccessLayer userDataAccessLayer = new UserDataAccessLayer();
            return userDataAccessLayer.GetAUser(userName);
        }


    }
}
