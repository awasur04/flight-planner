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
                        return new User("ERROR", "ERROR", "ERROR", -999);
                    }

                    User newUser = new User(reader["email"].ToString(), reader["password"].ToString(), reader["name"].ToString(), (int)reader["id"]);
                    connection.Close();
                    return newUser;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return new User("ERROR", "ERROR", "ERROR", -999);
        }

        public (User, bool) CreateUser(string email, string password, string name)
        {
            try
            {
                //CHeck if user account already exists
                User userCheck = UserLogin(email);
                if (userCheck.name != "ERROR")
                {
                    return (new User("ERROR", "ERROR", "ERROR", -999), true);
                }


                string insertUserSql = "INSERT INTO Users (email, name, password) VALUES (@email,@name,@password)";

                SqlCommand command = new SqlCommand(insertUserSql, connection);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@password", password);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

                return (new User(email, password, name, 0), false);
        }
            catch
            {
                return (new User("ERROR", "ERROR", "ERROR", -999), false);
            }
        }
    }
}
