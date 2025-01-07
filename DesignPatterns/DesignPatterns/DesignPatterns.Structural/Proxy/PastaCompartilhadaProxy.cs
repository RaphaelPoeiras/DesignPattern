using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    public class PastaCompartilhadaProxy : IPastaCompartilhada
    {
        private IPastaCompartilhada pasta;
        private Funcionario funcionario;

        public PastaCompartilhadaProxy(Funcionario funco)
        {
            funcionario = funco;
        }

        public void OperacaoLeituraGravacao()
        {
            if (funcionario.Perfil.ToUpper() == "CEO")
            {
                pasta = new PastaCompartilhada();
                Console.WriteLine("O proxy pasta compartilhada invoca o metodo de leitura e gravacao");
                pasta.OperacaoLeituraGravacao();
            }
            else
            {
                Console.WriteLine("Proxy avisa que vc não tem permissão");
            }
        }
    }
}
