using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Memento
{
    public class ExecutorMemento
    {
        public void Execute()
        {
            Console.WriteLine("Padrão Memento");

            ICalculadora calculadora = new Calculadora();

            calculadora.SetPrimeiroNumero(33);
            calculadora.SetSegundoNumero(84);

            Console.WriteLine($"Estado 1: {calculadora.GetCalculoResultado()}");

            ICaretaker memento = calculadora.BackupUltimoCalculo();

            Console.ReadKey();

            calculadora.SetPrimeiroNumero(21);
            calculadora.SetSegundoNumero(66);

            Console.WriteLine($"Estado 2:  {calculadora.GetCalculoResultado()}");

            calculadora.RestauraUltimoCalculo(memento);
            Console.WriteLine($"Estado restaurado: {calculadora.GetCalculoResultado()}");

            Console.ReadKey();
        }
    }
}
