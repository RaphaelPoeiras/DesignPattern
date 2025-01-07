using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    public class ExecutorCommand
    {
        public void Execute()
        {
            Chef chef = new Chef();

            Pedido pedido = new Pedido(chef, "Prato");
            Garcom garcon = new Garcom(pedido);

            garcon.Execute();

            pedido = new Pedido(chef, "Sobremesa");
            garcon = new Garcom(pedido);

            garcon.Execute();

            Console.ReadKey();
        }
    }
}
