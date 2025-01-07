namespace DesignPatterns.Structural.Decorator
{
    public abstract class PizzaDecorator : IPizza
    {
        protected readonly IPizza pizza;

        public PizzaDecorator(IPizza pizza)
        {
            this.pizza = pizza;
        }

        public virtual string Opcionais()
        {
            var opcional = pizza.Opcionais();
            return opcional;
        }

        public virtual decimal Preco()
        {
            return pizza.Preco();
        }
    }
}
