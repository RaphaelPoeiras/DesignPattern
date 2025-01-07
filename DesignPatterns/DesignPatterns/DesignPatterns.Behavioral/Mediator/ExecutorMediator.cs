namespace DesignPatterns.Behavioral.Mediator
{
    public class ExecutorMediator
    {
        public void Execute()
        {
            FacebookGroupMediator mediator = new ConcreteFacebookGroupMediator();

            User raphael = new ConcreteUser(mediator, "Raphael");
            User benicio = new ConcreteUser(mediator, "Benicio");
            User priscila = new ConcreteUser(mediator, "Priscila");

            mediator.RegisterUser(raphael);
            mediator.RegisterUser(benicio);
            mediator.RegisterUser(priscila);

            raphael.Send("Oi Família!");
            benicio.Send("Oi pessoal!");
            priscila.Send("Oi meninos!");

            Console.ReadKey();
        }
    }
}
