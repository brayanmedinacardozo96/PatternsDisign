using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
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

            //Nombre de las dependencias
            dependencia1.Mostrar();
            dependencia2.Mostrar();


            //Crear  sede
            Sede sede1 = new Sede("ITM Prado");
            Sede sede2 = new Sede("ITM Robledo");

            //Nombre de las sedes
            sede1.Mostrar();
            sede2.Mostrar();


            // Asignar usuarios a una dependencia
            dependencia1.Agregar(user1);

            //El user1 No se puede agregar, por que ya esta asignado.
            dependencia2.Agregar(user1);  


            sede1.Agregar(user2);


            //Mostrar empleados
            sede1.MostrarEmpleados();
            dependencia1.MostrarEmpleados();


            /**
             *Pruebas Sistemas de Login
             */

           
            //LOGIN
            // Crear un servicio del login nuevo
            ILogin newLoginService = new LoginService();

            // Crear un adaptador que use el nuevo servicio de login
            LoginAdapter loginAdapter = new LoginAdapter(newLoginService);

            // Autenticar un usuario usando el adaptador
            bool isAuthenticated = user1.checkUserNameAndPass(loginAdapter, user1.UserName, user1.Password);

            if (isAuthenticated)
            {
                Console.WriteLine($"Usuario: {user1.Name} autenticado con exito" );
            }
            else {
                Console.WriteLine($"Usuario: {user1.Name} FALLO autenticación");
            }

             isAuthenticated = user1.checkUserNameAndPass(loginAdapter, "newUser", "newPassword");

            if (isAuthenticated)
            {
                Console.WriteLine($"Usuario: {user1.Name} autenticado con exito");
            }
            else
            {
                Console.WriteLine($"Usuario: {user1.Name} FALLO autenticación");
            }

        }
    }
}
