using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text; 

namespace LoginPageWebApi.Data
{
    public class UserDataAccessLayer
    {
        private string connectionString = "Data Source = (local);Initial Catalog = UserDetailDB; Integrated Security=SSPI;";
        public UserDetail GetAUser(string userName)
        {
            UserDetail user = new UserDetail();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("select * from UserProperty where UserName = @name", con);
                cmd.Parameters.AddWithValue("@name",userName);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    user.UserName = reader["UserName"].ToString();
                    user.Password = reader["Password"].ToString();
                }
                return user;
            }
        }

        public int AddAUser(UserDetail userDetail)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("insert into UserProperty(UserName,Password) values(@name,@pass)", con);
                cmd.Parameters.AddWithValue("@name", userDetail.UserName);
                cmd.Parameters.AddWithValue("@pass", userDetail.Password);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
