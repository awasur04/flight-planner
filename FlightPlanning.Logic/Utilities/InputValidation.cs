using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FlightPlanning.Logic
{
    public static class InputValidation
    {
        public static bool Email(string email)
        {
            EmailAddressAttribute eAddr = new EmailAddressAttribute();

            if (eAddr.IsValid(email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Password(string password)
        {
            if (password.Length > 4)
            {
                return true;
            }
            return false;
        }

        public static bool Name(string name)
        {
            if (name.Length > 1)
            {
                return true;
            }
            return false;
        }
    }
}
