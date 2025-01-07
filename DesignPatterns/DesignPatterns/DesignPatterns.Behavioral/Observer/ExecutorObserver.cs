using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public class ExecutorObserver
    {
        public void Execute()
        {
            ConcreteSubject Iphone11 = new ConcreteSubject("Iphone11", 12200, "Indiponível");
            
            ConcreteObserver raphael = new ConcreteObserver("Raphael", Iphone11);
            ConcreteObserver priscila = new ConcreteObserver("Priscila", Iphone11);
            ConcreteObserver benicio = new ConcreteObserver("Benicio", Iphone11);

            Console.WriteLine("Alterar Disponibilidade");

            Iphone11.SetDisponibilidade("Disponível");

            Console.ReadKey();
        }
    }
}