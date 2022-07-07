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

        public User(string email, string password, string name, int id)
        {
            this.email = email;
            this.password = password;
            this.name = name;
            this.id = id;
        }
    }
}
