namespace DesignPatterns.Structural.Adapter
{
    public class ExecutorAdapter
    {
        public void Execute()
        {
            var alunos = SistemaEscolar.GetListaAlunosMensalidades();

            ICalculaMensalidade calculoMensalidade = new AlunosAdapter();

            calculoMensalidade.ProcessaCalculoMensalidade(alunos);
        }
    }
}