using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class ExecutorChainOfResponsibility
    {
        public void Execute()
        {
            GerenteProjeto gerenteProjeto = new GerenteProjeto();
            Supervisor supervisor = new Supervisor();   
            RH rH = new RH();

            gerenteProjeto.ProximoAutorizador(supervisor);
            supervisor.ProximoAutorizador(rH);

            gerenteProjeto.AutorizarLicenca("Raphael", 10);
            gerenteProjeto.AutorizarLicenca("Priscila", 3);
            gerenteProjeto.AutorizarLicenca("Benício", 20);
            gerenteProjeto.AutorizarLicenca("Bia", 35);
        }
    }
}