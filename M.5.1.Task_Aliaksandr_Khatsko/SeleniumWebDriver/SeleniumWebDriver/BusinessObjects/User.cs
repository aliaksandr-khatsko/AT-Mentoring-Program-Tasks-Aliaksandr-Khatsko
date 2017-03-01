using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Drawing.Text;

namespace SeleniumWebDriver
{
    public class User
    {
        //private static string companyId = ConfigurationManager.AppSettings["companyID"];
        //private static string userId = ConfigurationManager.AppSettings["userID"];
        //private static string password = ConfigurationManager.AppSettings["password"];

        public string CompanyId(UserConfiguration conf)
        {
            return conf.CompanyId;
        }

        public string UserId(UserConfiguration conf)
        {
            return conf.UserId;
        }

        public string Password(UserConfiguration conf)
        {
            return conf.Password;
        }
    }
}
