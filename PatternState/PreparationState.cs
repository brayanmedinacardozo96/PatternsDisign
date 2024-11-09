using System;


namespace PatternState
{
    internal class PreparationState : IOrderState
    {
        public void Process(Order order)
        {
            Console.WriteLine("Pedido en estado 'Preparación': Notificando a la empresa transportadora para enviar el pedido.");
            order.SetState(new TransitState());
        }
    }
}
