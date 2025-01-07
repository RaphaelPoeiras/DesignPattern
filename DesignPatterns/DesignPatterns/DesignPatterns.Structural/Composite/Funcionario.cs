using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    public class Funcionario : HoraTrabalhada
    {
        public int Horas { get; set; }
        public override int GetHoraTrabalhada()
        {
            Console.WriteLine($"O funcionário {Nome} registrou {Horas} trabalhadas");
            return Horas;
        }
    }
}