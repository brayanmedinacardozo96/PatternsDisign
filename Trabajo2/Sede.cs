using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo2
{
    // Clase compuesta: Dependencia
    internal class Sede : OrganizacionComponent
    {
        private List<OrganizacionComponent> components = new List<OrganizacionComponent>();

        public Sede(string name)
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
                    components.Add(user);
                }
                else
                {
                    Console.WriteLine($"{user.Name} ya esta asignado a una Dependencia o Sede.");
                }
            }
            else
            {
                components.Add(component);
            }
        }

        public override void Mostrar()
        {
            Console.WriteLine($"Sede: {Name}");
           
        }

        public override void MostrarEmpleados()
        {
            Console.WriteLine($"Empleados Sede: {Name}");

            foreach (var component in components)
            {
                if (component is Usuario)
                {
                    component.Mostrar();
                }
            }
        }

        public override void Quitar(OrganizacionComponent component)
        {
            if (component is Usuario user)
            {
                user.Unassign();
            }
            components.Remove(component);
        }
    }
}
