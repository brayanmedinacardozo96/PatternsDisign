using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternState
{
    internal class NewState : IOrderState
    {
        public void Process(Order order)
        {
            Console.WriteLine("Pedido en estado 'Nueva Orden': Notificando al equipo de despacho.");
            order.SetState(new PreparationState());
        }
    }
}
