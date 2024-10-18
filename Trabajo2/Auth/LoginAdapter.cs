namespace Trabajo2.Auth
{
    internal class LoginAdapter
    {

        private readonly ILogin _loginService;

        public LoginAdapter(ILogin loginService)
        {
            _loginService = loginService;
        }


        public bool Authenticate(string userName, string password, Usuario usuario)
        {
            return _loginService.authenticateUser(userName, password, usuario);
        }

       
    }
}
