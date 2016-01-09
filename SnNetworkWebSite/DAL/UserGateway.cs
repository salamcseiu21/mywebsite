using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using SnNetworkWebSite.Models;

namespace SnNetworkWebSite.DAL
{
    public class UserGateway:DBGateway
    {
        public int Insert(User anUser)
        {
            string query = "INSERT INTO t_Users VALUES(@userId,@userName,@email,@password)";
            CommandObj.CommandText = query;
            CommandObj.Parameters.Clear();
            CommandObj.Parameters.AddWithValue("@userId", anUser.UserId);
            CommandObj.Parameters.AddWithValue("@userName", anUser.UserName);
            CommandObj.Parameters.AddWithValue("@email", anUser.Email);
            CommandObj.Parameters.AddWithValue("@password", anUser.Password);
            ConnectionObj.Open();
            int rowAffected = CommandObj.ExecuteNonQuery();
            return rowAffected;
        }

        public User GetUserByEmail(string email)
        {
            string query = "SELECT * FROM t_Users WHERE Email=@email";
            CommandObj.CommandText = query;
            CommandObj.Parameters.Clear();
            CommandObj.Parameters.AddWithValue("@email", email);
            User anUser = null;
            ConnectionObj.Open();
            SqlDataReader reader = CommandObj.ExecuteReader();
            if (reader.Read())
            {
                anUser=new User();
                anUser.UserId = reader["UserId"].ToString();
                anUser.UserName = reader["UserName"].ToString();
                anUser.Email = reader["Email"].ToString();
                anUser.Password = reader["Password"].ToString();
            }
            reader.Close();
            CommandObj.Dispose();
            ConnectionObj.Close();
            return anUser;
        }

        public bool IsUserNameAndPasswordCorrect(string userName, string password)
        {
            string query = "SELECT UserName FROM t_Users WHERE UserName=@name and Password=@pass ";
            CommandObj.CommandText = query;
            CommandObj.Parameters.Clear();
            CommandObj.Parameters.AddWithValue("@name", userName);
            CommandObj.Parameters.AddWithValue("@pass", password);
            ConnectionObj.Open();
            string result = Convert.ToString(CommandObj.ExecuteScalar());
            ConnectionObj.Close();
            if (String.IsNullOrEmpty(result)) return false;

            return true;
        }
    }
}