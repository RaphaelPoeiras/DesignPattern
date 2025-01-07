namespace DesignPatterns.Structural.Proxy
{
    public class PastaCompartilhada : IPastaCompartilhada
    {
        public void OperacaoLeituraGravacao()
        {
            Console.WriteLine("Operação de leitura e gravação está sendo executada");
        }
    }
}