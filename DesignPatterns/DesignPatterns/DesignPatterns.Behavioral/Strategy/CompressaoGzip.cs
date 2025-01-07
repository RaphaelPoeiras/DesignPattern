namespace DesignPatterns.Behavioral.Strategy
{
    public class CompressaoGzip : ICompressao
    {
        public void ComprimirArquivo(string nomeArquivo)
        {
            Console.WriteLine($"Compatando o arquivo {nomeArquivo} para gzip");
        }
    }
}