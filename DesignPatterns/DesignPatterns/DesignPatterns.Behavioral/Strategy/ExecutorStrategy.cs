namespace DesignPatterns.Behavioral.Strategy
{
    public class ExecutorStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Strategy");

            CompressContext context = new CompressContext(new CompressaoRar());
            Console.WriteLine("Informe o nome do arquivo:");

            var nome = Console.ReadLine();

            Console.WriteLine("Informe o nome do padrão pra usar");
            Console.WriteLine("1 - rar / 2 - zip / 3 - gzip");

            var padrao = Convert.ToInt32(Console.ReadLine());

            if (padrao == 2)
            {
                context.DefineStrategy(new CompressaoZip());
            }
            else if (padrao == 3)
            {
                context.DefineStrategy(new CompressaoGzip());
            }

            context.CriarArquivoCompactado(nome);

            Console.Read();
        }
    }
}