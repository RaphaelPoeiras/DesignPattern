namespace DesignPatterns.Behavioral.Mediator
{
    public abstract class User
    {
        protected FacebookGroupMediator mediator;
        protected string Name { get; set; }

        public User(FacebookGroupMediator mediator, string name)
        {
            Name = name;
            this.mediator = mediator;
        }

        public abstract void Receive(string msg);

        public abstract void Send(string msg);

    }
}