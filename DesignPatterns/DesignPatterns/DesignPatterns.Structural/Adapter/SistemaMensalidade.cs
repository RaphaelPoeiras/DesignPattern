using DesignPatterns.Structural.Adapter.Domain;

namespace DesignPatterns.Structural.Adapter
{
    public class SistemaMensalidade
    {
        public void CalculaMensalidade(List<Aluno> alunos)
        {
            foreach (var item in alunos)
            {
                var mensalidade = item.Mensalidade * 1.1M;

                Console.WriteLine($"Aluno {item.Nome} - Valor Mensalidade R$ {mensalidade}");
            }
        }
    }
}