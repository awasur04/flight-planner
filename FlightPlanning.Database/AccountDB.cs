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
