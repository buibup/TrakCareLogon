using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using TrakCareLogon.API.DataAccess;

namespace TrakCareLogon.API
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnections()
        {
            CacheConnector cache = new CacheConnector();
            Connection = cache;
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}