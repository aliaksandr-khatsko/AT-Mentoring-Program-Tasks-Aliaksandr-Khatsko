using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Drawing.Text;

namespace SeleniumWebDriver
{
    public abstract class BaseUser
    {
        public abstract string CompanyId(UserConfiguration conf);
        public abstract string UserId(UserConfiguration conf);
        public abstract string Password(UserConfiguration conf);

    }
}
