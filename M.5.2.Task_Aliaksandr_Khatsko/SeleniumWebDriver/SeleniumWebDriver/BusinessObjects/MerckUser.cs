using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriver
{
    public class MerckUser:BaseUser
    {

        public override string CompanyId(UserConfiguration conf)
        {
            return conf.MerckCompanyId;
        }

        public override string UserId(UserConfiguration conf)
        {
            return conf.MerckCompanyId;
        }

        public override string Password(UserConfiguration conf)
        {
            return conf.MerckCompanyId;
        }

    }
}
