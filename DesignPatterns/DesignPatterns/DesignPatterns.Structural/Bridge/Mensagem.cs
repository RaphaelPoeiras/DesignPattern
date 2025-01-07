using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public abstract class Mensagem
    {
        protected IDespachaMensagem enviarMensagem;

        public Mensagem(IDespachaMensagem _enviarMensagem)
        {
            enviarMensagem = _enviarMensagem;
        }

        public abstract void MontarMensagem();

        public virtual void EnviaMensagem()
        {
            MontarMensagem();
            enviarMensagem.EnviarMensagem();
        }
    }
}