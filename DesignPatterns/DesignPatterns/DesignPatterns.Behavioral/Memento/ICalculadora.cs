using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Memento
{
    public interface ICalculadora
    {
        ICaretaker BackupUltimoCalculo();
        void RestauraUltimoCalculo(ICaretaker memento);
        int GetCalculoResultado();
        void SetPrimeiroNumero(int num1);
        void SetSegundoNumero(int num2);
    }
}
