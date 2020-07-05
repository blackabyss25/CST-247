using Activity1Part3.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Activity1Part3.Services.Data
{
    public class SecurityDAO
    {

        public bool FindByUser(UserModel user)
        {
            string username = user.Username;
            string password = user.Password;
            Console.WriteLine("user.Username: " + username);
            Console.WriteLine("user.Password: " + password);

            bool userFound = false;

            string query = @"SELECT * FROM dbo.users WHERE USERNAME = '" + username + "' AND PASSWORD = '" + password+"'";
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandTimeout = 15;
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    userFound = true;
                }
                else
                {
                    userFound = false;
                }
                return userFound;
            }




        }
    }
}