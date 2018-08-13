using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace AppDataStore
{
    public static class AppConfiguration
    {
        public static  string DbConnectionStr = ConfigurationManager.ConnectionStrings["StudentManagementDb"].ConnectionString;
        
    }
}