using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class MassaEspecial : PizzaDecorator
    {
        public MassaEspecial(IPizza pizza) : base(pizza)
        {
        }

        public override string Opcionais()
        {
            var opcional = base.Opcionais();
            opcional += " com massa especial";
            return opcional;
        }

        public override decimal Preco()
        {
            var preco = base.Preco();
            preco += 2.50M;
            return preco;
        }
    }
}