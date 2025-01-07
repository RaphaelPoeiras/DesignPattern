using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    public class ExecutorComposite
    {
        public void Execute()
        {
            Organizacao organizacao = new Organizacao() { Nome = "Pottencial"};

            Organizacao departamentoTI = new Organizacao() { Nome = "TI" };

            departamentoTI.Add(new Funcionario { Nome = "Vinicius", Horas = 18 });
            departamentoTI.Add(new Funcionario { Nome = "Victor", Horas = 21 });
            departamentoTI.Add(new Funcionario { Nome = "Elias", Horas = 33 });
            departamentoTI.Add(new Funcionario { Nome = "Raphael", Horas = 22 });

            Organizacao departamentoRH = new Organizacao() { Nome = "RH" };
            departamentoRH.Add(new Funcionario { Nome = "Priscila", Horas = 93 });
            departamentoRH.Add(new Funcionario { Nome = "Beatriz", Horas = 9 });
            departamentoRH.Add(new Funcionario { Nome = "Marcela", Horas = 14 });
            departamentoRH.Add(new Funcionario { Nome = "Gabriela", Horas = 33 });
            departamentoRH.Add(new Funcionario { Nome = "Alice", Horas = 22 });

            organizacao.Add(departamentoRH);
            organizacao.Add(departamentoTI);

            organizacao.GetHoraTrabalhada();
        }
    }
}