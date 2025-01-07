using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public class ConcreteSubject : ISubject
    {
        List<IObserver> observers = new List<IObserver>(); 

        private string Produto { get; set; }
        private int Preco { get; set; } 
        private string Disponibilidade { get; set; }

        public ConcreteSubject(string produto, int preco, string status)
        {
            Produto = produto;  
            Preco = preco;
            Disponibilidade = status;
        }

        public string GetDisponibilidade()
        {
            return Disponibilidade;
        }

        public void SetDisponibilidade(string status)
        {
            this.Disponibilidade = status;
            Console.WriteLine("A disponibilidade mudou de 'sem estoque' para 'disponivel'");
            NotificaObserver();
        }

        public void NotificaObserver()
        {
            Console.WriteLine($"O produto {Produto} agora está disponível");

            foreach (var observer in observers)
            {
                observer.Atualiza("Disponível");
            }
        }

        public void RegistrarObserver(IObserver observer)
        {
            observers.Add(observer);    
        }

        public void RemoverObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
