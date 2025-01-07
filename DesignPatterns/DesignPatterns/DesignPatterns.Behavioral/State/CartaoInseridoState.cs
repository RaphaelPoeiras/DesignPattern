namespace DesignPatterns.Behavioral.State
{
    public class CartaoInseridoState : ICaixaEletronicoState
    {
        public void EjetarCartao()
        {
            Console.WriteLine($"Cartão ejetado com sucesso");
        }

        public void InformarSenha()
        {
            Console.WriteLine($"Senha inserida com sucesso");
        }

        public void InserirCartao()
        {
            Console.WriteLine($"Cartão já está inserido");
        }

        public void SacarDinheiro()
        {
            Console.WriteLine($"O saque foi realizado com sucesso");
        }
    }
}