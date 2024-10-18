namespace Trabajo2.Auth
{

    // Nuevo sistema de autenticación
    internal class LoginService : ILogin
    {
        // Implementación del nuevo sistema de autenticación
     
        public bool authenticateUser(string username, string password, Usuario usuario)
        {
            // Nueva lógica de autenticación
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return false;
            }

         
            return username == usuario.UserName && password == usuario.Password;

        }
    }
}
