namespace PatternState
{
    internal class Order
    {
        private IOrderState _state;


        /// <summary>
        /// Constructor, aqui se inicia el estado del pedido a "Nueva Orden"
        /// </summary>
        public Order() { 
            _state= new NewState();
        }


        /// <summary>
        ///  Método para cambiar el estado del pedido
        /// </summary>
        /// <param name="newState"></param>
        public void SetState(IOrderState newState)
        {
            _state = newState;
        }


        /// <summary>
        ///  Método para procesar el pedido basado en su estado actua
        /// </summary>
        public void ProcessOrder() {
            _state.Process(this);
        }

    }
}
