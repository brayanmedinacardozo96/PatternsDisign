using System;

namespace Trabajo2.Auth
{
    internal interface ILogin
    {
        bool authenticateUser(String username, String password, Usuario usuario);
    }
}
