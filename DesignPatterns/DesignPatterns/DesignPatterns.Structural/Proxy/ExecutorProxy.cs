namespace DesignPatterns.Structural.Proxy
{
    public class ExecutorProxy
    {
        public void Execute()
        {
            Console.WriteLine("Exemplo proxy");

            Funcionario programador = new Funcionario("Priscila", "programador");
            Funcionario ceo = new Funcionario("Raphael", "CEO");

            Console.WriteLine("Programador tentando acessar pasta");
            PastaCompartilhadaProxy proxy = new PastaCompartilhadaProxy(programador);
            proxy.OperacaoLeituraGravacao();

            Console.WriteLine("CEO tentando acessar pasta");
            PastaCompartilhadaProxy proxy2 = new PastaCompartilhadaProxy(ceo);
            proxy2.OperacaoLeituraGravacao();
        }
    }
}