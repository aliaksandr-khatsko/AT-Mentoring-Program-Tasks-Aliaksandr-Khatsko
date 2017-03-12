using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace SeleniumWebDriver
{
     public class UserConfiguration
     {
         private static string qaVendorCompanyID = ConfigurationManager.AppSettings["qaVendorCompanyID"];
         private static string qaVendorUserID = ConfigurationManager.AppSettings["qaVendorUserID"];
         private static string qaVendorPassword = ConfigurationManager.AppSettings["qaVendorPassword"];
         private static string merckCompanyID = ConfigurationManager.AppSettings["merckCompanyID"];
         private static string merckUserID = ConfigurationManager.AppSettings["merckUserID"];
         private static string merckPassword = ConfigurationManager.AppSettings["merckPassword"];

        public string QAVendorCompanyId
        {
            get { return qaVendorCompanyID; }
            private set { }
        }

        public string QAVendorUserId
        {
            get { return qaVendorUserID; }
            private set { }
        }

        public string QAVendorPassword
        {
            get { return qaVendorPassword; }
            private set { }
        }

        public string MerckCompanyId
        {
            get { return merckCompanyID; }
            private set { }
        }

        public string MerckUserId
        {
            get { return merckUserID; }
            private set { }
        }

        public string MerckPassword
        {
            get { return merckPassword; }
            private set { }
        }
    }
}
