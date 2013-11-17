using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Adagi.Utilities
{
    public class Settings
    {
        public static string Get(string key)
        {
            return WebConfigurationManager.AppSettings[key];
        }
    }
}