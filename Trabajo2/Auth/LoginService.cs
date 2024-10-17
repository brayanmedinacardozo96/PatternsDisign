using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo2.Auth
{

    // Nuevo sistema de autenticación
    internal class LoginService : ILogin
    {
        // Implementación del nuevo sistema de autenticación
     
        public bool authenticateUser(string username, string password)
        {
            // Nueva lógica de autenticación
            // Por ejemplo, puede incluir validación con un sistema externo, hashing de contraseñas, etc.
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return false;
            }

            // Ejemplo de lógica simple (puedes modificar esta lógica según sea necesario)
            return username == "newUser" && password == "newPassword";

        }
    }
}
