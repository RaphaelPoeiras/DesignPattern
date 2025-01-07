namespace DesignPatterns.Behavioral.State
{
    public class ExecutorState
    {
        public void Execute()
        {
            CaixaEletronico caixaEletronico = new CaixaEletronico();
            Console.WriteLine($"Estado atual do Caixa Eletrônico : {caixaEletronico.caixaEletronicoState.GetType().Name}");
            Console.WriteLine();

            caixaEletronico.InformarSenha();
            caixaEletronico.SacarDinheiro();
            caixaEletronico.EjetarCartao();
            caixaEletronico.InserirCartao();
            Console.WriteLine();

            Console.WriteLine($"Estado atual do Caixa Eletrônico : {caixaEletronico.caixaEletronicoState.GetType().Name}");

            Console.WriteLine();

            caixaEletronico.InformarSenha();
            caixaEletronico.SacarDinheiro();
            caixaEletronico.InserirCartao();
            caixaEletronico.EjetarCartao();
            Console.WriteLine();
        }
    }
}