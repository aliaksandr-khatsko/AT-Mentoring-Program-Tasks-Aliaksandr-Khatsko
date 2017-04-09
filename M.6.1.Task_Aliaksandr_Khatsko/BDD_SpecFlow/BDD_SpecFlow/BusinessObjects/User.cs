using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_SpecFlow
{
    public class User
    {
        public string LogIn(UserConfiguration conf)
        {
            return conf.LogIn;
        }

        public string Password(UserConfiguration conf)
        {
            return conf.Password;
        }
    }
}
