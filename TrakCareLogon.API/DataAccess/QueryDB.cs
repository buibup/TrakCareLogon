using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrakCareLogon.API.DataAccess
{
    public class QueryDB
    {
        public static string Logon()
        {
            return @"
                SELECT SSUSR_Initials, SSUSR_Name, SSUSR_Password 
                FROM SS_USER WHERE SSUSR_Initials = ?
            ";
        }
    }
}