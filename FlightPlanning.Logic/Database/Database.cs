using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FlightPlanning.Database;
using FlightPlanning.Models;

namespace FlightPlanning.Logic
{
    public class Database
    {
        public User loggedInUser { get; private set; }
        public AccountDB acctDB = new AccountDB();
        public CreationStatus CreateUser(string email, string password, string name)
        {
            try
            {
                 return acctDB.CreateUser(email, PasswordHash.GetHashedPassword(password), name);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return CreationStatus.FAILURE;
            }
        }

        public bool Login(string email, string password)
        {
            try
            {
                User currentUser = acctDB.UserLogin(email);
                
                if (currentUser.name == "ERROR")
                {
                    return false;
                }

                if (PasswordHash.VerifyInputPassword(password, currentUser.password))
                {
                    loggedInUser = currentUser;
                    return true;
                }

                return false;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool UpdateUser(User updatedUser)
        {
            try
            {
                return acctDB.UpdateUser(updatedUser);
            }
            catch(Exception e)
            {
                Console.WriteLine("Error updating user: " + e.Message);
                return false;
            }
        }

    }
}
