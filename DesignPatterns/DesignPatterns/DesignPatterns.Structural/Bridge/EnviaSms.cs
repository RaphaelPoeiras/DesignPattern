using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class EnviaSms : IDespachaMensagem
    {
        public void EnviarMensagem()
        {
            Console.WriteLine("Sms Enviado");
        }
    }
}