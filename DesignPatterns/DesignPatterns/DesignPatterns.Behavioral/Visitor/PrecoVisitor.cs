namespace DesignPatterns.Behavioral.Visitor
{
    public class PrecoVisitor : IVisitor
    {
        private const int CarroDesconto = 12;
        public void Acept(Carro carro)
        {
            decimal precoCarroAposDesconto = carro.Preco - ((carro.Preco / 100) * 12);
            Console.WriteLine($"{carro.Modelo} {carro.Nome}: {precoCarroAposDesconto}");
        }
    }
}