using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace SeleniumWebDriver
{
     public class UserConfiguration
     {
         private static string companyId = ConfigurationManager.AppSettings["companyID"];
        private static string userId = ConfigurationManager.AppSettings["userID"];
        private static string password = ConfigurationManager.AppSettings["password"];

        public string CompanyId
        {
            get { return companyId; }
            private set { }
        }

        public string UserId
        {
            get { return userId; }
            private set { }
        }

        public string Password
        {
            get { return password; }
            private set { }
        }
    }
}
