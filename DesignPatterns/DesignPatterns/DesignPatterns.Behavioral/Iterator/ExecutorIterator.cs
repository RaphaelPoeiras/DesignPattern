using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Iterator
{
    public class ExecutorIterator
    {
        public void Execute()
        {
            ConcreteCollection concreteCollection = new ConcreteCollection();

            concreteCollection.AddCliente(new Cliente("Raphael", 22));
            concreteCollection.AddCliente(new Cliente("Priscila", 25));
            concreteCollection.AddCliente(new Cliente("Benício", 14));

            Iterator iterator = concreteCollection.CreateIterator();

            Console.WriteLine("Digite algo para iniciar");
            Console.ReadKey();

            for (Cliente cliente = iterator.First(); !iterator.IsDone; cliente = iterator.Next())
            {
                Console.WriteLine($"{cliente.Nome} - {cliente.Id}");
            }

            Console.ReadKey();
        }
    }
}
