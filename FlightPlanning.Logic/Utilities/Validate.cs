using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FlightPlanning.Logic
{
    public class Validate
    {
        public bool Email(string email)
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
    }
}
