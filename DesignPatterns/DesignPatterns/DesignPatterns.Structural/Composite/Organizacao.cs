using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    public class Organizacao : HoraTrabalhada
    {
        protected List<HoraTrabalhada> departamentos = new List<HoraTrabalhada>();

        public override void Add(HoraTrabalhada component)
        {
            departamentos.Add(component);
        }

        public override int GetHoraTrabalhada()
        {
            var horasTrabalhadasDepartamento = 0;
            foreach (var item in departamentos)
            {
                horasTrabalhadasDepartamento += item.GetHoraTrabalhada();
            }

            Console.WriteLine($"{Nome} registrou um total de {horasTrabalhadasDepartamento} ");
            return horasTrabalhadasDepartamento;
        }
    }
}
