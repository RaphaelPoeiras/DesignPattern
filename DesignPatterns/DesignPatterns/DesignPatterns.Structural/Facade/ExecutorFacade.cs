using DesignPatterns.Structural.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Façade
{
    public class ExecutorFacade
    {
        public void Execute()
        {
            var cliente = new Cliente("Walter");
            var concederEmprestimo = new Credito().ConcedeEmprestimo(cliente, 190000.00M);

            Console.WriteLine($"Emprestimo para o cliente {cliente.Nome} foi " + (concederEmprestimo ? "Aprovado" : "Negado"));
            Console.ReadKey();
        }
    }
}