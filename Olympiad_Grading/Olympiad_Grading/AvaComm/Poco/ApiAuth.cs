using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Olympiad_Grading.AvaComm.Poco
{
    public class ApiAuth : Credential
    {
        public string ApiKey { get; private set; }

        public ApiAuth(string apiKey)
        {
            ApiKey = apiKey;
        }

        public string toAuth()
        {
            return "apikey " + ApiKey;
        }
    }
}
