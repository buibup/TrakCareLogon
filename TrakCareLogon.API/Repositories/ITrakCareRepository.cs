using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrakCareLogon.API.Models;

namespace TrakCareLogon.API.Repositories
{
    public interface ITrakCareRepository
    {
        bool Logon(User user);
    }
}
