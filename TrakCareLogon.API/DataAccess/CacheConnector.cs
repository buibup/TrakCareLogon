using Dapper;
using InterSystems.Data.CacheClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using TrakCareLogon.API.Models;

namespace TrakCareLogon.API.DataAccess
{
    public class CacheConnector : IDataConnection
    {
        private const string db = "Cache";
        private OdbcConnection cacheConnection;
        public CacheConnector()
        {
            cacheConnection = new OdbcConnection(GlobalConfig.CnnString(db));
        }
        public bool Logon(User user)
        {
            var userTC = new User();

            using (IDbConnection connection = cacheConnection)
            {
                userTC = connection.QueryFirstOrDefaultAsync<User>(QueryDB.Logon(), new { SSUSR_Initials = user.SSUSR_Initials }).Result;
            }

            if(CacheConnectorProcessor.CheckPassword(userTC, user.SSUSR_Password))
            {
                return true;
            }

            return false;
        }
    }
}