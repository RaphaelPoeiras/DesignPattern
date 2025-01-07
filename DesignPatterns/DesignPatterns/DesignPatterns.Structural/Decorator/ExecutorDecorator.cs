using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class ExecutorDecorator
    {
        public void Execute()
        {
            IPizza pizzaMussarela = new Pizza("Mussarela");
            Console.WriteLine(pizzaMussarela.Opcionais());
            Console.WriteLine(pizzaMussarela.Preco());

            IPizza massaEspecial = new MassaEspecial(pizzaMussarela);
            IPizza bacon = new Bacon(massaEspecial);
            IPizza bordaRecheada = new BordaRecheada(bacon);

            Console.WriteLine(bordaRecheada.Opcionais());
            Console.WriteLine(bordaRecheada.Preco());
        }
    }
}