namespace DesignPatterns.Behavioral.Command
{
    public class Garcom
    {
        private Pedido _pedido;

        public Garcom(Pedido pedido)
        {
            _pedido = pedido;
        }

        public void Execute()
        {
            _pedido.Execute();
        }
    }
}