namespace DesignPatterns.Behavioral.Strategy
{
    public class CompressaoRar : ICompressao
    {
        public void ComprimirArquivo(string nomeArquivo)
        {
            Console.WriteLine($"Compatando o arquivo {nomeArquivo} para rar");
        }
    }
}