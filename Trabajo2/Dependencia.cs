using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo2
{

    // Clase compuesta: Dependencia
    internal class Dependencia : OrganizacionComponent
    {
        private List<OrganizacionComponent> componentes = new List<OrganizacionComponent>();

        public Dependencia(string name)
        {
            this.Name = name;
        }

        public override void Agregar(OrganizacionComponent component)
        {
            if (component is Usuario user)
            {
                if (!user.IsAssigned)
                {
                    user.Assign();
                    componentes.Add(user);
                }
                else
                {
                    Console.WriteLine($"{user.Name} ya esta asignado a una Dependencia o Sede.");
                }
            }
            else
            {
                componentes.Add(component);
            }
        }

        public override void MostrarEmpleados()
        {
            Console.WriteLine($"Dependencia: {Name}");
            foreach (var component in componentes)
            {
                if (component is Usuario)
                {
                    continue;
                }

                component.MostrarEmpleados();
            }
        }

        public override void Quitar(OrganizacionComponent component)
        {
            if (component is Usuario user)
            {
                user.Unassign();
            }
            componentes.Remove(component);
        }
    }
}
