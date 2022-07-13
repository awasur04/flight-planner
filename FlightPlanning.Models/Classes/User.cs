using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightPlanning.Models
{
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
        public int Miles { get; set; }

        public User(string email, string password, string name, int id, int miles)
        {
            this.Email = email;
            this.Password = password;
            this.Name = name;
            this.Id = id;
            this.Miles = miles;
        }  
        
        public string GetLoyaltyLevel()
        {
            //Silver, Gold, Platinum, Executive

            switch(Miles)
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
