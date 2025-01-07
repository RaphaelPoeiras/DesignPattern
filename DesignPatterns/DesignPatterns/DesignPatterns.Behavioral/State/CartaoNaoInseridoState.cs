namespace DesignPatterns.Behavioral.State
{
    public class CartaoNaoInseridoState : ICaixaEletronicoState
    {
        public void EjetarCartao()
        {
            Console.WriteLine($"Não é possível ejetar por que o cartão não está inserido");
        }

        public void InformarSenha()
        {
            Console.WriteLine($"Não é possível informar senha por que o cartão não está inserido");
        }

        public void InserirCartao()
        {
            Console.WriteLine($"Cartão inserido com sucesso");
        }

        public void SacarDinheiro()
        {
            Console.WriteLine($"Não é possível sacar dinheiro por que o cartão não está inserido");
        }
    }
}