using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

using FlightPlanning.Models;

namespace FlightPlanning.Database
{
    public class AccountDB
    {
        private readonly User ERROR_USER = new User("ERROR", "ERROR", "ERROR", -999, -999);

        protected SqlConnection connection;
        protected string connectionString;

        public AccountDB()
        {
            connectionString = ConfigurationManager.ConnectionStrings["sqlConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }

        public User UserLogin(string email)
        {
            try
            {
                string selectUserSql = "SELECT * FROM Users WHERE email=@email";
                SqlCommand command = new SqlCommand(selectUserSql, connection);
                command.Parameters.AddWithValue("@email", email);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        connection.Close();
                        return ERROR_USER;
                    }

                    User newUser = new User(reader["email"].ToString(), reader["password"].ToString(), reader["name"].ToString(), (int)reader["id"], (int)reader["miles"]);
                    connection.Close();
                    return newUser;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Error finding user: " + e.Message);
            }

            return ERROR_USER;
        }

        public (User, bool) CreateUser(string email, string password, string name)
        {
            try
            {
                //CHeck if user account already exists
                User userCheck = UserLogin(email);
                if (userCheck.name != "ERROR")
                {
                    return (ERROR_USER, true);
                }


                string insertUserSql = "INSERT INTO Users (email, name, password) VALUES (@email,@name,@password)";

                SqlCommand command = new SqlCommand(insertUserSql, connection);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@password", password);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return (new User(email, password, name, 0, 0), false);
        }
            catch(Exception e)
            {
                Console.WriteLine("Error creating user: " + e.Message);
                return (ERROR_USER, false);
            }
        }
            {
            }
        }
    }
}
