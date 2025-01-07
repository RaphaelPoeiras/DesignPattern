namespace DesignPatterns.Behavioral.State
{
    public interface ICaixaEletronicoState
    {
        void EjetarCartao();
        void InformarSenha();
        void InserirCartao();
        void SacarDinheiro();
    }
}