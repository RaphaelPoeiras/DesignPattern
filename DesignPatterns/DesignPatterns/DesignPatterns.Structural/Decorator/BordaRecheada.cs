namespace DesignPatterns.Structural.Decorator
{
    public class BordaRecheada : PizzaDecorator
    {
        public BordaRecheada(IPizza pizza) : base(pizza)
        {
        }

        public override string Opcionais()
        {
            var opcional = base.Opcionais();
            opcional += " com borda recheada";
            return opcional;
        }

        public override decimal Preco()
        {
            var preco = base.Preco();
            preco +=3.00M;
            return preco;
        }
    }
}