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
        public CreationStatus CreateUser(string email, string password, string name)
        {
            try
            {
                AccountDB acctDB = new AccountDB();
                (User, bool) newUser = acctDB.CreateUser(email, PasswordHash.GetHashedPassword(password), name);

                if (newUser.Item2)
                {
                    return CreationStatus.ACCT_ALREADY_EXISTS;
                }

                if (newUser.Item1.name != "ERROR")
                {
                    return CreationStatus.SUCCESS;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return CreationStatus.FAILURE;
        }

        public bool Login(string email, string password)
        {
            try
            {
                AccountDB acctDB = new AccountDB();
                User currentUser = acctDB.UserLogin(email);
                
                if (currentUser.name == "ERROR")
                {
                    return false;
                }

                if (password == currentUser.password)
                {
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
    }
}
