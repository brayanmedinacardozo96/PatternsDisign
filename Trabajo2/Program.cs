using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo2.Auth;

namespace Trabajo2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Crear usuarios
            Usuario user1 = new Usuario("Brayan", "Medina","brayan","123");
            Usuario user2 = new Usuario("Victor", "GALVIS","victor","123");
            Usuario user3 = new Usuario("Juan", "Figueroa", "Juan", "123");

            // Crear dependencias
            Dependencia dependencia1 = new Dependencia("Tecnologia");
            Dependencia dependencia2 = new Dependencia("Recursos Humanos");


            //Crear  sede
            Sede sede1 = new Sede("ITM Prado");
            Sede sede2 = new Sede("ITM Robledo");


            // Asignar usuarios a una dependencia
            dependencia1.Agregar(user1);

            //El user1 No se puede agregar, por que ya esta asignado.
            dependencia2.Agregar(user1);  


            sede1.Agregar(user2);



            sede1.MostrarEmpleados();
            dependencia1.MostrarEmpleados();


            //LOGIN

            // Crear un servicio de login nuevo
            ILogin newLoginService = new LoginService();

            // Crear un adaptador que use el nuevo servicio de login
            LoginAdapter loginAdapter = new LoginAdapter(newLoginService);

            // Autenticar usuario usando el adaptador
            bool isAuthenticated = user1.checkUserNameAndPass(loginAdapter, "newUser", "newPassword");



        }
    }
}
