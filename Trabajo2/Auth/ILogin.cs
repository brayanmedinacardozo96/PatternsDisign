using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo2.Auth
{
    internal interface ILogin
    {
        bool authenticateUser(String username, String password);
    }
}
