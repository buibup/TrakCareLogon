using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrakCareLogon.API.Models;

namespace TrakCareLogon.API.DataAccess
{
    public interface IDataConnection
    {
        bool Logon(User user);
    }
}
