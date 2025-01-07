namespace DesignPatterns.Behavioral.State
{
    public class CaixaEletronico : ICaixaEletronicoState
    {
        public ICaixaEletronicoState caixaEletronicoState { get; set; } 
        public CaixaEletronico()
        {
            caixaEletronicoState = new CartaoNaoInseridoState();
        }

        public void EjetarCartao()
        {
            caixaEletronicoState.EjetarCartao();

            if (caixaEletronicoState is CartaoInseridoState)
            {
                caixaEletronicoState = new CartaoNaoInseridoState();
                Console.WriteLine($"O estado interno do caixa eletronico foi alterado para: {caixaEletronicoState.GetType().Name}");
            }
        }

        public void InformarSenha()
        {
            caixaEletronicoState.InformarSenha();
        }

        public void InserirCartao()
        {
            caixaEletronicoState.InserirCartao();

            if (caixaEletronicoState is CartaoNaoInseridoState)
            {
                caixaEletronicoState = new CartaoInseridoState();
                Console.WriteLine($"O estado interno do caixa eletronico foi alterado para: {caixaEletronicoState.GetType().Name}");
            }
        }

        public void SacarDinheiro()
        {
            caixaEletronicoState.SacarDinheiro();
        }
    }
}