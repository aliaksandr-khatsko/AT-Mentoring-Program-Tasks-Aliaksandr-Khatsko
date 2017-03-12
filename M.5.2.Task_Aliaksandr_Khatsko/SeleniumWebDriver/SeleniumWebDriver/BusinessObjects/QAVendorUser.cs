using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriver
{
    public class QAVendorUser:BaseUser
    {

        public override string CompanyId(UserConfiguration conf)
        {
            return conf.QAVendorCompanyId;
        }

        public override string UserId(UserConfiguration conf)
        {
            return conf.QAVendorUserId;
        }

        public override string Password(UserConfiguration conf)
        {
            return conf.QAVendorPassword;
        }


    }
}
