using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace FlightPlanning.Logic
{
    public class PasswordHash
    {
        const int SALT_SIZE = 16;
        const int SALT_ITERATIONS = 10000;

        public static string GetHashedPassword(string inputPassword)
        {
            byte[] salt = new byte[SALT_SIZE];

            new RNGCryptoServiceProvider().GetBytes(salt);

            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(inputPassword, salt, SALT_ITERATIONS);
            byte[] hash = pbkdf2.GetBytes(20);

            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            string hashedPassword = Convert.ToBase64String(hashBytes);
            return hashedPassword;
        }

        public static bool VerifyInputPassword(string inputPassword, string hashedPassword)
        {
            byte[] hashBytes = Convert.FromBase64String(hashedPassword);

            byte[] salt = new byte[SALT_SIZE];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(inputPassword, salt, SALT_ITERATIONS);
            byte[] hash = pbkdf2.GetBytes(20);

            for (int i = 0; i < 20; i++)
            {
                if (hashBytes[i+16] != hash[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
