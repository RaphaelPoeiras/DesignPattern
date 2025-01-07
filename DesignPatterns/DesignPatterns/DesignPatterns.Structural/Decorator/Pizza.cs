namespace DesignPatterns.Structural.Decorator
{
    public class Pizza : IPizza
    {
        public string Nome { get; set; }
        public Pizza(string nome) { Nome = nome; }

        public string Opcionais()
        {
            return $"Pizza de {Nome}";
        }

        public decimal Preco()
        {
            var preco = 10.00M;
            return preco;
        }
    }
}