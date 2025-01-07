namespace DesignPatterns.Behavioral.Mediator
{
    public class ConcreteUser : User
    {
        public ConcreteUser(FacebookGroupMediator facebookGroupMediator, string name) : base(facebookGroupMediator, name) { }

        public override void Receive(string msg)
        {
            Console.WriteLine($"{Name}: recebida <= {msg}");
        }

        public override void Send(string msg)
        {
            Console.WriteLine($"{Name}: Enviada <= {msg}");
            mediator.SendMessage(msg, this);
        }
    }
}