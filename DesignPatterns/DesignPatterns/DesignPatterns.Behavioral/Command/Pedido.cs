namespace DesignPatterns.Behavioral.Command
{
    public class Pedido : Command
    {
        private Chef Chef { get; set; }
        private string Acao { get; set; }

        public Pedido(Chef chef, string acao)
        {
            Chef = chef;
            Acao = acao;
        }
        public override void Execute()
        {
            if (Chef == null) return;

            if(Acao == "Prato")
            {
                Chef.PreparandoPrato();
                return;
            }

            if (Acao == "Sobremesa")
            {
                Chef.PreparandoSobremesa();
                return;
            }
        }
    }
}