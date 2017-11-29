using System;
//using System.Collections.Generic;
using System.Configuration;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace AutoTest.webdriver
{
    class Configuration
    {
        public static string GetEnvironmentVar(string var, string defaultValue)
        {
            return ConfigurationManager.AppSettings[var] ?? defaultValue;
        }

        public static string ElementTimeOut => GetEnvironmentVar("ElementTimeout", "30");

        public static string Browser => GetEnvironmentVar("Browser", "Firefox");
        
    }
}
