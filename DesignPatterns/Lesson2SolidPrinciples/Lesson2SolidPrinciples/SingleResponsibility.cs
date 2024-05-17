using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2SolidPrinciples.SingleResopsibility
{
    static class Hasher
    {
        public static string GetHash(string content)
        {
            using SHA256 sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(content));
            var sb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
                sb.Append(bytes[i]);
            return sb.ToString();
        }
    }

    class MailService
    {
        public static void SendMail(string to, string subject, string body)
        {

        }
    }

    class UserManager
    {
        private readonly MailService mailService;

        public UserManager(MailService mailService)
        {
            this.mailService = mailService;
        }

        public static bool Login(string username, string password)
        {
            var passwordHash = Hasher.GetHash(password);

            //check
            return true;
        }
    }

    class AccountViewModel
    {
        public bool RegisterCommandMethod(string username, string password)
        {
            // check
            var passwordHash = Hasher.GetHash(password);

            // Register
            return true;
        }
        public bool LoginCommandMethod(string username, string password)
        {
            var result = UserManager.Login(username, password);
            return result;
        }
    }


}
