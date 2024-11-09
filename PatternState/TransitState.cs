using System;


namespace PatternState
{
    internal class TransitState : IOrderState
    {
        public void Process(Order order)
        {
            Console.WriteLine("Pedido en estado 'Tránsito': Confirmando datos del destinatario y notificando al cliente.");
            order.SetState(new CompleteState());
        }
    }
}
