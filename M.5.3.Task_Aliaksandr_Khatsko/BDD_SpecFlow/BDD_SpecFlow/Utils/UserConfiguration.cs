using System.Configuration;

namespace BDD_SpecFlow
{
    public class UserConfiguration
    {
        private static string logIn = ConfigurationManager.AppSettings["logIn"];
        private static string password = ConfigurationManager.AppSettings["password"];

        public string LogIn
        {
            get { return logIn; }
            private set { }
        }

        public string Password
        {
            get { return password; }
            private set { }
        }
    }
}
