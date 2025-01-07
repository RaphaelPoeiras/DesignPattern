namespace DesignPatterns.Structural.Decorator
{
    public class Bacon : PizzaDecorator
    {
        public Bacon(IPizza pizza) : base(pizza)
        {
        }

        public override string Opcionais()
        {
            var opcional = base.Opcionais();
            opcional += " com bacon";
            return opcional;
        }

        public override decimal Preco()
        {
            var preco = base.Preco();
            preco += 4.00M;
            return preco;
        }
    }
}