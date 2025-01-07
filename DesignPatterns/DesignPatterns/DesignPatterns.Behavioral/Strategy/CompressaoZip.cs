namespace DesignPatterns.Behavioral.Strategy
{
    public class CompressaoZip : ICompressao
    {
        public void ComprimirArquivo(string nomeArquivo)
        {
            Console.WriteLine($"Compatando o arquivo {nomeArquivo} para zip");
        }
    }
}