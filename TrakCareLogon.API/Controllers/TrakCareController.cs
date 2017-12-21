using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TrakCareLogon.API.Models;

namespace TrakCareLogon.API.Controllers
{
    public class TrakCareController : ApiController
    {
        public TrakCareController()
        {
            GlobalConfig.InitializeConnections();
        }

        [HttpPost]
        public bool LogonSuccess(string username, string password)
        {
            var user = new User
            {
                SSUSR_Initials = username,
                SSUSR_Password = password
            };

            return GlobalConfig.Connection.Logon(user);
        }
    }
}
