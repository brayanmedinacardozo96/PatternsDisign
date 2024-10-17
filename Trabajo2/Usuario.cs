using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo2.Auth;

namespace Trabajo2
{

    // Clase hoja: Usuario
    internal class Usuario : OrganizacionComponent
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public Usuario(string firstName, string lastName, string userName, string password) { 
         
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Password = password;
            Name = firstName +" "+lastName;

        }

        // Indica si el usuario ya está asignado a una dependencia o sede
        public bool IsAssigned { get; private set; }


        public bool checkUserNameAndPass(LoginAdapter adapter, string userName, string password) {

            return adapter.Authenticate(userName, password);

            //Implementacion antigua
            /*
            if (userName == null || Password == null) { return false; }

            if (userName!=this.UserName || Password != password) { 
              return false;
            }

            return true;
            */

        }

        // Método para asignar el usuario a una dependencia o sede
        public void Assign()
        {
            if (!IsAssigned)
            {
                IsAssigned = true;
            }
            else
            {
                throw new InvalidOperationException($"{FirstName} {LastName} ya esta asignado a una Dependencia o Sede.");
            }
        }

        // Método para desasignar el usuario cuando se remueve de una dependencia o sede
        public void Unassign()
        {
            IsAssigned = false;
        }


        // Los usuarios no pueden agregar o remover otros componentes
        public override void Agregar(OrganizacionComponent component)
        {
            throw new NotImplementedException();
        }

        public override void Quitar(OrganizacionComponent component)
        {
            throw new NotImplementedException();
        }

        public override void Mostrar()
        {
            Console.WriteLine("Nombre del usuario: "+Name);
        }

        public override void MostrarEmpleados()
        {
            throw new NotImplementedException();
        }
    }
}
