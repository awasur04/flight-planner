using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightPlanning.Models
{
    public class User
    {
        public string email { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public int id { get; set; }
        public int miles { get; set; }

        public User(string email, string password, string name, int id, int miles)
        {
            this.email = email;
            this.password = password;
            this.name = name;
            this.id = id;
            this.miles = miles;
        }  
        
        public string GetLoyaltyLevel()
        {
            //Silver, Gold, Platinum, Executive

            switch(miles)
            {
                case int n when (n < 3000):
                    return "Silver";

                case int n when (n < 10000 && n >= 3000):
                    return "Gold";

                case int n when (n < 50000 && n >= 10000):
                    return "Platinum";

                case int n when (n >= 50000):
                    return "Executive";
            }

            return "Error";
        }
    }
}
