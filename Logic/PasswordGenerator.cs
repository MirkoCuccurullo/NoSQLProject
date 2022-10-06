using System;
using System.Security.Cryptography;
using System.Web.Security;

namespace Logic
{
    public class PasswordGenerator
    {
        private byte[] saltBytes;
        private RNGCryptoServiceProvider provider;
        public PasswordGenerator()
        {
            saltBytes = new byte[64];
            provider = new RNGCryptoServiceProvider();
        }
        public string GetSaltOfHashedPassword(string password)
        {
            provider = new RNGCryptoServiceProvider();
            provider.GetNonZeroBytes(saltBytes);
            return Convert.ToBase64String(saltBytes);
        }

        public  string GeneratedHashedSaltPassword(string password)
        {
            Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, saltBytes, 10000);
            string hashPassword = Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(32)); //using 32 bits 
            return hashPassword;
        }
        public string RandomPasswordGenrator()
        {
  
            //Store the password generated into a string variable
            //The password will have a length of 8 characters and 3 non alphanumeric characters
  
            return Membership.GeneratePassword(8, 3); 
        }
       
    }
}
