using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo2.Auth
{
    internal class LoginAdapter
    {

        private readonly ILogin _loginService;

        public LoginAdapter(ILogin loginService)
        {
            _loginService = loginService;
        }


        public bool Authenticate(string userName, string password)
        {
            return _loginService.authenticateUser(userName, password);
        }

       
    }
}
