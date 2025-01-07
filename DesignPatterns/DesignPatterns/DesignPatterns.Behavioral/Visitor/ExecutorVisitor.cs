namespace DesignPatterns.Behavioral.Visitor
{
    public class ExecutorVisitor
    {
        public void Execute()
        {
            Console.WriteLine("Padrão Visitor");

            List<Carro> carros = new List<Carro>(); 
            carros.Add(new Carro() { Nome = "Argo", Preco = 79999.99M, Modelo = "Fiat"});
            carros.Add(new Carro() { Nome = "Pulse", Preco = 120000.00M, Modelo = "Fiat"});
            carros.Add(new Carro() { Nome = "208", Preco = 89000.99M, Modelo = "Pegeout"});

            List<ILoja> lojas = new List<ILoja>();

            foreach (var item in carros)
            {
                Console.WriteLine($"{item.Modelo} {item.Nome}: {item.Preco}");
                lojas.Add(item); 
            }

            Console.WriteLine();
            Console.WriteLine("Aplicando desconto de 12%");

            PrecoVisitor visitor = new PrecoVisitor();  
            foreach (var item in lojas)
            {
                item.Visit(visitor);
            }
        }
    }
}