using System;


namespace PatternState
{
    internal class CompleteState : IOrderState
    {
        public void Process(Order order)
        {
            Console.WriteLine("Pedido en estado 'Completado': Notificando al cliente para que califique el servicio.");
            // El pedido permanece en "Completado" y no se realizan cambios adicionales de estado.
        }
    }
}
