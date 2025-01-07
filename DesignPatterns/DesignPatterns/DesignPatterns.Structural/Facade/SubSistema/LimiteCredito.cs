using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade.SubSistema
{
    public class LimiteCredito
    {
        public bool PossuiLimiteCredito(Cliente cliente, decimal valor)
        {
            Console.WriteLine($"Verificando Limite de crédito do cliente. {cliente.Nome}");

            if(valor > 200000.00M)
            {
                return false;
            }

            return true;

        }
    }
}
