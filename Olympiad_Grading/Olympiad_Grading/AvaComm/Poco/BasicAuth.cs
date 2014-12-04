using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Olympiad_Grading.AvaComm.Poco
{
    public class BasicAuth : Credential
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public BasicAuth(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public string toAuth()
        {
            return "Basic" + " " + EncodeCredentials();
        }

        internal string EncodeCredentials()
        {
            var strCredentials = string.Format("{0}:{1}", UserName, Password);
            var encodedCredentials = Convert.ToBase64String(Encoding.UTF8.GetBytes(strCredentials));

            return encodedCredentials;
        }
    }
}
