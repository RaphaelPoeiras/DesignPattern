using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class MensagemAnexo : Mensagem
    {
        public MensagemAnexo(IDespachaMensagem enviarMensagem) : base(enviarMensagem) { }

        public override void MontarMensagem()
        {
            Console.WriteLine("Mensagem com anexo");
        }
    }
}