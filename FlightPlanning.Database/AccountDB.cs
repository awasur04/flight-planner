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

        public CreationStatus CreateUser(string email, string password, string name)
        {
            try
            {
                //CHeck if user account already exists
                User userCheck = UserLogin(email);
                if (userCheck.Name != "ERROR")
                {
                    return CreationStatus.ACCT_ALREADY_EXISTS;
                }


                string insertUserSql = "INSERT INTO Users (email, name, password) VALUES (@email,@name,@password)";

                SqlCommand command = new SqlCommand(insertUserSql, connection);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@password", password);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return CreationStatus.SUCCESS;
        }
            catch(Exception e)
            {
                Console.WriteLine("Error creating user: " + e.Message);
                return CreationStatus.FAILURE;
            }
        }

        public bool UpdateUser(User user)
        {
            try
            {
                string updateUserSql = "UPDATE Users SET email=@email, name=@name, password=@password, miles=@miles WHERE id=@id";

                SqlCommand command = new SqlCommand(updateUserSql, connection);
                command.Parameters.AddWithValue("@email", user.Email);
                command.Parameters.AddWithValue("@name", user.Name);
                command.Parameters.AddWithValue("@password", user.Password);
                command.Parameters.AddWithValue("@miles", user.Miles);
                command.Parameters.AddWithValue("@id", user.Id);

                connection.Open();
                int updateRows = command.ExecuteNonQuery();
                connection.Close();

                if (updateRows == 1)
                {
                    return true;
                }
                return false;
            }
            catch(Exception e)
            {
                Console.WriteLine("Error updating user: " + e.Message);
                return false;
            }
        }

        public bool RemoveUser(User user)
        {
            try
            {
                string removeUserSql = "DELETE FROM Users WHERE id=@id";

                SqlCommand command = new SqlCommand(removeUserSql, connection);
                command.Parameters.AddWithValue("@id", user.Id);

                connection.Open();
                int updateRows = command.ExecuteNonQuery();
                connection.Close();

                if (updateRows == 1)
                {
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error removing user: " + e.Message);
                return false;
            }
        }
    }
}
