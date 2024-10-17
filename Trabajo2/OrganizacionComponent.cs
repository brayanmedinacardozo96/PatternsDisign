using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo2
{

    // Componente base
    internal abstract class OrganizacionComponent
    {
        public string Name { get; set; }

        // Métodos comunes para los componentes
        public abstract void Agregar(OrganizacionComponent component);
        public abstract void Quitar(OrganizacionComponent component);
        public abstract void MostrarEmpleados();
    }
}
