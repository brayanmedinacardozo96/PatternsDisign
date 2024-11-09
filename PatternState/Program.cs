using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternState
{
    internal class Program
    {

        static void Main(string[] args)
        {


            Order order = new Order();


            // Procesar el pedido hasta completarlo

            order.ProcessOrder(); // Cambia a "Preparación"
            order.ProcessOrder(); // Cambia a "Tránsito"
            order.ProcessOrder(); // Cambia a "Completado"
            order.ProcessOrder(); // El pedido ya está completado, no cambia más


        }
    }
}
