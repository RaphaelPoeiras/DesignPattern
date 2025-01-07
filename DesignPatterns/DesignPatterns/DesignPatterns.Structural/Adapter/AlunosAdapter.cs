using DesignPatterns.Structural.Adapter.Domain;

namespace DesignPatterns.Structural.Adapter
{
    public class AlunosAdapter : ICalculaMensalidade
    {
        private SistemaMensalidade SistemaMensalidade = new SistemaMensalidade();
        public void ProcessaCalculoMensalidade(string[,] alunosArray)
        {
            List<Aluno> alunos = new List<Aluno>();

            ConvertArrayParaList(alunosArray, alunos);

            SistemaMensalidade.CalculaMensalidade(alunos);
        }

        private void ConvertArrayParaList(string[,] alunosArray, List<Aluno> alunos)
        {
            string id = null;
            string nome = null;
            string materia = null;
            string mensalidade = null;

            for (int i = 0; i < alunosArray.GetLength(0); i++)
            {
                for (int j = 0; j < alunosArray.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        id = alunosArray[i, j];
                    }
                    else if (j == 1)
                    {
                        nome = alunosArray[i, j];
                    }
                    else if (j == 2)
                    {
                        materia = alunosArray[i, j];
                    }
                    else
                    {
                        mensalidade = alunosArray[i, j];
                    }

                }
                alunos.Add(new Aluno(Convert.ToInt32(id), nome, Convert.ToDecimal(mensalidade)));
            }
        }
    }
}