using DesignPatterns.Structural.Facade.SubSistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    public class Credito
    {
        private LimiteCredito limite;
        private Serasa serasa;
        private Cadin cadin;
        private Cadastro cadastro;

        public Credito()
        {
            limite = new LimiteCredito();
            serasa = new Serasa();
            cadin = new Cadin();
            cadastro = new Cadastro();
        }

        public bool ConcedeEmprestimo(Cliente cliente, decimal valor)
        {
            Console.WriteLine($"{cliente.Nome} está peitando um emprestimo no valor de {valor}");

            cadastro.CadastrarCliente(cliente);

            bool concedeEmprestimo = true;

            if (serasa.DividasAtivas(cliente))
            {
                Console.WriteLine($"{cliente.Nome} está no Serasa");
                concedeEmprestimo = false;
            }
            else if (cadin.DividasAtivasCadin(cliente))
            {
                Console.WriteLine($"{cliente.Nome} está no Cadin");
                concedeEmprestimo = false;
            }
            else if (!limite.PossuiLimiteCredito(cliente, valor))
            {
                Console.WriteLine($"{cliente.Nome} não possuí limite de crédito");
                concedeEmprestimo = false;
            }

            return concedeEmprestimo;
        }
    }
}
